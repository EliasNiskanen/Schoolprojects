using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 KT4
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sEtunimi;
            string sSukunimi;
            string sSyote, sSyote1;
            double dPituus;
            double dPaino;
            
            Console.Write("Anna etunimi : ");
            sEtunimi = Console.ReadLine();

            Console.Write("Anna sukunimi : ");
            sSukunimi = Console.ReadLine();

            string sKokonimi = string.Concat(sEtunimi, " ", sSukunimi);

            Console.Write("Anna paino : ");
            sSyote = Console.ReadLine();
            dPaino = double.Parse(sSyote);

            Console.Write("Anna pituus metreina : ");
            sSyote1 = Console.ReadLine();
            dPituus = double.Parse(sSyote1);

            double dBmi = dPaino / dPituus / dPituus;            // Laskutoimituksen pitäisi olla oikea, mutta saan eri tuloksen, kun oppimateriaalissa samoilla arvoilla. 

            Console.Clear();

            Console.WriteLine(sKokonimi+", Pituutesi on "+ dPituus+ "m ja painosi "+ dPaino+ "kg");
            Console.WriteLine("Painoindeksisi on siten {0:f2}", dBmi);

        }   

    }
}