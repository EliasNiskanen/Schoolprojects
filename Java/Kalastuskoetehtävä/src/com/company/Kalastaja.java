package com.company;

import java.util.Objects;

public class Kalastaja {

    private String Kn;
    private String Enimi;
    private String Snimi;
    private String Alue;
    private int HaukiSaalis;

    private int SuurinHauki;
    private int KuhaSaalis;
    private int SuurinKuha;

    @Override
    public String toString() { return Enimi + " " + Snimi + ", " + Alue + ", " + HaukiSaalis + ", Suurin: " + SuurinHauki + ", " + KuhaSaalis + ", Suurin: " + SuurinKuha;
    }

    public Kalastaja(){
    }
    public String getKn() {return Kn;}
    public void setKn(String Kn) {
        this.Kn = Kn;
    }
    public String getEnimi() {
        return Enimi;
    }
    public void setEnimi(String Enimi) {this.Enimi = Enimi;}
    public String getSnimi() {
        return Snimi;
    }
    public void setSnimi(String Snimi) {this.Snimi = Snimi;}
    public String getAlue() {return Alue;}
    public void setAlue(String Alue) {this.Alue = Alue;}
    public int getHaukiSaalis(){return HaukiSaalis;}
    public void setHaukiSaalis (int HaukiSaalis) {this.HaukiSaalis = HaukiSaalis;}
    public int getSuurinHauki(){return SuurinHauki;}
    public void setSuurinHauki (int SuurinHauki) {this.SuurinHauki = SuurinHauki;}
    public int getKuhaSaalis(){return KuhaSaalis;}
    public void setKuhaSaalis (int KuhaSaalis) {this.KuhaSaalis = KuhaSaalis;}
    public int getSuurinKuha(){return SuurinKuha;}
    public void setSuurinKuha (int SuurinKuha) {this.SuurinKuha = SuurinKuha;}

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (o == null || getClass() != o.getClass()) return false;
        Kalastaja kalastaja = (Kalastaja) o;
        return HaukiSaalis == kalastaja.HaukiSaalis && Objects.equals(Kn, kalastaja.Kn) && Objects.equals(Enimi, kalastaja.Enimi) && Objects.equals(Snimi, kalastaja.Snimi);
    }
    @Override
    public int hashCode() { return Objects.hash(Kn, Enimi, Snimi, Alue, HaukiSaalis, SuurinHauki, KuhaSaalis, SuurinKuha);}




}



