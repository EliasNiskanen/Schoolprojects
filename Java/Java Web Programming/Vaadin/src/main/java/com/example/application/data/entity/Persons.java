package com.example.application.data.entity;

import jakarta.persistence.Entity;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;
import jakarta.validation.constraints.Email;
import java.time.LocalDate;

@Entity
@Table(name = "persons")
public class Persons extends AbstractEntity {

    private Integer personid;
    private String etunimi;
    private String sukunimi;
    @Email
    private String email;
    private String puh;
    private LocalDate syntymaaika;

    @ManyToOne
    private Mittaukset mittaukset;

    public Integer getPersonid() {
        return personid;
    }

    public void setPersonid(Integer personid) {
        this.personid = personid;
    }

    public String getEtunimi() {
        return etunimi;
    }

    public void setEtunimi(String etunimi) {
        this.etunimi = etunimi;
    }

    public String getSukunimi() {
        return sukunimi;
    }

    public void setSukunimi(String sukunimi) {
        this.sukunimi = sukunimi;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPuh() {
        return puh;
    }

    public void setPuh(String puh) {
        this.puh = puh;
    }

    public LocalDate getSyntymaaika() {
        return syntymaaika;
    }

    public void setSyntymaaika(LocalDate syntymaaika) {
        this.syntymaaika = syntymaaika;
    }

    public Mittaukset getMittaukset() {
        return mittaukset;
    }

    public void setMittaukset(Mittaukset mittaukset) {
        this.mittaukset = mittaukset;
    }
    public Mittaukset getMittauksetWithPersonId() {
        if (mittaukset == null) {
            return null;
        } else if (mittaukset.getPersonid().equals(this.personid)) {
            return mittaukset;
        } else {
            return null;
        }
    }

    public void setMittauksetWithPersonId(Mittaukset mittaukset) {
        this.mittaukset = mittaukset;
        if (mittaukset != null) {
            mittaukset.setPersonid(this.personid);
        }
    }
}
