package com.company;

public class Tuote {
    private String Tyyppi; 
    private String Nimi;
    private int Hinta;
    private String Hyllypaikka;
    private int Koodi;

    public Tuote(){

    }

    public Tuote(String Tyyppi, String Nimi, int Hinta, String Hyllypaikka, int Koodi){
        this.Nimi = Nimi;
        this.Hinta = Hinta;
        this.Hyllypaikka = Hyllypaikka;
        this.Koodi = Koodi;

    }

    public Tuote(String nimi, int hinta, String hyllypaikka, int koodi) {
    }

    public String getTyyppi() {return Tyyppi;}
    public void setTyyppi(String Tyyppi) {this.Tyyppi = Tyyppi;}
    
    public String getNimi() {return Nimi;}
    public void setNimi(String Nimi) {this.Nimi = Nimi;}

    public int getHinta() {return Hinta;}
    public void setHinta(int Hinta) {this.Hinta = Hinta;}

    public String getHyllypaikka() {return Hyllypaikka;}
    public void setHyllypaikka(String Hyllypaikka) {this.Hyllypaikka = Hyllypaikka;}

    public int getKoodi() {return Koodi;}
    public void setKoodi(int Koodi) {this.Koodi = Koodi;}

    @Override
    public String toString() {
        return "Tuote{" +
                "Nimi='" + Nimi + '\'' +
                ", Hinta='" + Hinta + '\'' +
                ", Hyllypaikka='" + Hyllypaikka + '\'' +
                ", Koodi='" + Koodi + '\'' +
                '}';
    }

    public void setMaa(String nextLine) {
    }

    public void setPaivays(String nextLine) {
    }

    public void setKoko(String nextLine) {
    }

    public void setMateriaali(String nextLine) {
    }

    public void setTakuu(int nextInt) {
    }

    public void setPaino(int nextInt) {
    }
}
