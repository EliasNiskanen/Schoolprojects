using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Käyttöliittymä_projekti_1
{

    class Program
    {
        struct Henkilo
        {
            public string etunimi;
            public string sukunimi;
            public double pituus;
            public double paino;
            public double painoindeksi;
            public double painoindeksit;

        }
        static void LaskePainoindeksi(Henkilo[] henkilot)
        {
            double painoindeksit=0;


            foreach (Henkilo h in henkilot)
            {
                painoindeksit += h.painoindeksi;
            }
            Console.WriteLine("Ka on {0}", painoindeksit / henkilot.Length);

        }

        static void Main(string[] args)
        {   int i;
            Henkilo[] henkilot = new Henkilo[10];

            

            henkilot[0].etunimi = "M.";
            henkilot[0].sukunimi = "Uikku";
            henkilot[0].pituus = 1.60;
            henkilot[0].paino = 80;
            henkilot[0].painoindeksi = henkilot[0].paino / (henkilot[0].pituus * henkilot[0].pituus);

            henkilot[1].etunimi = "H.";
            henkilot[1].sukunimi = "Höylä";
            henkilot[1].pituus = 2.00;
            henkilot[1].paino = 150;
            henkilot[1].painoindeksi = henkilot[1].paino / (henkilot[1].pituus * henkilot[1].pituus);

            henkilot[2].etunimi = "K.";
            henkilot[2].sukunimi = "Ylä";
            henkilot[2].pituus = 1.45;
            henkilot[2].paino = 65;
            henkilot[2].painoindeksi = (henkilot[2].paino / (henkilot[2].pituus * henkilot[2].pituus));


            henkilot[3].etunimi = "A.";
            henkilot[3].sukunimi = "Ura";
            henkilot[3].pituus = 1.75;
            henkilot[3].paino = 80;
            henkilot[3].painoindeksi = henkilot[3].paino / (henkilot[3].pituus * henkilot[3].pituus);

    
            henkilot[4].etunimi = "B.";
            henkilot[4].sukunimi = "Ertta";
            henkilot[4].pituus = 2.20;
            henkilot[4].paino = 140;
            henkilot[4].painoindeksi = henkilot[4].paino / (henkilot[4].pituus * henkilot[4].pituus);

    
            henkilot[5].etunimi = "E.";
            henkilot[5].sukunimi = "Peli";
            henkilot[5].pituus = 1.57;
            henkilot[5].paino = 100;
            henkilot[5].painoindeksi = henkilot[5].paino / (henkilot[5].pituus * henkilot[5].pituus);


            henkilot[6].etunimi = "O.";
            henkilot[6].sukunimi = "Ulu";
            henkilot[6].pituus = 1.65;
            henkilot[6].paino = 60;
            henkilot[6].painoindeksi = henkilot[6].paino / (henkilot[6].pituus * henkilot[6].pituus);

      
            henkilot[7].etunimi = "K.";
            henkilot[7].sukunimi = "Oulu";
            henkilot[7].pituus = 1.95;
            henkilot[7].paino = 95;
            henkilot[7].painoindeksi = henkilot[7].paino / (henkilot[7].pituus * henkilot[7].pituus);

            
            henkilot[8].etunimi = "G.";
            henkilot[8].sukunimi = "Erarth";
            henkilot[8].pituus = 1.75;
            henkilot[8].paino = 91;
            henkilot[8].painoindeksi = henkilot[8].paino / (henkilot[8].pituus * henkilot[8].pituus);

       
            henkilot[9].etunimi = "J.";
            henkilot[9].sukunimi = "Okke";
            henkilot[9].pituus = 1.58;
            henkilot[9].paino = 65;
            henkilot[9].painoindeksi = henkilot[9].paino / (henkilot[9].pituus * henkilot[9].pituus);






            LaskePainoindeksi(henkilot);
        }
    }
}

