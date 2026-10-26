package com.example.Task2;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MittausDataService {

    @Autowired
    private MittausDataRepository mittausDataRepository;

    public List<MittausData> getMittausData() {
        return mittausDataRepository.findAll();
    }

    public void saveMittausData(MittausData mittausData) {
        mittausDataRepository.save(mittausData);
    }

    public MittausData getMittausDataById(Long id) {
        return mittausDataRepository.findById(id).orElse(null);
    }

    public void updateMittausData(MittausData mittausData) {
        mittausDataRepository.save(mittausData);
    }

    public void deleteMittausDataById(Long id) {
        mittausDataRepository.deleteById(id);
    }
}
