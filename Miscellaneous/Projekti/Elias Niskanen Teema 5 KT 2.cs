using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 5 KT 2
 */
namespace Projekti
{


    class Program
    {



            static void Main()
            {

                int Tulos = Tulosta();


            }
            static int KysyKoko()
            {
                int Koko;
                Console.WriteLine("Minkä kokoinen taulukko luodaan? ");
                Koko = int.Parse(Console.ReadLine());

                return Koko;


            }
            static int[] LuoTaulukko(out int[] sT)
            {  

                sT = new int[KysyKoko()];

                return sT;

            }
            static int[] ArvoArvosanat()
            {

                int[] taulu;
                int Arvosana, i, arvosanat;
                Random rand = new Random();

                LuoTaulukko(out taulu);


                for (i = 0; i < taulu.Length; i++)
                {
                    Arvosana = rand.Next(0, 5);
                    taulu[i] = Arvosana;

                }
                return taulu;


            }
            static int TutkiHylatyt()
            {

                int i, hylatyt = 0;
                int[] Arvosanataulukko;

                Arvosanataulukko = ArvoArvosanat();

                for (i = 0; i < Arvosanataulukko.Length; i++)
                {


                    if (Arvosanataulukko[i] == 0)
                    {
                      
                        hylatyt += 1;

                    }
                   
                }
                return hylatyt;




            }
            static int Tulosta()
            {
                int tulos = TutkiHylatyt();

                Console.WriteLine("{0} sai hylätyn arvosanan.", tulos);


                return tulos;

            }






    }
}
