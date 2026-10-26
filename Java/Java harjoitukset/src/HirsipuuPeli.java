//8. Tee hirsipuupeli, jossa arvotaan ennalta määrätystä sanalistasta sana, josta käyttäjä voi arvata kirjaimia. 12 väärällä arvauksella käyttäjä häviää ja jos käyttäjä arvaa sanan oikein, niin hän voittaa pelin. Toteuta peli siten, että kun peli käynnistetään, niin luodaan olio, jolle voidaan syöttää arvaukset ja olio kertoo oliko vastaus oikein vai väärin ja mihin kohtaan sanaa arvatut kirjaimet sijoittuvat. Toiminnallisuus:
// - Olion pitää pitää kirjaa arvatuista kirjaimista eli jos käyttäjä arvaa uudelleen samaa kirjainta, niin ei tule lisävirheitä
// - Olion pitää pitää sana piilossa ja joka kierroksella näyttää osa arvatusta sanasta
// - käyttäjä voi arvata joko koko sanan tai yksittäisen kirjaimen.

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class HirsipuuPeli {
    private String arvattavaSana;
    private char[] arvattuSana;
    private List<Character> arvatutKirjaimet;
    private int virheidenMaara;

    public HirsipuuPeli(String[] sanalista) {
        // Arvotaan sana sanalistasta
        Random random = new Random();
        arvattavaSana = sanalista[random.nextInt(sanalista.length)].toUpperCase();

        // Alustetaan arvattu sana piilossa alaviivoilla
        arvattuSana = new char[arvattavaSana.length()];
        Arrays.fill(arvattuSana, '_');

        // Alustetaan listaus arvatuista kirjaimista
        arvatutKirjaimet = new ArrayList<>();

        // Alustetaan virheiden määrä
        virheidenMaara = 0;
    }

    public void arvaaKirjain(char arvaus) {
        arvaus = Character.toUpperCase(arvaus);

        // Tarkista onko kirjain jo arvattu
        if (arvatutKirjaimet.contains(arvaus)) {
            System.out.println("Kirjain on jo arvattu. Yritä uudestaan.");
            return;
        }

        // Lisää kirjain arvattuihin kirjaimiin
        arvatutKirjaimet.add(arvaus);

        // Tarkista onko arvattu kirjain osa sanaa
        boolean oikeinArvattu = false;
        for (int i = 0; i < arvattavaSana.length(); i++) {
            if (arvattavaSana.charAt(i) == arvaus) {
                arvattuSana[i] = arvaus;
                oikeinArvattu = true;
            }
        }

        // Jos väärä arvaus, lisää virheiden määrää
        if (!oikeinArvattu) {
            virheidenMaara++;
        }

        // Tulosta pelitilanne
        tulostaPelitilanne();

        // Tarkista voittiko tai hävisikö pelaaja
        tarkistaVoittoTaiHavio();
    }

    public void arvaaSana(String arvaus) {
        arvaus = arvaus.toUpperCase();

        // Tarkista onko koko sana oikein arvattu
        if (arvaus.equals(arvattavaSana)) {
            // Pelaaja voittaa
            System.out.println("Onneksi olkoon! Arvasit sanan oikein: " + arvattavaSana);
        } else {
            // Pelaaja häviää
            virheidenMaara = 12;
            tulostaPelitilanne();
            System.out.println("Valitettavasti hävisit. Oikea sana oli: " + arvattavaSana);
        }
    }

    private void tulostaPelitilanne() {
        System.out.println("Arvattava sana: " + String.valueOf(arvattuSana));
        System.out.println("Arvatut kirjaimet: " + arvatutKirjaimet);
        System.out.println("Virheiden määrä: " + virheidenMaara);
        System.out.println();
    }

    private void tarkistaVoittoTaiHavio() {
        if (Arrays.equals(arvattuSana, arvattavaSana.toCharArray())) {
            // Pelaaja voittaa
            System.out.println("Onneksi olkoon! Arvasit sanan oikein: " + arvattavaSana);
        } else if (virheidenMaara == 12) {
            // Pelaaja häviää
            System.out.println("Valitettavasti hävisit. Oikea sana oli: " + arvattavaSana);
        }
    }

    public static void main(String[] args) {
        String[] sanalista = {"OHJELMOINTI", "JAVA", "HAKKERI", "TIEDOTEKNIIKKA", "OHJELMOIJA"};
        HirsipuuPeli peli = new HirsipuuPeli(sanalista);

        Scanner scanner = new Scanner(System.in);

        while (peli.virheidenMaara < 12 && !Arrays.equals(peli.arvattuSana, peli.arvattavaSana.toCharArray())) {
            System.out.print("Arvaa kirjain tai koko sana: ");
            String arvaus = scanner.nextLine();

            if (arvaus.length() == 1) {
                char kirjain = arvaus.charAt(0);
                peli.arvaaKirjain(kirjain);
            } else {
                peli.arvaaSana(arvaus);
            }
        }

        scanner.close();
    }
}
