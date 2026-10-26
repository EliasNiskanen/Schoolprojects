using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
H5
Esittele 10 alkioinen double taulukko ja arvo siihen lukuja väliltä 14.1-27.8. 
Tulosta luvut allekkain yhden desimaalin tarkkuudella
*/
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int i;
            double[] taulu = new double[10];

            for (i = 0; i < taulu.Length; i++)
            {
                // tapa 1 (loppu - alku) + alku
                taulu[i] = rnd.NextDouble() * (27.8 - 14.1) + 14.1;
            }

            for (i = 0; i < taulu.Length; i++)
            {
                Console.WriteLine("{0:f1}", taulu[i]);
            }
        }
    }
}
