using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele kaksi int muuttujaa ja lue niihin käyttäjältä arvot jotenkin. 


Tulosta lopuksi lukujen summa. 
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

            Console.WriteLine("Lukujen summa : {0}" , ekaluku + tokaluku);

            Console.WriteLine("Lukujen summa : " + (ekaluku * tokaluku));
        }
    }
}