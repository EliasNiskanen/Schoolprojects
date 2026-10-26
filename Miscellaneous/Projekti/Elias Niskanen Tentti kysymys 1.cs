using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tehtävä 1
 */
namespace Projekti
{


    class Program
    {


        static void Main()
        {
            double iluku1 = LueArvot();
            double iLuku2 = LueArvot();
            double osamaara = (iluku1 / iLuku2);

            Console.WriteLine("{0:F2}", osamaara);

        }
        static double LueArvot()
        {
            double iArvo;

            Console.WriteLine("Anna luku kahden desimaalin tarkkuudella: ");
            iArvo = double.Parse(Console.ReadLine());
            return iArvo;

        }
    }
}   

 

   







