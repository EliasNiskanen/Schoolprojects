package com.company;

public class Ruoka extends Tuote{
    private String Maa;
    private String Paivays;

    public Ruoka(String Nimi, int Hinta, String Hyllypaikka, int Koodi, String Maa, String Paivays) {
        super(Nimi, Hinta, Hyllypaikka, Koodi);
        this.Maa = Maa;
        this.Paivays = Paivays;
    }

    public Ruoka(String Nimi, int Hinta, String Hyllypaikka, int Koodi) {
    }

    public String getMaa(){return Maa;}
    public void setMaa(String Maa) {this.Maa = Maa;}

    public String getPaivays() {return Paivays;}
    public void setPaivays(String Paivays) {this.Paivays = Paivays;}

    @Override
    public String toString() {
        return "Ruoka: Nimi: " + super.getNimi() + ", Hinta: " + super.getHinta() +
                "€" + ", Hyllypaikka: " + getHyllypaikka() + ", Koodi: " + getKoodi() + ", Valmistusmaa: "+ getMaa() + "Päiväys: " + getPaivays();
    }
}
