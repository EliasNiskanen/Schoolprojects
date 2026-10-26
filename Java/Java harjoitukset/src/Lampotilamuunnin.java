//2. Tee ohjelma, joka muuttaa lämpötilan farenheit asteesta celsiuksiksi

import java.util.Scanner;

public class Lampotilamuunnin {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        // Pyydetään arvo celsiuksina
        System.out.print("anna lämpötila celsiuksina: ");
        
        // Luetaan lämpötila
        double Celsius = scanner.nextDouble();

        // Laskee fahrenheitit.
        double Fahrenheit = Celsius * 1.8 + 32;

        // Tulostus
        System.out.println("fahrenheiteina: " + Fahrenheit + " F");

        // Sulje Scanner
        scanner.close();
    }
}
