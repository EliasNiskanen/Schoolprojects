using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 Muuttujat 
 */
namespace Projekti
{ 
    class Program
    {
        static void Main()
        { 
            string sNimi = "Elias Niskanen";
            int iPosNum = 33950;
            int iIka = 28;
            string sLemKir = "E";
            string sLemVar = "Sininen";
            int iPuhNum = 0443073337;
            int iTiliSal = 10000;
            string sHiusHalk = (0,5);

            Console.Write(("Nimi = "(sNimi));("Postinumero = "(iPosNum));("Ika = "(iIka));("Lempikirjain = "(sLemKir));("Lempivari = "(sLemVar));("Puhelinnumero = "(iPuhNum));("Tilinsaldo = "(iTiliSal));("Hiuksen halkaisija = "(sHiusHalk)"mm"));


        }
    }
}
