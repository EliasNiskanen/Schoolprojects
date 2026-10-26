using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 5 KT 5
 */
namespace Projekti
{


    class Program
    {



        static void Main()
        {

            float[] Tulos = TulostaTiedot();


        }
        static float[] LuoTaulukko(out float[] sT)
        {

            sT = new float[7];

            return sT;

        }
        static float[] KysyArvotTaulukkoon()
        {

            float[] Taulu;
            int fArvo, i;


            LuoTaulukko(out Taulu);


            for (i = 0; i < Taulu.Length; i++)
            {
                do
                {
                    Console.Write("Anna taulukkoon numeraalinen arvo paikkaan {0}: ", i);
                } while (float.TryParse(Console.ReadLine(), out Taulu[i]) != true);

                
            }
            return Taulu;


        }
        static float[] LajitteleTaulukko()
        {



                float[] taulu;

                taulu = KysyArvotTaulukkoon();

                Array.Sort(taulu);

                return taulu;




            
        }

        static float[] TulostaTiedot()
        {

            float[] taulu = LajitteleTaulukko();

            Console.WriteLine("Taulukon minimiarvo oli: {0}, ja maksimi {1}", taulu[0], taulu[6] );

            return taulu;

        }






    }
}
