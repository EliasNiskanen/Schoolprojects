using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Tehtävä 2
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sSyote;
            int i;
            string sPieni;


            Console.WriteLine("Anna merkkejä : ");
            sSyote = Console.ReadLine();



            for (i = 0; i< sSyote.Length; i++)
            {
                sPieni = sSyote.ToLower();
                Console.WriteLine("{0}", sPieni[i]);
                i++;

            }

        }

    }
}