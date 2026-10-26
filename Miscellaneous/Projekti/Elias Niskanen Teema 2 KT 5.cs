using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 2 KT 5
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double dLuku1, dVastaus, c1, c2;
            float fPii = 3.14159F;
            double dMuuttaja;

            Console.Write("Syötä ympyrän säde ");
            dLuku1 = double.Parse(Console.ReadLine());

            Console.WriteLine("1 = laske ympyrän piiri 2 = laske ympyrän pinta - ala ");
            dMuuttaja = double.Parse(Console.ReadLine());
            
            c1 = dLuku1 * fPii;
           
            c2 = ((fPii * Math.Pow(dLuku1, 2)) / 4);

            dVastaus = (dMuuttaja == 1) ? c1 : c2;


            if (dMuuttaja == 2)
            {
                dVastaus = c2;
                Console.WriteLine("Ympyrän pinta-ala : {0}", dVastaus);
            }

            else if (dMuuttaja == 1)
            {
                dVastaus = (dMuuttaja == 1) ? c1 : c2;

                Console.WriteLine("Ympyrän piiri : {0}", dVastaus);
            }
            else
                Console.WriteLine("Virhe");

        }
            
                 
    }
}