package com.example.Task2;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;
@Repository
public interface MittausDataRepository extends JpaRepository<MittausData, Long> 
{
	
	
	
	List<MittausData> findAll();
	MittausData findById(long id);
	< S extends MittausData > S save ( S entity );
	
}