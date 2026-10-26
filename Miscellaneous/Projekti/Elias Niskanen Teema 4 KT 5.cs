using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 4 KT 5
 */
namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] Taulu = new double[5, 4];
            double maanarvo=0, tiisarvo=0, kesarvo=0, torsarvo=0, perjarvo=0;

            int i, j;



                
                    Console.Write("Anna maanantaille ensimmäinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 0] = double.Parse(Console.ReadLine());
                    Console.Write("Anna maanantaille toinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 1] = double.Parse(Console.ReadLine());
                    Console.Write("Anna maanantaille kolmas mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 2] = double.Parse(Console.ReadLine());
                    Console.Write("Anna maanantaille neljäs mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 3] = double.Parse(Console.ReadLine());

                    
                    maanarvo = ((Taulu[0, 0] + Taulu[0, 1] + Taulu[0, 2] + Taulu[0, 3]) / 4);
                    Console.Clear();
                


                
                    Console.Write("Anna tiistaille ensimmäinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 0] = double.Parse(Console.ReadLine());
                    Console.Write("Anna tiistaille toinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 1] = double.Parse(Console.ReadLine());
                    Console.Write("Anna tiistaille kolmas mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 2] = double.Parse(Console.ReadLine());
                    Console.Write("Anna tiistaille neljäs mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 3] = double.Parse(Console.ReadLine());


                    tiisarvo = ((Taulu[0, 0] + Taulu[0, 1] + Taulu[0, 2] + Taulu[0, 3]) / 4);
                    Console.Clear();
                

           
                
                    Console.Write("Anna keskiviikolle ensimmäinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 0] = double.Parse(Console.ReadLine());
                    Console.Write("Anna keskiviikolle toinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 1] = double.Parse(Console.ReadLine());
                    Console.Write("Anna keskiviikolle kolmas mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 2] = double.Parse(Console.ReadLine());
                    Console.Write("Anna keskiviikolle neljäs mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 3] = double.Parse(Console.ReadLine());


                    kesarvo = ((Taulu[0, 0] + Taulu[0, 1] + Taulu[0, 2] + Taulu[0, 3]) / 4);
                    Console.Clear();
                
               

                    Console.Write("Anna torstaille ensimmäinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 0] = double.Parse(Console.ReadLine());
                    Console.Write("Anna torstaille toinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 1] = double.Parse(Console.ReadLine());
                    Console.Write("Anna torstaille kolmas mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 2] = double.Parse(Console.ReadLine());
                    Console.Write("Anna torstaille neljäs mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 3] = double.Parse(Console.ReadLine());


                    torsarvo = ((Taulu[0, 0] + Taulu[0, 1] + Taulu[0, 2] + Taulu[0, 3]) / 4);
                    Console.Clear();

                    Console.Write("Anna perjantaille ensimmäinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 0] = double.Parse(Console.ReadLine());
                    Console.Write("Anna perjantaille toinen mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 1] = double.Parse(Console.ReadLine());
                    Console.Write("Anna perjantaille kolmas mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 2] = double.Parse(Console.ReadLine());
                    Console.Write("Anna perjantaille neljäs mittaustulos sademäärästä milleinä: ");
                    Taulu[0, 3] = double.Parse(Console.ReadLine());


                    perjarvo = ((Taulu[0, 0] + Taulu[0, 1] + Taulu[0, 2] + Taulu[0, 3]) / 4);
                    Console.Clear();
                
                Console.WriteLine("Maanantai   : {0:F1}mm", maanarvo);
                Console.WriteLine("Tiistai     : {0:F1}mm", tiisarvo);
                Console.WriteLine("Keskiviikko : {0:F1}mm", kesarvo);
                Console.WriteLine("Torstai     : {0:F1}mm", torsarvo);
                Console.WriteLine("Perjantai   : {0:F1}mm", perjarvo);

            
        }
    }
}