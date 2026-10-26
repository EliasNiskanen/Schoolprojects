using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 5 KT 4
 */
namespace Projekti
{


    class Program
    {



         static void Main(string[] args)
         {
            Console.WriteLine("Parametrejä tuli {0}", args.Length);

            while (args.Length >= 0)
            {
                if (args[0] == "opettaja")
                {
                    Console.WriteLine("Koita saada oppilaat oppimaan");
                    break;

                }
                else if (args[0] == "opiskelija")
                {
                    Console.WriteLine("koita opiskella ahkerasti");
                    break;

                }
                else
                {

                    Console.WriteLine("en ymmärrä");
                    break;
                }



            }


         }
            
    }

}
