package com.example.Task3;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import java.util.List;
import java.util.ArrayList;

import java.sql.Date;

@Entity
public class MittausPaikka {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String paikkatunniste;
    private String postinumero;
    private String postitoimipaikka;
    private Double leveysaste;
    private Double pituusaste;
    private String mittausyksikko;
    private Date aikaväli;

    @OneToMany(mappedBy = "mittausPaikka")
    private List<MittausData> mittausDataList = new ArrayList<>();

    public List<MittausData> getMittausDataList() {
        return mittausDataList;
    }

    public void setMittausDataList(List<MittausData> mittausDataList) {
        this.mittausDataList = mittausDataList;
    }
    
    
    public MittausPaikka() {}

    public MittausPaikka(String paikkatunniste, String postinumero, String postitoimipaikka, Double leveysaste, Double pituusaste, String mittausyksikko, Date aikaväli) {
        this.paikkatunniste = paikkatunniste;
        this.postinumero = postinumero;
        this.postitoimipaikka = postitoimipaikka;
        this.leveysaste = leveysaste;
        this.pituusaste = pituusaste;
        this.mittausyksikko = mittausyksikko;
        this.aikaväli = aikaväli;
    }

    
    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getPaikkatunniste() {
        return paikkatunniste;
    }

    public void setPaikkatunniste(String paikkatunniste) {
        this.paikkatunniste = paikkatunniste;
    }

    public String getPostinumero() {
        return postinumero;
    }

    public void setPostinumero(String postinumero) {
        this.postinumero = postinumero;
    }

    public String getPostitoimipaikka() {
        return postitoimipaikka;
    }

    public void setPostitoimipaikka(String postitoimipaikka) {
        this.postitoimipaikka = postitoimipaikka;
    }

    public Double getLeveysaste() {
        return leveysaste;
    }

    public void setLeveysaste(Double leveysaste) {
        this.leveysaste = leveysaste;
    }

    public Double getPituusaste() {
        return pituusaste;
    }

    public void setPituusaste(Double pituusaste) {
        this.pituusaste = pituusaste;
    }

    public String getMittausyksikko() {
        return mittausyksikko;
    }

    public void setMittausyksikko(String mittausyksikko) {
        this.mittausyksikko = mittausyksikko;
    }

    public Date getAikaväli() {
        return aikaväli;
    }

    public void setAikaväli(Date aikaväli) {
        this.aikaväli = aikaväli;
    }
}
