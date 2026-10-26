using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 3 KT 4
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int i, j, k, l;

            Console.WriteLine("Mistä luvusta lähdetään? ");
            j = int.Parse(Console.ReadLine());

            Console.WriteLine("Mihin lukuun päätetään? ");
            k = int.Parse(Console.ReadLine());

            Console.WriteLine("Mikä askellus? ");
            l = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");


            if (l <= 0)
            {
                Console.WriteLine("Käynnistä ohjelma uudestaan askellus ei voi olla 0.");
                return;
            }
            else;
            {
                for (i = j; i <= k; i += l)
                {

                    Console.WriteLine("{0}", i);



                }
                Console.WriteLine("\nWHILE\n");

                i = j;
                while (i <= k)
                {
                    Console.WriteLine("{0}", i);
                    i += l;

                }
                Console.WriteLine("\nDO-WHILE\n");

                i = j;
                do
                {

                    Console.WriteLine("{0}", i);

                    i += l;

                } while (i <= k);

            }

        }                    
    }
}