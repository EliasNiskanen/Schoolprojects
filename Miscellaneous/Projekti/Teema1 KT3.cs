using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 KT3
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sSyote;
            string sSyote1;
            int ekaluku, tokaluku;

            Console.Write("Anna ensimmainen luku : ");
            sSyote = Console.ReadLine();
            ekaluku = int.Parse(sSyote);

            Console.Write("Anna toinen luku : ");
            sSyote1 = Console.ReadLine();
            tokaluku = int.Parse(sSyote1);

            Console.WriteLine("Summa : {0} + {1} = {2}" , ekaluku, tokaluku, ekaluku + tokaluku);

            Console.WriteLine("Erotus : {0} - {1} = {2}", ekaluku, tokaluku, ekaluku + tokaluku);

            Console.WriteLine("Tulo : {0} * {1} = {2}", ekaluku, tokaluku, ekaluku + tokaluku);

        }   

    }
}