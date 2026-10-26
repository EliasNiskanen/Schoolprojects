using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 3 KT 5
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            char cMerkki, cNumero;
            string cMerkkijono="";

            Console.Write("Syötä merkkejä, enter lopettaa : ");

            do
            {
                cMerkki = Console.ReadKey().KeyChar;



                if (char.IsLower(cMerkki) == true && char.IsNumber(cMerkki) == false)
                {
                    cMerkki = char.ToUpper(cMerkki);
                    cMerkkijono += cMerkki;
                }
                else if (char.IsUpper(cMerkki) == true && char.IsNumber(cMerkki) == false)
                {
                    cMerkki = char.ToLower(cMerkki);
                    cMerkkijono += cMerkki;
                }
                    

                

            }while (cMerkki != '\r');
                        
            Console.WriteLine("\n{0}", cMerkkijono);
            
        }
                            
    }
}