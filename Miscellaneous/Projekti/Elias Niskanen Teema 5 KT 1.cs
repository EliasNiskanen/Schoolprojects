using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 5 KT 1
 */
namespace Projekti
{


    class Program
    {

            static int KysyJaTestaaLuku()
            {

                int x;
                Console.WriteLine("Anna kokonaisluku: ");
                x = int.Parse(Console.ReadLine());

                if (x > 1)
                {
                    return 1;
                }
                if (x == 1)
                {
                    return 1;
                }
                if (x == 0)
                {
                    return 0;
                }
                if (x <= -1)
                {
                    return -1;
                }
                else
                {
                    return 2;
                }


            }

            static void Main()
            {


                int iArvo = KysyJaTestaaLuku();
                







                switch (iArvo)
                {

                    case 1:

                        Console.WriteLine("Luku oli positiivinen");
                        break;
                    case 0:

                        Console.WriteLine("Luku oli nolla");
                        break;
                    case -1:

                        Console.WriteLine("Luku oli negatiivinen");
                        break;

                    default:
                        Console.WriteLine("Annoit jonkun muun kuin kokonaisluvun");
                        break;
                }


            }


    }
}   
