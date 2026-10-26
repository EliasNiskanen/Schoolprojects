package com.example.Task2;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;
import org.springframework.web.server.ResponseStatusException;
import java.util.List;

import org.springframework.ui.Model; // corrected import statement
import jakarta.persistence.EntityNotFoundException;

@Controller
public class MittausDataController {

	@Autowired
	private MittausDataService mittausDataService;

	@GetMapping("/")
	public String viewHomePage(Model model) {
	    List<MittausData> mittausDataList = mittausDataService.getMittausData();
	    model.addAttribute("mittausDataList", mittausDataList);
	    return "index";
	}

	@GetMapping("/showNewMittausDataForm")
	public String showNewMittausDataForm(Model model) {
	    MittausData mittausData = new MittausData();
	    model.addAttribute("mittausData", mittausData);
	    return "new_mittausdata";
	}

	@PostMapping("/saveMittausData")
	public String saveMittausData(@ModelAttribute("mittausData") MittausData mittausData) {
	    mittausDataService.saveMittausData(mittausData);
	    return "redirect:/";
	}

	@GetMapping("/showFormForUpdate/{id}")
	public String showFormForUpdate(@PathVariable(value = "id") Long id, Model model) {
	    MittausData mittausData = mittausDataService.getMittausDataById(id);
	    model.addAttribute("mittausData", mittausData);
	    return "update_mittausdata";
	}

	@PostMapping("/updateMittausData")
	public String updateMittausData(@ModelAttribute("mittausData") MittausData mittausData) {
	    mittausDataService.updateMittausData(mittausData);
	    return "redirect:/";
	}

	@GetMapping("/deleteMittausData/{id}")
	public String deleteMittausData(@PathVariable(value = "id") Long id) {
	    mittausDataService.deleteMittausDataById(id);
	    return "redirect:/";
	}

}
