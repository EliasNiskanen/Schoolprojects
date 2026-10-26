//3. Tee ohjelma, joka tarkistaa onko käyttäjältä kysytty vuosi karkausvuosi

import java.util.Scanner;

public class Karkausvuosi {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Anna vuosiluku: ");

        int vuosi = scanner.nextInt();

        boolean onKarkausvuosi = false;

        if ((vuosi % 4 == 0 && vuosi % 100 != 0) || (vuosi % 400 == 0)) {
            onKarkausvuosi = true;
        }

        if (onKarkausvuosi) {
            System.out.println(vuosi + " on karkausvuosi.");
        } else {
            System.out.println(vuosi + " ei ole karkausvuosi.");
        }
        scanner.close();
    }
}
