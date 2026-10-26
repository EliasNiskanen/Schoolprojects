import java.util.Scanner;
import java.util.Random;

public class Lotto {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        // Random olio
        Random random = new Random();

        // Arvotaan kaksinumeroinen luku (10-99)
        int arvottuLuku = random.nextInt(90) + 10;

        // Pyydetään käyttäjältä lukua
        System.out.print("Arvaa kaksinumeroinen luku: ");
        int pelaajanArvaus = scanner.nextInt();

        // Erotellaan arvot ja muutetaan arvaus yksittäisiksi numeroiksi
        int arvottuEnsimmäinenNumero = arvottuLuku / 10;
        int arvottuToinenNumero = arvottuLuku % 10;

        int pelaajanEnsimmäinenNumero = pelaajanArvaus / 10;
        int pelaajanToinenNumero = pelaajanArvaus % 10;

        // Tarkistetaan
        if (pelaajanArvaus == arvottuLuku) {
            System.out.println("Onneksi olkoon! Voitit 1000€!");
        } else if ((pelaajanEnsimmäinenNumero == arvottuEnsimmäinenNumero
                || pelaajanEnsimmäinenNumero == arvottuToinenNumero)
                && (pelaajanToinenNumero == arvottuEnsimmäinenNumero
                || pelaajanToinenNumero == arvottuToinenNumero)) {
            System.out.println("Hienoa! Voitit 500€! Numerot olivat oikeat, mutta järjestys väärä.");
        } else if (pelaajanEnsimmäinenNumero == arvottuEnsimmäinenNumero
                || pelaajanEnsimmäinenNumero == arvottuToinenNumero
                || pelaajanToinenNumero == arvottuEnsimmäinenNumero
                || pelaajanToinenNumero == arvottuToinenNumero) {
            System.out.println("Hyvin tehty! Voitit 100€! Yksi numero oli oikein.");
        } else {
            System.out.println("Valitettavasti hävisit. Parempaa onnea ensi kerralla!");
        }

        scanner.close();
    }
}

