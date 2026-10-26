using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttöliittymä_projekti_1
{

    class Program
    {
        public struct Pythagora
        {
            public int a;
            public int b;
            public int c;

        }

        static bool RatkaiseYhtälö(int a, int b, int c)
        {
            Pythagora S;
            S.a = a;
            S.b = b;
            S.c = c;

            if(S.a * S.b ==0 && S.c != 0)
            {


                if (S.a == 0)
                {
                    S.a = (int)Math.Sqrt(Math.Pow(S.b, 2) - Math.Pow(S.c, 2));

                    return true;
                }

                if (S.b == 0)
                {
                    S.b = (int)Math.Sqrt(Math.Pow(S.a, 2) - Math.Pow(S.c, 2));

                    return true;
                }
                if (c == 0)
                {
                    S.c = (int)Math.Sqrt(Math.Pow(S.a, 2) + Math.Pow(S.b, 2));

                    return true;
                }
            }

            if (S.a * S.b !=0 && S.c == 0)
            {


                if (S.a == 0)
                {
                    S.a = (int)Math.Sqrt(Math.Pow(S.b, 2) - Math.Pow(S.c, 2));
                    
                    return true;
                }

                if (S.b == 0)
                {
                    S.b = (int)Math.Sqrt(Math.Pow(S.a, 2) - Math.Pow(S.c, 2));

                    return true;
                }
                if (c == 0)
                {
                    S.c = (int)Math.Sqrt(Math.Pow(S.a, 2) + Math.Pow(S.b, 2));

                    return true;
                }

            }

            return false;
            
        }

        public static void Main(String[] args)
        {
            Pythagora Sivu;
            Sivu.a = 2;
            Sivu.b = 0;
            Sivu.c = 0;


            bool tosi = RatkaiseYhtälö(Sivu.a, Sivu.b, Sivu.c);

            Console.WriteLine(tosi);
           

        }
    }
}


