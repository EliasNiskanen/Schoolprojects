using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Tehtävä 3
 */
namespace Projekti
{
    class Program
    {


        static void Main()
        {
            double Tuki= 0; 
            double Tukipaiva = 32.68;
            double tyole;
            double Tukipuoli;
            int palkka;
            int ylipalkka;
            int lapsimaara;
            string asuu;
            string uudestaan = "k";

            while (uudestaan == "k")
            {
                    Console.Clear();
                    Console.WriteLine("Kuinka monta lasta sinulla on: ");
                    lapsimaara = int.Parse(Console.ReadLine());

                    if (lapsimaara == 1)                                                    // Merkkasin tähän 22 päivää, koska se on keskimääräinen arkipäivien määrä kuukaudessa.
                    {
                        Tuki = (Tukipaiva + 5.27) * 22;

                    }
                    if (lapsimaara == 2)
                    {
                        Tuki = (Tukipaiva + 7.74) * 22;

                    }
                    if (lapsimaara >= 3)
                    {
                        Tuki = (Tukipaiva + 9.98) * 22;

                    }
                    if (lapsimaara == 0)
                    {
                        Tuki = (Tukipaiva * 22);

                    }
                    Console.WriteLine("Kuinka monena päivänä olet osallistunut työllistymistä edistävään palveluun:  ");
                    tyole = int.Parse(Console.ReadLine());

                    if (tyole > 0)
                    {
                        Tuki += (tyole * 4.78);

                    }
                    Console.WriteLine("Kuinka paljon olet saanut palkkaa: ");
                    palkka = int.Parse(Console.ReadLine());

                    if (palkka > 300)
                    {
                        ylipalkka = (palkka - 300) / 2;
                        Tuki -= ylipalkka;

                    }
                    Console.Write("Asutko vanhempiesi luona (k/e): ");
                    asuu = Console.ReadLine();

                    if (asuu == "k" || asuu == "e")
                    {
                        if (asuu == "e")
                        {

                            Console.WriteLine("Saat työmarkkinatukea {0:F2} 0euroa kuukaudessa", Tuki);

                        }
                        if (asuu == "k")
                        {
                            Tukipuoli = Tuki / 2;
                            if (Tukipuoli <= 0)
                            {

                                Console.WriteLine("Saat työmarkkinatukea 0 euroa kuukaudessa");

                            }

                            Console.WriteLine("Saat työmarkkinatukea {0:F2} 0euroa kuukaudessa", Tukipuoli);

                        }
                    }
                    else
                    {
                        Console.WriteLine("virheellinen syöte!");
                    }
                Console.WriteLine("");
                Console.Write("Haluatko laske työmarkkinatuen uusilla tiedoilla (k/e): ");
                uudestaan = Console.ReadLine();
                if (uudestaan == "k" || uudestaan == "e")
                {
                    if (uudestaan == "e")
                    {

                        break;

                    }
                    if (asuu == "k")
                    {
                        Console.Clear();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("virheellinen syöte!");
                }

            }
        }


    }
}
