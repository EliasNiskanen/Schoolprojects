package com.example.Task2;

import java.sql.Date;

import org.hibernate.annotations.CreationTimestamp;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Temporal;
import jakarta.persistence.TemporalType;

@Entity
public class MittausData {

   @Id
   @GeneratedValue(strategy = GenerationType.IDENTITY)
   private Long id;

   private String mittausyksikko;
   private Double maara;
   private String paikkatunniste;
   @CreationTimestamp
   @Temporal(TemporalType.DATE)
   private Date kellonaikaJaPaivamaara;

   public Long getId() {
       return id;
   }

   public void setId(Long id) {
       this.id = id;
   }

   public String getMittausyksikko() {
       return mittausyksikko;
   }

   public void setMittausyksikko(String mittausyksikko) {
       this.mittausyksikko = mittausyksikko;
   }

   public Double getMaara() {
       return maara;
   }

   public void setMaara(Double maara) {
       this.maara = maara;
   }

   public String getPaikkatunniste() {
       return paikkatunniste;
   }

   public void setPaikkatunniste(String paikkatunniste) {
       this.paikkatunniste = paikkatunniste;
   }

   public Date getKellonaikaJaPaivamaara() {
       return kellonaikaJaPaivamaara;
   }

   public void setKellonaikaJaPaivamaara(Date kellonaikaJaPaivamaara) {
       this.kellonaikaJaPaivamaara = kellonaikaJaPaivamaara;
   }
}
