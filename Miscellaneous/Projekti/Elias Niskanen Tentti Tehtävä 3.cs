using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Tehtävä 3
 */
namespace Projekti
{
    class Program
    {


        static void Main()
        {
            TallennaTiedostoon();
            int[] luvut = LueLuvutJaTulostaParittomat(); 

        }
        static int[] ArvoTaulukkoon()
        {

            int[] Taulu = new int[104];
            int i;
            Random rnd = new Random ();


            for (i = 0; i < Taulu.Length; i++)
            {
                Taulu[i] = rnd.Next(9,29);
                
            }
            return Taulu;

        }
        static int TallennaTiedostoon()
        {
            int[] taulu = ArvoTaulukkoon();
            FileInfo tiedosto = new FileInfo("c:/temp/numerot.txt");
            string file = "c:/temp/numerot.txt";
            StreamWriter sw = new StreamWriter(file, true);
            int i;



            if (tiedosto.Exists == false)
            {
                tiedosto.Create();
            }
            for (i = 0; i < taulu.Length; i++)
            {
                sw.WriteLine(taulu[i]);
            }
            sw.Close();
            return i;

        }
        static int[] LueLuvutJaTulostaParittomat()
        {
            StreamReader sr = new StreamReader("c:/temp/numerot.txt");
            int[] taulu = new int[104];
            int i, jakojaannos;

            while (sr.EndOfStream == false)
            {
                for (i = 0; i < taulu.Length; i++)
                {
                    taulu[i] = int.Parse(sr.ReadLine());


                        jakojaannos = (int)taulu[i] % 2;
                        
                        if (jakojaannos != 0)
                        {
                            Console.WriteLine(taulu[i]);
                        }


                    
                }

            }
            sr.Close();


            return taulu;

        }


    }
}
