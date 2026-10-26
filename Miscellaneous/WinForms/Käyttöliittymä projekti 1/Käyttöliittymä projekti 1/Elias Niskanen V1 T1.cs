using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttöliittymä_projekti_1
{

    class Program
    {
        struct Keskikulutus
        {
            public double Matka;
            public double Aine;
            public double keskikulutus;

        }
        static void Main(string[] args)
        {

            Keskikulutus keskik;
            keskik.Matka = 0;
            keskik.Aine = 0;
            keskik.keskikulutus = (100 * keskik.Aine / keskik.Matka);
            

            Console.WriteLine("Kuinka pitkä oli matka kilometreinä? ");
            keskik.Matka = double.Parse(Console.ReadLine());

            Console.WriteLine("Kuinka paljon meni polttoainetta litroina? ");
            keskik.Aine = double.Parse(Console.ReadLine());

            keskik.keskikulutus = (100 * keskik.Aine / keskik.Matka);

            Console.WriteLine("Keskikulutuksesi on:{0:f1}l/100km", keskik.keskikulutus);


        }
    }
}

