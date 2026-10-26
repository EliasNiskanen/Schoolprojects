using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 2 KT 3
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double dLuku;

            Console.Write("Syötä lämpötila? ");
            dLuku = double.Parse(Console.ReadLine());
            
            if (dLuku > 39)
            {
                Console.WriteLine("Liian kuuma");

            }
            else if (dLuku <= 39 && dLuku >=11)
            {
                Console.WriteLine("Lämmintä");

            }
            else if (dLuku <= 10 && dLuku >= 0)
            {
                Console.WriteLine("Haaleaa");

            }
            else if (dLuku >= -30 && dLuku <= -1)
            {
                Console.WriteLine("Pakkasta");

            }
            else if (dLuku < -30)
            {
                Console.WriteLine("Liian kylmää");

            }

        }
            
    }
}