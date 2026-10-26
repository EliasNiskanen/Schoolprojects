using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
/*
H7
Kirjoita ohjelma, joka tulostaa keskelle näyttöä sekä kirjoittaa kolmio.txt-tiedostoon alla olevan kolmion. 

                           O
                          O O
                         O   O
                        O     O
                       O       O
                      O         O
                     O           O
                    O             O
                   O               O
                  O                 O
                 O                   O
                O O O O O O O O O O O O

*/
namespace Projekti
{
    class Program
    {
        static  void Main()
        {
            int i, j;
            StreamWriter sw = new StreamWriter("c:\\temp\\kolmio.txt");
            // juoksee rivejä
            for (i = 1; i <= 12; i++)
            {
                // Tulostetaan alkutyhjät
                for (j = 1; j <= Console.WindowWidth / 2 - i; j++)
                {
                    sw.Write(" ");
                    Console.Write(" ");
                }

                // Ei ekalla kierroksella, koska vain yksi o-kirjain
                if (i > 1)
                {
                    // Eka o-kirjain
                    sw.Write("o");
                    Console.Write("o");

                    // Tulostetaan väliin väli-väli tai väli+o
                    for (j = 1; j <= i - 2; j++)
                    {
                        if (i == 12)
                        {
                            sw.Write(" o");
                            Console.Write(" o");
                        }
                        else
                        {
                            sw.Write("  ");
                            Console.Write("  ");
                        }
                    }
                    sw.Write(" ");
                    Console.Write(" ");
                }
                sw.WriteLine("o");
                Console.WriteLine("o");
            }
            sw.Close();
        }
    }
}
