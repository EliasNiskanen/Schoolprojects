package com.example.application.data.service;

import com.example.application.data.entity.Mittaukset;
import org.springframework.data.jpa.repository.JpaRepository;

public interface MittauksetRepository extends JpaRepository<Mittaukset, Long> {
}
