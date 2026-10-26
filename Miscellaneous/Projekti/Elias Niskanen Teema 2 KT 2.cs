using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 2 KT 2
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int iLuku;

            Console.Write("Monesko kuukausi on meneillään? ");
            iLuku = int.Parse(Console.ReadLine());

            switch(iLuku)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("talvi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("kevät");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("kesä");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("syksy");
                    break;

                default:
                    Console.WriteLine("Annoit väärän arvon.");
                    break;
            }
           

        }   
    }
}