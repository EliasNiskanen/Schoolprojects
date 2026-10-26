using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Teema 6 KT 4
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            string file = "c:/temp/nimi.txt";
            StreamWriter sw = new StreamWriter(file, true);
            int i, j, k;
            string nimi;


            Console.WriteLine("Anna nimesi: ");
            nimi = Console.ReadLine();


            for (k = nimi.Length - 1; k >= 0; k--)
            {


                for (i = 1; i <= nimi.Length; i++)
                {

                    for (j = 1; j <= Console.WindowWidth / nimi.Length*3 - i; j ++)  //En tekstiä keskelle ruutua, muuten pitäisi olla valmis ohjelma, tuo nimi.Length *3 palautti omaan silmään tyydyttävän,
                                                                                     //arvon niin pitäydyin siinä ja riittää 18 merkkiin asti. 
                    {
                        sw.Write("   ");
                        Console.Write("   ");
                       
                    }

                    sw.WriteLine(nimi[k]);
                    Console.WriteLine(nimi[k]);
                    k--;
            
                }               
            }   
            sw.Close();
        }

    }

}
