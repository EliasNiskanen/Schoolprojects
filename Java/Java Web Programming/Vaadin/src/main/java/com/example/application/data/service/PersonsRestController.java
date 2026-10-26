package com.example.application.data.service;

import com.example.application.data.entity.Persons;
import com.example.application.data.service.PersonsService;


import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api")
public class PersonsRestController {

    private final PersonsService personsService;

    @Autowired
    public PersonsRestController(PersonsService personsService) {
        this.personsService = personsService;
    }



    @PostMapping("/persons")
    public ResponseEntity<Persons> createPerson(@RequestBody Persons person) {
        Persons newPerson = personsService.update(person);
        return new ResponseEntity<Persons>(newPerson, HttpStatus.CREATED);
    }

   

    @DeleteMapping("/persons/{id}")
    public ResponseEntity<Void> deletePerson(@PathVariable Long id) {
        personsService.delete(id);
        return new ResponseEntity<Void>(HttpStatus.NO_CONTENT);
    }
}


