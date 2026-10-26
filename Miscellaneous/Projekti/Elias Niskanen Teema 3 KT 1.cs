using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 3 KT 1
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int i = 1, iLuku = 0, iSumma = 0;


            while (iLuku != -1)
            {
                Console.WriteLine("Anna {0} luku: ", i);
                iLuku = int.Parse(Console.ReadLine());
                if (iLuku == -1)
                {
                    Console.WriteLine("Antamiesi lukujen keskiarvo: {0}", (iSumma/(i-1)));
                }
                iSumma += iLuku;
                i++;
            }


        }
                            
    }
}