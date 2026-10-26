package com.example.application.data.service;

import com.example.application.data.entity.Persons;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;

public interface PersonsRepository extends JpaRepository<Persons, Long>, JpaSpecificationExecutor<Persons> {

}
