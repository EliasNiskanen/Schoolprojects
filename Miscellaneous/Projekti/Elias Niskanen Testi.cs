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
                double jakojaannos, j=0, puolikas = 0.5;
                double Pituus=0;
                int i=1;


                
                    while (j >= 0)
                    {
                            Console.WriteLine("Kuinka pitkä hyppy oli puolen metrin tarkkuudella? ");
                            j = double.Parse(Console.ReadLine());

                                    jakojaannos = (double)j % puolikas;


                                        if (jakojaannos == 0)
                                        {

                                            Pituus = j;
                                            break;
                                            i++;
                                        }
                                        else if (jakojaannos <0 || jakojaannos >0)
                                        {
                                            Console.WriteLine("Syöte ei ollut 0,5 tarkkuudella. Kokeile uudelleen.");

                            
                                        }

                    }

                    Console.WriteLine(Pituus);


            }
            
    }
}
