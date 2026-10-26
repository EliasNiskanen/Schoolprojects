package com.example.application.data.service;

import com.example.application.data.entity.Persons;

import java.util.List;
import java.util.Optional;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.stereotype.Service;
import com.example.application.data.entity.Mittaukset;

@Service
public class PersonsService {

    private final PersonsRepository repository;

    public PersonsService(PersonsRepository repository) {
        this.repository = repository;
    }

    public Optional<Persons> get(Long id) {
        return repository.findById(id);
    }

    public Persons update(Persons entity) {
        return repository.save(entity);
    }

    public void delete(Long id) {
        repository.deleteById(id);
    }

    public Page<Persons> list(Pageable pageable) {
        return repository.findAll(pageable);
    }

    public Page<Persons> list(Pageable pageable, Specification<Persons> filter) {
        return repository.findAll(filter, pageable);
    }

    public int count() {
        return (int) repository.count();
    }
    public void delete(Persons persons) {
        Long id = persons.getId();
        repository.deleteById(id);
    }
    public List<Mittaukset> getMittaukset(Persons person) {
        return (List<Mittaukset>) person.getMittaukset();
    }

}
