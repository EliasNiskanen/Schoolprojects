using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 4 KT 2
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int[] taulu = new int[10];
            int i;
            Random rnd = new Random();
            
           
            for (i = 0; i < taulu.Length; i++)
            {
                taulu[i] = rnd.Next(0,11);
            }

            
                for (i = 0; i < taulu.Length;)
                {
                
                if (taulu[i] == 0 || taulu[i] % 2 == 1)
                {
                    taulu[i] = rnd.Next(0, 11);

                }
                
                if (taulu[i] % 2 == 0 && taulu[i] >0)
                {
                    Console.Write("{0}  ", taulu[i]);
                    i++;
                }

                }   




        }
    } 
}