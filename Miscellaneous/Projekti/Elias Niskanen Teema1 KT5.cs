using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 KT5
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double dPii = 3.141593;
            string sSyote;
            double ekaluku;

            Console.Write("Anna ympyran halkaisija : ");
            sSyote = Console.ReadLine();
            ekaluku = double.Parse(sSyote);

            Console.WriteLine("Ympyrän piiri : {0}" , ekaluku * dPii);

            Console.WriteLine("Ympyrän Pinta-ala : {0:F6}", ((dPii * Math.Pow(ekaluku, 2)) / 4));
        }
    }
}