//5. Tee ohjelma, joka laskee käyttäjältä kysytyiden painon ja pituuden perusteella BMI:n ja antaa sille tulkinnan

import java.util.Scanner;

public class BMI {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        // Pyydetään painoa kiloina
        System.out.print("Anna paino (kg): ");
        double paino = scanner.nextDouble();

        // Pyydetään pituus metreinä
        System.out.print("Anna pituus muodossa (m,cm): ");
        double pituus = scanner.nextDouble();

        // Lasketaan
        double bmi = paino / (pituus * pituus);

        // Tulostus
        System.out.println("BMI: " + bmi);

        // Tulkinta
        if (bmi < 18.5) {
            System.out.println("Alipaino");
        } else if (bmi < 25) {
            System.out.println("Normaali paino");
        } else if (bmi < 30) {
            System.out.println("Lievä ylipaino");
        } else if (bmi < 35) {
            System.out.println("Merkittävä ylipaino");
        } else {
            System.out.println("Vaikea ylipaino");
        }

        scanner.close();
    }
}
