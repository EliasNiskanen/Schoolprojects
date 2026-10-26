package com.example.Task3;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.sql.Date;
import java.util.List;

@Repository
public interface MittausPaikkaRepository extends JpaRepository<MittausPaikka, Long> {
    
    List<MittausPaikka> findByPostinumero(String postinumero);
    
    List<MittausPaikka> findByLeveysasteBetweenAndPituusasteBetween(Double latMin, Double latMax, Double lonMin, Double lonMax);
    
    List<MittausPaikka> findByMittausyksikko(String mittausyksikko);
    
    List<MittausPaikka> findByAikaväliBetween(Date startDate, Date endDate);

    
    MittausPaikka findByPaikkatunniste(String paikkatunniste);
}
