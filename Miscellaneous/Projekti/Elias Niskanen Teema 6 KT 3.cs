using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Teema 6 KT 3
 */
namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] taulu = new string[args.Length];
            int i, j;

            if (args.Length == 0)
            {
                Console.WriteLine("Virhe!");

            }
            if (args.Length > 0)
            {
                for (i = 0; i < args.Length; i++)
                {
                    taulu[i] = args[i];
                    Tallenna(taulu[i]);
                }
                LueJaTulosta();
            }
          
            


        }
        static void Tallenna(string arvo)
        {
            FileInfo tiedosto = new FileInfo("c:/temp/parametrit.txt");
            string file = "c:/temp/parametrit.txt";
            StreamWriter sw = new StreamWriter(file, true);
            int i;



            if (tiedosto.Exists == false)
            {
                tiedosto.Create();
            }
                
            sw.WriteLine(arvo);
            
            sw.Close();

        }
        static void LueJaTulosta()
        {
            FileInfo tiedosto = new FileInfo("c:/temp/parametrit.txt");
            StreamReader sr = new StreamReader("c:/temp/parametrit.txt");
            string teksti;


            while (sr.EndOfStream == false)
            {
                    teksti = sr.ReadLine();
                    Console.WriteLine(teksti);

            }
            sr.Close();

        }

        


    }

}
