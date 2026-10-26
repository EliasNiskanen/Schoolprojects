package com.example.Task4;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.concurrent.TimeUnit;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Configuration;
import org.springframework.http.CacheControl;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.config.annotation.ResourceHandlerRegistry;
import org.springframework.web.servlet.config.annotation.WebMvcConfigurer;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;

@Controller
public class ImageController {

    @Autowired
    private ImageRepository imageRepository;

    @GetMapping("/")
    public String index() {
        return "index.html";
    }

    @PostMapping("/upload")
    public String uploadFile(@RequestParam("file") MultipartFile file,
                             @RequestParam("owner") String owner,
                             RedirectAttributes redirectAttributes) {
        try {
          
            File uploadDir = new File("uploads");
            if (!uploadDir.exists()) {
                uploadDir.mkdir();
            }

            File uploadedFile = new File(uploadDir.getAbsolutePath() + "/" + file.getOriginalFilename());
            FileOutputStream fos = new FileOutputStream(uploadedFile);
            fos.write(file.getBytes());
            fos.close();
     
            Image image = new Image(file.getOriginalFilename(), owner, uploadedFile.getAbsolutePath());
            imageRepository.save(image);

            redirectAttributes.addFlashAttribute("successMessage", "File uploaded successfully!");
        } catch (IOException e) {
            redirectAttributes.addFlashAttribute("errorMessage", "Failed to upload file.");
        }
        return "redirect:/uploaded_images";
    }

    @GetMapping("/uploaded_images")
    public String showUploadedImages(Model model) {
        List<Image> images = imageRepository.findAll();
        model.addAttribute("images", images);
        return "uploaded_images.html";
    }
    @PostMapping("/delete/{id}")
    public String deleteImage(@PathVariable Long id, RedirectAttributes redirectAttributes) {
        try {
            Image image = imageRepository.findById(id)
                    .orElseThrow(() -> new RuntimeException("Image not found with id: " + id));
            imageRepository.delete(image);
            redirectAttributes.addFlashAttribute("successMessage", "Image deleted successfully.");
        } catch (Exception e) {
            redirectAttributes.addFlashAttribute("errorMessage", "An error occurred while deleting the image.");
        }
        return "redirect:/uploaded_images";
    }


    @Configuration
    public class MvcConfig implements WebMvcConfigurer {
        @Override
        public void addResourceHandlers(ResourceHandlerRegistry registry) {
            registry.addResourceHandler("/uploads/**")
                    .addResourceLocations("file:uploads/")
                    .setCacheControl(CacheControl.maxAge(1, TimeUnit.HOURS).cachePublic());
        }
    }
}