using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 2 KT 1
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int iLuku;

            Console.Write("Anna koenumerosi 4-10 väliltä: ");
            iLuku = int.Parse(Console.ReadLine());

                if (iLuku == 4)
                {
                Console.WriteLine("heikko 4");

                }
                else if (iLuku == 5)
                {
                    Console.WriteLine("tyydyttävä 5-6");

                }
                else if (iLuku == 6)
                {
                    Console.WriteLine("tyydyttävä 5-6");

                }
                else if (iLuku == 7)
                {
                    Console.WriteLine("kelpo 7-8");

                }
                else if (iLuku == 8)
                {
                    Console.WriteLine("kelpo 7-8");

                }
                else if (iLuku == 9)
                {
                    Console.WriteLine("hyvä 9-10");
                }
                else if (iLuku == 10) 
                {
                    Console.WriteLine("hyvä 9-10");

                }
                else
                {
                    Console.WriteLine("et antanut arvosanaa annetulta väliltä.");
                }
           

        }   
    }
}