using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 5 KT 3
 */
namespace Projekti
{


    class Program
    {



            static void Main()
            {

                double Tulos = Tulosta();


            }
            static double PITUUSMUUTTUJA;
            static double KysyHypynPituus()
            {
            double jakojaannos, j = 0, puolikas = 0.5;
            int i = 1;



                while (j >= 0)
                {
                    Console.WriteLine("Kuinka pitkä hyppy oli puolen metrin tarkkuudella? ");
                    j = double.Parse(Console.ReadLine());

                    jakojaannos = (double)j % puolikas;


                    if (jakojaannos == 0)
                    {

                        PITUUSMUUTTUJA = j;
                        break;
                        i++;
                    }
                    else if (jakojaannos < 0 || jakojaannos > 0)
                    {
                        Console.WriteLine("Syöte ei ollut 0,5 tarkkuudella. Kokeile uudelleen.");


                    }

                }

                return PITUUSMUUTTUJA;


            }

            static double[] KysyTuomareidenPisteet()
            {

                double jakojaannos, j, puolikas = 0.5;
                int i;

                double[] Taulu = new double[5];


                for (i = 0; i < Taulu.Length; i++)
                {
                    Console.WriteLine("Anna tuomarin antamat tyylipisteet puolen pisteen tarkkuudella: ");
                    Taulu[i] = double.Parse(Console.ReadLine());

                    if (Taulu[i] > 20 || Taulu[i] < 0)
                    {
                        Console.WriteLine("syöte ei ollut annettujen raamien sisällä");
                        i--;

                    }
                    else if (Taulu[i] <= 20 || Taulu[i] >= 0)
                    {

                        jakojaannos = (double)Taulu[i] % puolikas;


                        if (jakojaannos == 0)
                        {


                        }
                        else
                        {
                            Console.WriteLine("Syöte ei ollut 0,5 tarkkuudella. Kokeile uudelleen.");
                            i--;

                        }

                    }






                }
                return Taulu;
            }
            static double LaskeHypynPisteet()
            {

                double Pituus = KysyHypynPituus();
                double [] Pisteet = KysyTuomareidenPisteet();
                double yhteispisteet;
                double KR_PISTE = 90;
                Array.Sort(Pisteet);

                yhteispisteet = ((Pituus - KR_PISTE) * 1.8 + (double)Pisteet[1] + Pisteet[2] + Pisteet[3] + 60);

                return yhteispisteet; 


            }
            static double Tulosta()
            {
                double tulos = LaskeHypynPisteet();
                double Pituus = PITUUSMUUTTUJA;

                Console.WriteLine("Hypyn pituus oli: {0}, ja yhteispisteet: {1}", Pituus, tulos);

                return tulos;

            }






    }
}
