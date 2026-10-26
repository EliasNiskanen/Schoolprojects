using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttöliittymä_projekti_1
{

    //Ohjelma jäi vielä kesken mutta varmaan ymmärrät mitä hain takaa? 

    partial class Program
    {   

        public class Autot
        {
            public String merkki;
            public String malli;
            public String tyyppi;
            public String vuosimalli;
            public String rekiserinro;
            public Henkilo omistaja;


            public void Kysytiedot()
            {
                Autot A = new Autot();
                A.merkki = merkki;
                A.malli = malli;
                A.tyyppi = tyyppi;
                A.vuosimalli = vuosimalli;
                A.rekiserinro = rekiserinro;

                Console.WriteLine("Auton merkki? ");
                merkki = Console.ReadLine();

                Console.WriteLine("Auton malli? ");
                malli = Console.ReadLine();

                Console.WriteLine("Auton tyyppi? ");
                tyyppi = Console.ReadLine();

                Console.WriteLine("Auton vuosimalli? ");
                vuosimalli = Console.ReadLine();

                Console.WriteLine("Auton rekisterinumero? ");
                rekiserinro = Console.ReadLine();

            }
        }
        public class Henkilo
        {
            public String etunimi;
            public String sukunimi;
            public String hetu;

            public void Kysytiedot()
            {
                Henkilo h = new Henkilo();
                h.etunimi = etunimi;
                h.sukunimi = sukunimi;
                h.hetu = hetu;

                Console.WriteLine("Etunimesi? ");
                etunimi = Console.ReadLine();

                Console.WriteLine("Sukunimesi? ");
                sukunimi = Console.ReadLine();

                Console.WriteLine("Hetusi? ");
                hetu = Console.ReadLine();

            }
        }
        

        static void Main(string[] args)
        {
            Autot A;

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", A.merkki, A.malli, A.tyyppi, A.vuosimalli, A.rekiserinro, A.omistaja);


        }

    }
}
        
       

    



