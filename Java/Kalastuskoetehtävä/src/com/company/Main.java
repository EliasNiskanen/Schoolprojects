package com.company;
/*Kuopion kalakerholla on ollut kovin kankea sovellus, 
jossa järjestelmään on syötetty kalastajien hauki- ja kuhasaaliit vuoden lopussa erilaisista lippusista ja lappusista. 
Se on näyttänyt jotakuinkin seuraavalta

Anna kalastajan jäsennumero (0 = Lopettaa syötön): 12
Anna kalastajan etunimi: Antti Ahven
Anna kalastajan pääasiallinen kalastusalue: Kallavesi
Anna kalastajan haukisaalis (yht kg): 123
Anna kalastajan kuhasaalis (yht kg): 22
Anna kalastajan suurin hauki (kg): 6.5
Anna kalastajan suurin kuha(kg): 1.4
Anna kalastajan jäsennumero (0 = Lopettaa syötön): 11
Anna kalastajan etunimi: Mikko Muikku
Anna kalastajan pääasiallinen kalastusalue: Suvasvesi
Anna kalastajan haukisaalis (yht kg): 13.4
Anna kalastajan kuhasaalis (yht kg): 55.6
Anna kalastajan suurin hauki (kg): 1.5
Anna kalastajan suurin kuha(kg): 4.5
Anna kalastajan jäsennumero (0 = Lopettaa syötön): 0

Kalastajat:
    Antti Ahven, 12, Kallavesi, saalis: hauki: yht 123 kg, suurin 6.5, kuha: yht 22, suurin 1.4
    Mikko Muikku, 11, Suvasvesi, saalis: hauki: yht 13.4 kg, suurin 1.5, kuha: yht 55, suurin 4.5

1. vaihe :Tee Java-ohjelma, jossa on sama toiminnallisuus. Käytä luokkia ja sopivia tietorakenteita ja koodaa pääohjelma. 
Huolehdi luokan (luokkien) perusmetodien koodauksesta. Syötteiden järkevyys- ja tyyppitarkistuksia ei tarvitse toteuttaa. (luokka/luokat 3p, pääohjelma 2 p)

2. vaihe. Tee erillinen luokka (esim KalatilastoUtils), jossa kaksi  static -tyyppistä metodia 

- palautaKalastajat (param1, param2). Metodi palauttaa sopivassa tietorakenteessa kaikki parametrina annetun kalastusalueen kalastajat  
Testaa toiminta pääohjelmassa. Yllä olevassa  esimerkkikäyttöliittymässä ei ole esitetty sitä, miten testaat ko metodin toimintaa. 
Param1 on kalastusalueen nimi merkkijonona, jota etsitään, Param2 sisältää kaikki tilastoidut kalastajat. (1 p)

- saalisYht (param). Metodi palauttaa kaikkien kalastajien kauden kalasaaliin (hauet + kuhat) kiloina yhteensä (double).  
Testaa toiminta pääohjelmassa. Yllä olevassa  esimerkkikäyttöliittymässä ei ole esitetty sitä, miten testaat ko metodin toimintaa.  
Param sisältää kaikki kalastajat. (1 p)

Arviointi:  Yht 7p
 */

import java.util.ArrayList;
import java.util.Objects;
import java.util.Scanner;

public class Main {

    private static ArrayList<Kalastaja> Alue;

    public static void main(String[] args) {
        ArrayList<Kalastaja> lista = new ArrayList<>();
        Scanner in = new Scanner(System.in);
        while (true){
            Kalastaja k = new Kalastaja();
            System.out.print("Anna kalastajan jäsennumero (0 = Lopettaa syötön): ");
            k.setKn(in.nextLine());
            if (Objects.equals(k.getKn(), "0")) {break;}
            System.out.print("Anna kalastajan etunimi: ");
            k.setEnimi(in.nextLine());
            System.out.print("Anna kalastajan Sukunimi: ");
            k.setSnimi(in.nextLine());
            System.out.print("Anna kalastajan pääasiallinen kalastusalue: ");
            k.setAlue(in.nextLine());
            System.out.print("Anna kalastajan haukisaalis (yht kg): ");
            k.setHaukiSaalis(in.nextInt());
            System.out.print("Anna kalastajan suurin hauki (kg): ");
            k.setSuurinHauki(in.nextInt());
            System.out.print("Anna kalastajan Kuhasaalis (yht kg): ");
            k.setKuhaSaalis(in.nextInt());
            System.out.print("Anna kalastajan suurin Kuha (kg): ");
            k.setSuurinKuha(in.nextInt());
            in.nextLine();
            lista.add(k);

        }
        System.out.println("Kalastajat: ");
        lista.forEach(System.out::println);

        System.out.println("Kalasaalis yhteensä: " + KalatilastoUtils.saalisYht(lista));

        System.out.println("Minkä alueen kalastajat haluaisit?: ");
        Alue = KalatilastoUtils.palautaKalastajat(in.nextLine(), lista);
        Alue.forEach(System.out::println);


        
    }
}
