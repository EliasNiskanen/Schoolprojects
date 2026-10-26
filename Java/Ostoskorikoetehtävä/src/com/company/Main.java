package com.company;

import java.util.ArrayList;
import java.util.Objects;
import java.util.Scanner;

/*Pääset suunnittelemaan Ostoslista-sovellusta suuren kauppaketjun tuotekehitysosastolla. Tehtävänäsi on suunnitella luokkarakenne,
jolla voidaan hallinnoida sovelluksen tuotteita. Kaikilla tuotteilla on samat ominaisuudet: nimi, hinta, hyllypaikka sekä koodi.
 Nämä esitellään yliluokassa, jonka aliluokat perivät. Aliluokkia on kolme, joilla on omia ominaisuuksia:



a.                         Vaate: koko, materiaali

b.                         Ruoka: maa, paivays

c.                          Kodinkone: takuu, paino



Tee yksinkertainen ohjelma, jolla voit syöttää tuotteita yhdelle ostoslistalle sekä tulostaa koko ostoslistan sisällön.
Ostoslistassa on siis pelkät tuotteet, ei määriä. Luokkien jäsenmuuttujien tyyppejä ei ole määritelty eli saat päättää ne itse.
Ohjelmassa ensin valitaan minkä tyyppistä tuotetta ollaan syöttämässä, jonka jälkeen tiedot täytetään. Tässä ohjelmassa siis joudut tekemään konsoli-tyyppisen (ei JavaFX) käyttöliittymän tietojen syötölle. Syötteiden järkevyystarkastelua ei tarvitse tehdä. Ja tietysti lopuksi ostoslista tulostetaan.

Arviointi: Tuote- luokka 1p, Aliluokat 1 p, Pääohjelma 3p = yht 5 p
*/
public class Main {

    public static void main(String[] args) {
        ArrayList<Tuote> lista = new ArrayList<>();
        Scanner in = new Scanner(System.in);

        while (true) {
            Tuote t = new Tuote();

            System.out.print("Mikä tuote lisätään ostoskoriin? Vaihtoehdot: Vaate, Ruoka, Kodinkone (0 = Lopettaa syötön) :");
            t.setTyyppi(in.nextLine());
            if (Objects.equals(t.getTyyppi(), "Ruoka")) {
                System.out.print("Anna Nimi: ");
                t.setNimi(in.nextLine());
                System.out.print("Anna Hinta: ");
                t.setHinta(in.nextInt());
                System.out.print("Anna Hyllypaikka: ");
                t.setHyllypaikka(in.nextLine());
                System.out.print("Anna Koodi: ");
                t.setKoodi(in.nextInt());
                System.out.print("Anna Valmistusmaa: ");
                t.setMaa(in.nextLine());
                System.out.print("Anna Päiväys (dd.mm.yyyy): ");
                t.setPaivays(in.nextLine());
                in.nextLine();
                lista.add(t);

                if (Objects.equals(t.getTyyppi(), "Vaate")) {
                    System.out.print("Anna Nimi: ");
                    t.setNimi(in.nextLine());
                    System.out.print("Anna Hinta: ");
                    t.setHinta(in.nextInt());
                    System.out.print("Anna Hyllypaikka: ");
                    t.setHyllypaikka(in.nextLine());
                    System.out.print("Anna Koodi: ");
                    t.setKoodi(in.nextInt());
                    System.out.print("Anna Koko: ");
                    t.setKoko(in.nextLine());
                    System.out.print("Anna Materiaali: ");
                    t.setMateriaali(in.nextLine());
                    in.nextLine();
                    lista.add(t);

                    if (Objects.equals(t.getTyyppi(), "Kodinkone")) {
                        System.out.print("Anna Nimi: ");
                        t.setNimi(in.nextLine());
                        System.out.print("Anna Hinta: ");
                        t.setHinta(in.nextInt());
                        System.out.print("Anna Hyllypaikka: ");
                        t.setHyllypaikka(in.nextLine());
                        System.out.print("Anna Koodi: ");
                        t.setKoodi(in.nextInt());
                        System.out.print("Anna Takuu: ");
                        t.setTakuu(in.nextInt());
                        System.out.print("Anna Paino: ");
                        t.setPaino(in.nextInt());
                        in.nextLine();
                        lista.add(t);

                        if (Objects.equals(t.getTyyppi(), "0")) {
                            break;
                        }

                    }
                    lista.forEach(System.out::println);
                }
            }
        }
    }
}