using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 3 KT 3
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int ARVATTAVA_LUKU = 257, i=1;


            while (ARVATTAVA_LUKU <= 500 || ARVATTAVA_LUKU >= 1)
            {    
                Console.WriteLine("Arvaa lukua 1-500 väliltä: ");
                ARVATTAVA_LUKU = int.Parse(Console.ReadLine());
            
                    if (ARVATTAVA_LUKU >= 258 && ARVATTAVA_LUKU <=500)
                    {
                    
                    Console.WriteLine("Annoit liian ison luvun\n");

                    }
                
                    if (ARVATTAVA_LUKU <= 256 && ARVATTAVA_LUKU >=1)
                    {
                    
                    Console.WriteLine("Annoit liian pienen luvun\n");

                    }
                    if (ARVATTAVA_LUKU == 257)
                    {
                    
                    Console.WriteLine("Oikein, arvasit luvun {0} kerralla!", i);
                    break;

                    }

                    i++;

                    if (ARVATTAVA_LUKU >500 || ARVATTAVA_LUKU < 1)
                    {
                    
                    Console.WriteLine("luvun piti olla 1-500 väliltä.\n");

                    i--;

                    }
                    
                        
            

            }


        }
                            
    }
}