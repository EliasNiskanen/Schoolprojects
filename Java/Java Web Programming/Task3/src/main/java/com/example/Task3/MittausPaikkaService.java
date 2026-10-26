package com.example.Task3;

import java.sql.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

@Service
public class MittausPaikkaService {

    @Autowired
    private MittausPaikkaRepository mittausPaikkaRepository;

    public List<MittausPaikka> getAllMittausPaikat() {
        return mittausPaikkaRepository.findAll();
    }

    public List<MittausPaikka> getMittausPaikatByPostinumero(String postinumero) {
        return mittausPaikkaRepository.findByPostinumero(postinumero);
    }

    public List<MittausPaikka> getMittausPaikatBySijainti(Double latMin, Double latMax, Double lonMin, Double lonMax) {
        return mittausPaikkaRepository.findByLeveysasteBetweenAndPituusasteBetween(latMin, latMax, lonMin, lonMax);
    }

    public MittausPaikka saveMittausPaikka(MittausPaikka mittausPaikka) {
        return mittausPaikkaRepository.save(mittausPaikka);
    }

    public List<MittausPaikka> getMittausPaikatByMittausyksikko(String mittausyksikko) {
        return mittausPaikkaRepository.findByMittausyksikko(mittausyksikko);
    }

    public MittausPaikka getMittausPaikkaByPaikkatunniste(String paikkatunniste) {
        return mittausPaikkaRepository.findByPaikkatunniste(paikkatunniste);
    }

    public List<MittausPaikka> getMittausPaikkojenMittauksetByAikavali(Date alkuaika, Date loppuaika) {
        return mittausPaikkaRepository.findByAikaväliBetween(alkuaika, loppuaika);
    }
}
