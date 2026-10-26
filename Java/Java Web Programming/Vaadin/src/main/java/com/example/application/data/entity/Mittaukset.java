package com.example.application.data.entity;

import jakarta.persistence.Entity;
import java.time.LocalDate;

@Entity
public class Mittaukset extends AbstractEntity {

    private Integer personid;
    private Integer mittausid;
    private Integer paino;
    private Integer pituus;
    private Integer verenpaine;
    private Integer syke;
    private Integer verensokeri;
    private LocalDate mittauspvm;

    public Integer getPersonid() {
        return personid;
    }
    public void setPersonid(Integer personid) {
        this.personid = personid;
    }
    public Integer getMittausid() {
        return mittausid;
    }
    public void setMittausid(Integer mittausid) {
        this.mittausid = mittausid;
    }
    public Integer getPaino() {
        return paino;
    }
    public void setPaino(Integer paino) {
        this.paino = paino;
    }
    public Integer getPituus() {
        return pituus;
    }
    public void setPituus(Integer pituus) {
        this.pituus = pituus;
    }
    public Integer getVerenpaine() {
        return verenpaine;
    }
    public void setVerenpaine(Integer verenpaine) {
        this.verenpaine = verenpaine;
    }
    public Integer getSyke() {
        return syke;
    }
    public void setSyke(Integer syke) {
        this.syke = syke;
    }
    public Integer getVerensokeri() {
        return verensokeri;
    }
    public void setVerensokeri(Integer verensokeri) {
        this.verensokeri = verensokeri;
    }

    public LocalDate getMittauspvm() {
        return mittauspvm;
    }
    public void setMittauspvm(LocalDate mittauspvm) {
        this.mittauspvm = mittauspvm;
    }

}
