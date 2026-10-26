package com.example.Task3;

import java.sql.Date;
import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/mittauspaikka")
public class MittausPaikkaController {

    @Autowired
    private MittausPaikkaService mittausPaikkaService;

    // GET kaikki mittauspaikat
    @GetMapping("mittauspaikka")
    public List<MittausPaikka> getAllMittausPaikat() {
        return mittausPaikkaService.getAllMittausPaikat();
    }

    // GET mittauspaikat postinumeron perusteella
    @GetMapping("/postinumero/{postinumero}")
    public List<MittausPaikka> getMittausPaikatByPostinumero(@PathVariable String postinumero) {
        return mittausPaikkaService.getMittausPaikatByPostinumero(postinumero);
    }

    // GET mittauspaikat leveys- ja pituusasteen välillä
    @GetMapping("/sijainti")
    public List<MittausPaikka> getMittausPaikatBySijainti(@RequestParam Double latMin, 
                                                          @RequestParam Double latMax,
                                                          @RequestParam Double lonMin,
                                                          @RequestParam Double lonMax) {
        return mittausPaikkaService.getMittausPaikatBySijainti(latMin, latMax, lonMin, lonMax);
    }

    // POST tallenna uusi mittauspaikka
    @PostMapping
    public MittausPaikka saveMittausPaikka(@RequestBody MittausPaikka mittausPaikka) {
        return mittausPaikkaService.saveMittausPaikka(mittausPaikka);
    }

    // GET mittauspaikat tietyn mittausyksikön perusteella
    @GetMapping("/mittausyksikko/{mittausyksikko}")
    public List<MittausPaikka> getMittausPaikatByMittausyksikko(@PathVariable String mittausyksikko) {
        return mittausPaikkaService.getMittausPaikatByMittausyksikko(mittausyksikko);
    }

    // GET mittauspaikka tietyn paikkatunnisteen perusteella
    @GetMapping("/{paikkatunniste}")
    public MittausPaikka getMittausPaikkaByPaikkatunniste(@PathVariable String paikkatunniste) {
        return mittausPaikkaService.getMittausPaikkaByPaikkatunniste(paikkatunniste);
    }

    // GET mittauspaikkojen mittaukset tietyn aikavälin perusteella
    @GetMapping("/mittaus/{alkuaika}/{loppuaika}")
    public List<MittausPaikka> getMittausPaikkojenMittauksetByAikavali(@PathVariable Date alkuaika, 
                                                                  @PathVariable Date loppuaika) {
        return mittausPaikkaService.getMittausPaikkojenMittauksetByAikavali(alkuaika, loppuaika);
    }
}
