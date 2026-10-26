using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 4 KT 3
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string sSyote;
            String sTmp = "";
            string sIsoiksi, sVaihto, sVali;
            int i;

            Console.WriteLine("Anna merkkejä : ");

            sSyote = Console.ReadLine();

            for (i = sSyote.Length - 1; i >= 0; i--)
            {
                sTmp = sTmp + (" ") + sSyote[i];
            }



                Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", sIsoiksi = sSyote.ToUpper(), sVaihto = sSyote.Replace("A", "!"), sVali = sSyote.Replace(" ", ""), sTmp);



            
        }
                
    }
}