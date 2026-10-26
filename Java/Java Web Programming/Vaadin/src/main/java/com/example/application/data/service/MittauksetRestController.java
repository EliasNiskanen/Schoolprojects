package com.example.application.data.service;

import com.example.application.data.entity.Mittaukset;
import com.example.application.data.service.MittauksetService;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api")
public class MittauksetRestController {

    private final MittauksetService mittauksetService;

    @Autowired
    public MittauksetRestController(MittauksetService mittauksetService) {
        this.mittauksetService = mittauksetService;
    }

 
    @GetMapping("/mittaukset")
    public ResponseEntity<List<Mittaukset>> listMittaukset(Pageable pageable) {
        Page<Mittaukset> page = mittauksetService.list(pageable);
        List<Mittaukset> mittaukset = page.getContent();
        return new ResponseEntity<List<Mittaukset>>(mittaukset, HttpStatus.OK);
    }

    @PostMapping("/mittaukset")
    public ResponseEntity<Mittaukset> createMittaus(@RequestBody Mittaukset mittaus) {
        Mittaukset newMittaus = mittauksetService.update(mittaus);
        return new ResponseEntity<Mittaukset>(newMittaus, HttpStatus.CREATED);
    }



    @DeleteMapping("/mittaukset/{id}")
    public ResponseEntity<Void> deleteMittaus(@PathVariable Long id) {
        mittauksetService.delete(id);
        return new ResponseEntity<Void>(HttpStatus.NO_CONTENT);
    }
}
