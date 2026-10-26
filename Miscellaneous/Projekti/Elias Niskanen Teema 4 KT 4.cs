using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Teema 4 KT 4
 */
namespace Projekti
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random rand = new Random();
            int[] Lotto = new int[8];


            for (int i = 0; i < Lotto.Length; i++)
            {

                do
                {
                    numero = rand.Next(1, 41);
                }
                while (Lotto.Contains(numero));

                Lotto[i] = numero;


            }

            Array.Sort(Lotto);
            do
            {
                numero = rand.Next(1, 41);
            }
            while (Lotto.Contains(numero));

            Lotto[7] = numero;



            Console.Write("{0} {1} {2} {3} {4} {5} {6} + {7} ", Lotto[0], Lotto[1], Lotto[2], Lotto[3], Lotto[4], Lotto[5], Lotto[6], Lotto[7]);

        }

    }
}