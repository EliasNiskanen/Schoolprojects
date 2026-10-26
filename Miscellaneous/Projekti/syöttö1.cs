using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Esittele lähiosoite ja postitoimipaikka muuttujat. Lue käyttäjältä
arvot näihin muuttujiin ja tulosta seuraavasti

Asut osoitteessa Partolantie joka on paikkakunnalla Pirkkala
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sLahiosoite, sPaikkakunta;
                
            Console.Write("Anna lähiosoitteesi : ");
            sLahiosoite = Console.ReadLine();

            Console.Write("Anna postitoimipaikka : ");
            sPaikkakunta = Console.ReadLine();

            Console.WriteLine("Asut osoitteessa {0} joka on paikkakunnalla {1}", 
                sLahiosoite, sPaikkakunta);
        }
    }
}