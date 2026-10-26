//1. Tee ohjelma, joka laskee käyttäjältä kysytylle hinnalle arvonlisäveron

import java.util.Scanner;

public class ArvonlisaveronLaskuri {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Pyydetään hinta
        System.out.print("Anna hinta ilman arvonlisäveroa: ");
        
        // Luetaan hinta
        double hintaIlmanALV = scanner.nextDouble();

        // Laskee ALV:n
        double arvonlisavero = hintaIlmanALV * 0.24;
        double kokonaishinta = hintaIlmanALV + arvonlisavero;

        // Tulostus
        System.out.println("Arvonlisävero (24 %): " + arvonlisavero + " euroa");
        System.out.println("Kokonaishinta (sis. ALV): " + kokonaishinta + " euroa");

        // Sulje Scanner
        scanner.close();
    }
}
