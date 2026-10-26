using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Teema 6 KT 2
 */
namespace Projekti
{
    class Program
    {


        static void Main()
        {
            ArvoJaTallennaTiedostoon();
            double[] Tulos = TulostaTiedot();

        }
        static void ArvoJaTallennaTiedostoon()
        {
            FileInfo tiedosto = new FileInfo("c:/temp/datat.txt");
            string file = "c:/temp/datat.txt";
            StreamWriter sw = new StreamWriter(file);
            int i;
            double numero;
            Random rnd = new Random ();

            if(tiedosto.Exists == false)
            {

                tiedosto.Create();

            }
            for (i = 0; i < 40; i++)
            {
                numero = rnd.NextDouble() * (5.8 - 1.4) + 1.4;
                
                sw.WriteLine("{0:F1}", numero);

            }
            sw.Close();

        }
        static double[] LueTiedostosta()
        {
            StreamReader sr = new StreamReader("c:/temp/datat.txt");
            double[] taulu = new double[40];
            int i;

            while (sr.EndOfStream == false)
            {
                for (i = 0; i < taulu.Length; i++)
                {
                    taulu[i] = double.Parse(sr.ReadLine());

                }

            }
            sr.Close();
            return taulu;
        }
        static double[] TulostaTiedot()
        {
            double[] taulu = LueTiedostosta();
            double summa = taulu.Sum();
            double keskiarvo = summa / taulu.Length;





            Array.Sort(taulu);
            Console.WriteLine("summa = {0:F1}", summa);
            Console.WriteLine("keskiarvo = {0:F1}", keskiarvo);
            Console.WriteLine("min = {0:F1}", taulu[0]);
            Console.WriteLine("max = {0:F1}", taulu[39]);

            return taulu;
        }


    }
}
