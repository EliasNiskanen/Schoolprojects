using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
lue käyttäjältä double arvo ja tulosta se 3 desimaalin tarkkuudella näytölle
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double dluku;

            Console.Write("Anna luku : ");
            dluku = double.Parse(Console.ReadLine());

            Console.WriteLine("Lukusi on {0:f3}", dluku);
        
        }   
        
    }
}