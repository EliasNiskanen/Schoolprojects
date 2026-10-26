using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 3 KT 2
 */
namespace Projekti
{
    class Program
    {
        static void Main()
        {
            int i, j;

            for (i = 11, j = 10; i <= 20 && j >= 1; i++, j--)
                Console.WriteLine("{0}\t{1}", i , j );

        }
                            
    }
}