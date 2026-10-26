using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 Kotitehtävä 1.
 */
namespace Projekti
{ 
    class Program
    {
        static void Main()
        { 
            double dPii = 3.141593;                       //tästä en tiedä kuinka pitkä haluttiin niin merkkasin 6desimaalilla
            string sOsoite = "Partolantie 3 as. 310";
            int iHloTun = 261192;
            int iHloTun2 = 1234;
            string iKirj = "E";
            float fLampo = 1.2F;

            Console.WriteLine("piin likiarvo "+dPii);
            Console.WriteLine("lahiosoite "+sOsoite);
            Console.WriteLine("henkilotunnus "+iHloTun + "-" +iHloTun2); 
            Console.WriteLine("Nimeni ensimmainen kirjain "+iKirj);
            Console.Write("Tamanhetkinen lampotila desimaalin tarkkuudella "+fLampo);
            Console.WriteLine();



        }
    }
}
