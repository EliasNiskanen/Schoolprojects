package com.example.application.data.service;

import com.example.application.data.entity.Mittaukset;
import com.example.application.data.entity.Persons;

import java.util.Optional;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.data.jpa.domain.Specification;
import org.springframework.stereotype.Service;

@Service
public class MittauksetService {

    private final MittauksetRepository repository;

    public MittauksetService(MittauksetRepository repository) {
        this.repository = repository;
    }

    public Optional<Mittaukset> get(Long id) {
        return repository.findById(id);
    }

    public Mittaukset update(Mittaukset entity) {
        return repository.save(entity);
    }

    public void delete(Long id) {
        repository.deleteById(id);
    }

    public Page<Mittaukset> list(Pageable pageable) {
        return repository.findAll(pageable);
    }

    public Page<Mittaukset> list(Pageable pageable, Specification<Mittaukset> filter) {
        return repository.findAll(pageable);
    }

    public int count() {
        return (int) repository.count();
    }
    public void delete(Mittaukset mittaus) {
        Long id = mittaus.getId();
        repository.deleteById(id);
    }


}
