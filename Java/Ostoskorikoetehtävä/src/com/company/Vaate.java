package com.company;

public class Vaate extends Tuote {
    private String Koko;
    private String Materiaali;

    public Vaate(String Nimi, int Hinta, String Hyllypaikka, int Koodi, String Koko, String Materiaali){
        super (Nimi, Hinta, Hyllypaikka, Koodi);
        this.Koko = Koko;
        this.Materiaali = Materiaali;
    }

    public Vaate(String Nimi, int Hinta, String Hyllypaikka, int Koodi) {
    }

    public String getKoko(){return Koko;}
    public void setKoko(String Koko) {this.Koko = Koko;}

    public String getMateriaali(){return Materiaali;}
    public void setMateriaali(String Materiaali) {this.Materiaali = Materiaali;}

    @Override
    public String toString() {
        return "Vaate: Nimi: " + super.getNimi() + ", Hinta: " + super.getHinta() +
                "€" + ", Hyllypaikka: " + getHyllypaikka() + ", Koodi: " + getKoodi() + ", Koko: " + getKoko() + "Materiaali: " + getMateriaali();
    }
}
