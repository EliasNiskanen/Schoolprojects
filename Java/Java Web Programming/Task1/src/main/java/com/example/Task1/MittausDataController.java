package com.example.Task1;

import java.util.List;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import jakarta.persistence.EntityNotFoundException;

@RestController
@RequestMapping("/mittausdata")
public class MittausDataController {

   @Autowired
   private MittausDataRepository mittausDataRepository;

   @GetMapping
   public List<MittausData> haeKaikkiTiedot() {
       return mittausDataRepository.findAll();
   }

   @PostMapping
   public MittausData tallennaTiedot(@RequestBody MittausData mittausData) {
       return mittausDataRepository.save(mittausData);
   }

   @PutMapping("/{id}")
   public MittausData paivitaTiedot(@PathVariable Long id, @RequestBody MittausData uudetTiedot) {
       MittausData vanhatTiedot = mittausDataRepository.findById(id)
           .orElseThrow(() -> new EntityNotFoundException("Mittaustietoja ei löytynyt id:llä " + id));
       vanhatTiedot.setMittausyksikko(uudetTiedot.getMittausyksikko());
       vanhatTiedot.setMaara(uudetTiedot.getMaara());
       vanhatTiedot.setPaikkatunniste(uudetTiedot.getPaikkatunniste());
       vanhatTiedot.setKellonaikaJaPaivamaara(uudetTiedot.getKellonaikaJaPaivamaara());
       return mittausDataRepository.save(vanhatTiedot);
   }

   @DeleteMapping("/{id}")
   public void poistaTiedot(@PathVariable Long id) {
       mittausDataRepository.deleteById(id);
   }
}
