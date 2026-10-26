using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 4 KT 1
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            double[] taulu = new double[3];

            Console.Write("Anna 1 luku : ");
            taulu[0] = double.Parse(Console.ReadLine());
            Console.Write("Anna 2 luku : ");
            taulu[1] = double.Parse(Console.ReadLine());
            Console.Write("Anna 3 luku : ");
            taulu[2] = double.Parse(Console.ReadLine());


            Console.WriteLine("Summa : {0}", taulu[0] + taulu[1] + taulu[2]);
            Console.WriteLine("Keskiarvo : {0}", (taulu[0] + taulu[1] + taulu[2]) / 3);

        }
    }
}