//4. Tee ohjelma, joka laskee ympyrän pinta-alan

import java.util.Scanner;

public class Ympyränala {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Pyydetään käyttäjää antamaan ympyrän säde
        System.out.print("Anna ympyrän säde: ");
        double sade = scanner.nextDouble();

        // Lasketaan pinta-ala
        double pintaAla = Math.PI * Math.pow(sade, 2);

        // Tulostus
        System.out.println("Ympyrän pinta-ala säteellä " + sade + " on " + pintaAla);

        scanner.close();
    }
}

