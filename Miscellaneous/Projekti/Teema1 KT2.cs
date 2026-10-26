using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 1 KT 2
 */
namespace Projekti
{
    class Program
    {
        private static void Main()
        {
                string sEtunimi;
                string sSukunimi;
                
            
                Console.Write("Anna etunimi : ");
                sEtunimi = Console.ReadLine();
            
                Console.Write("Anna sukunimi : ");
                sSukunimi = Console.ReadLine();
                
                string sKokonimi = string.Concat(sEtunimi, " ", sSukunimi);

                Console.Clear();

                Console.WriteLine("Nimesi on : {0}", sKokonimi);

         
        }
    }
}