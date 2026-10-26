package com.company;



public class Kodinkone extends Tuote {
    private int Takuu;
    private int Paino;

    public Kodinkone(String Nimi, int Hinta, String Hyllypaikka, int Koodi, int Takuu, int Paino) {
        super(Nimi, Hinta, Hyllypaikka, Koodi);
        this.Takuu = Takuu;
        this.Paino = Paino;
    }

    public Kodinkone(String Nimi, int Hinta, String Hyllypaikka, int Koodi) {
    }

    public int getTakuu(int i) {return Takuu;}
    public void setTakuu(int Takuu) {this.Takuu = Takuu;}

    public int getPaino() {return Paino;}
    public void setPaino(int Paino) {this.Paino = Paino;}

    @Override
    public String toString() {
        return "Kodinkone: Nimi: " + super.getNimi() + ", Hinta: " + super.getHinta() +
                "€" + ", Hyllypaikka: " + getHyllypaikka() + ", Koodi: " + getKoodi() + ", Takuu vuosina: " + getTakuu(3) + "Paino: " + getPaino();
    }

}
