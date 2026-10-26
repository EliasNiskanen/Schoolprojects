using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 2 KT 4
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double dLuku1, dLuku2, dVastaus;
            string sMuuttaja;

            Console.Write("Syötä ensimmäinen luku ");
            dLuku1 = float.Parse(Console.ReadLine());

            Console.Write("Syötä toinen luku ");
            dLuku2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Syötä operaation suorittaja(+, -, *, /) ");
            sMuuttaja = Console.ReadLine();

            switch (sMuuttaja)
            {

                case "+":
                    dVastaus = dLuku1 + dLuku2;
                    Console.WriteLine("{0} + {1} = {2}", dLuku1, dLuku2, dVastaus);
                    break;
                case "-":
                    dVastaus = dLuku1 - dLuku2;
                    Console.WriteLine("{0} - {1} = {2}", dLuku1, dLuku2, dVastaus);
                    break;
                case "*":
                    dVastaus = dLuku1 * dLuku2;
                    Console.WriteLine("{0} * {1} = {2}", dLuku1, dLuku2, dVastaus);
                    break;
                case "/":
                    dVastaus = dLuku1 / dLuku2;
                    if (dLuku1 == 0 || dLuku2 == 0)
                        Console.WriteLine("Nollalla ei voida jakaa.");

                    else Console.WriteLine("{0} / {1} = {2}", dLuku1, dLuku2, dVastaus);
                    break;
                default: 
                    Console.WriteLine("Annoit väärän operaation suorittajan.");
                    break;
                
            }
            
        }
                

        
            
    }
}