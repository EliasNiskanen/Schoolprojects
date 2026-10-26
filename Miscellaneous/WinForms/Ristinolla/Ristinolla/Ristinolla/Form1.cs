using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace Ristinolla
{
    public partial class Form1 : Form
    {
        bool vuoro = true;  // true on X vuoro, False on O vuoro.
        public bool AI = false; // Onko tekoäly päällä.
        bool VoittajaOn = false; // Onko voittajaa löydetty?
        int Vuorot = 0; // Vuorolaskuri.
        static String pelaaja1, pelaaja2; // Pelaajanimet toiselta formilta.

        public Form1()
        {
            InitializeComponent();
        }

        public static void Pelaajanimet(String p1, String p2)
        {
            pelaaja1 = p1;
            pelaaja2 = p2;


        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lopetaToolStripMenuItem_Click(object sender, EventArgs e)  // Lopettaa aplikaation.
        {
            Application.Exit();
        }

        private void ohjeetToolStripMenuItem_Click(object sender, EventArgs e)  // Ohjeita Ristinollaan yleisesti.
        {
            MessageBox.Show("Ristinolla on kahden pelaajan peli, josta on kaksi päävariaatiota. Alkeellisimmassa versiossa on 3 x 3 ruudun pelilauta, johon kumpikin pelaajan vuoron perään piirtää oman merkkinsä, joko ristin tai ympyrän.Tavoitteena on saada kolme omaa merkkiä samalle pysty -, vaaka - tai vinoriville.Peli päättyy aina tasapeliin ellei toinen tee virhettä.", "Ristinolla Säännöt");
        }

        private void button_Click(object sender, EventArgs e)   // Mitä tapahtuu kun klikataan.
        {
            
            if (AI==true)
            {
                pelaaja2 = "Tietokone";
            }
            Button b = (Button)sender;
            if (vuoro)
            {
                b.Text = "X";
                label1.Text = pelaaja2 + " on sinun vuorosi.";
            }
            else
                b.Text = "O";
                label1.Text = pelaaja1 + " on sinun vuorosi.";

            vuoro = !vuoro;
            b.Enabled = false;
            Vuorot++;
            TarkistetaanVoittaja();

            if ((!vuoro) && (AI == true))
            {

                TietokoneSiirto();

            }
        }

        public void TietokoneSiirto()
        {
            label1.Text = "On Tietokoneen vuoro";
            Random Aika = new Random();           
            int Ajastin = Aika.Next(500, 2000);
            Thread.Sleep(Ajastin);

            if (AI == true)
            {
                Button Liiku = null;

                Liiku = BlokkaaTaiVoita("0");
                if (Liiku == null)
                {
                    Liiku = BlokkaaTaiVoita("X");
                    if (Liiku == null)
                    {
                        Liiku = EtsiPaikkaa();
                    }
                }
                  if(Vuorot == 9)
                  {
                    SuljeNapit();

                  }
                  else
                       Liiku.PerformClick();
                    
            }       
        } // Mitä tietokone tekee kun siltä odotetaan siirtoa.

        private Button BlokkaaTaiVoita(string merkki)
        {
            if ((buttonA1.Text == merkki) && (buttonA2.Text == merkki) && (buttonA3.Text == ""))
                return buttonA3;
            if ((buttonA1.Text == "") && (buttonA2.Text == merkki) && (buttonA3.Text == merkki))
                return buttonA1;
            if ((buttonA1.Text == merkki) && (buttonA2.Text == "") && (buttonA3.Text == merkki))
                return buttonA2;
            if ((buttonB1.Text == merkki) && (buttonB2.Text == merkki) && (buttonB3.Text == ""))
                return buttonB3;
            if ((buttonB1.Text == "") && (buttonB2.Text == merkki) && (buttonB3.Text == merkki))
                return buttonB1;
            if ((buttonB1.Text == merkki) && (buttonB2.Text == "") && (buttonB3.Text == merkki))
                return buttonB2;
            if ((buttonC1.Text == merkki) && (buttonC2.Text == merkki) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonC1.Text == "") && (buttonC2.Text == merkki) && (buttonC3.Text == merkki))
                return buttonC1;
            if ((buttonC1.Text == merkki) && (buttonC2.Text == "") && (buttonC3.Text == merkki))
                return buttonC2;

            if ((buttonA1.Text == merkki) && (buttonB1.Text == merkki) && (buttonC1.Text == ""))
                return buttonC1;
            if ((buttonA1.Text == merkki) && (buttonB1.Text == "") && (buttonC1.Text == merkki))
                return buttonB1;
            if ((buttonA1.Text == "") && (buttonB1.Text == merkki) && (buttonC1.Text == merkki))
                return buttonA1;
            if ((buttonA2.Text == merkki) && (buttonB2.Text == merkki) && (buttonC2.Text == ""))
                return buttonC2;
            if ((buttonA2.Text == merkki) && (buttonB2.Text == "") && (buttonC2.Text == merkki))
                return buttonB2;
            if ((buttonA2.Text == "") && (buttonB2.Text == merkki) && (buttonC2.Text == merkki))
                return buttonA2;
            if ((buttonA3.Text == merkki) && (buttonB3.Text == merkki) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonA3.Text == merkki) && (buttonB3.Text == "") && (buttonC3.Text == merkki))
                return buttonB3;
            if ((buttonA3.Text == "") && (buttonB3.Text == merkki) && (buttonC3.Text == merkki))
                return buttonA3;

            if ((buttonA1.Text == merkki) && (buttonB2.Text == merkki) && (buttonC3.Text == ""))
                return buttonC3;
            if ((buttonA1.Text == merkki) && (buttonB2.Text == "") && (buttonC3.Text == merkki))
                return buttonB2;
            if ((buttonA1.Text == "") && (buttonB2.Text == merkki) && (buttonC3.Text == merkki))
                return buttonA1;
            if ((buttonC1.Text == "") && (buttonB2.Text == merkki) && (buttonA3.Text == merkki))
                return buttonC1;
            if ((buttonC1.Text == merkki) && (buttonB2.Text == "") && (buttonA3.Text == merkki))
                return buttonB2;
            if ((buttonC1.Text == merkki) && (buttonB2.Text == merkki) && (buttonA3.Text == ""))
                return buttonA3;

            return null;
        }   // Pienimuotoinen tekoäly tietokonepelaajalle.

        private Button EtsiPaikkaa()
        {
            Button b = null;
            foreach (Control c in Controls)
            {
                b = c as Button;
                if(b != null)
                {
                    if (b.Text == "")
                        return b;
                }

            }
            return null;
        }   // Tähän mennään jos blokkaa ja voita ei tuottanut tulosta.

        private void TarkistetaanVoittaja() // Tässä tarkistetaan voittajat joka kierroksen jälkeen.
        {
            Käyttäjätiedot k = new Käyttäjätiedot();

            if ((buttonA1.Text == buttonA2.Text) && (buttonA2.Text == buttonA3.Text) && (!buttonA1.Enabled))
                VoittajaOn = true;
            else if ((buttonB1.Text == buttonB2.Text) && (buttonB2.Text == buttonB3.Text) && (!buttonB1.Enabled))
                VoittajaOn = true;
            else if ((buttonC1.Text == buttonC2.Text) && (buttonC2.Text == buttonC3.Text) && (!buttonC1.Enabled))
                VoittajaOn = true;

            else if ((buttonA1.Text == buttonB1.Text) && (buttonB1.Text == buttonC1.Text) && (!buttonA1.Enabled))
                VoittajaOn = true;
            else if ((buttonA2.Text == buttonB2.Text) && (buttonB2.Text == buttonC2.Text) && (!buttonA2.Enabled))
                VoittajaOn = true;
            else if ((buttonA3.Text == buttonB3.Text) && (buttonB3.Text == buttonC3.Text) && (!buttonA3.Enabled))
                VoittajaOn = true;

            else if ((buttonA1.Text == buttonB2.Text) && (buttonB2.Text == buttonC3.Text) && (!buttonA1.Enabled))
                VoittajaOn = true;
            else if ((buttonC1.Text == buttonB2.Text) && (buttonB2.Text == buttonA3.Text) && (!buttonC1.Enabled))
                VoittajaOn = true;

            if(VoittajaOn)
            {
                SuljeNapit();

                String voittaja = "";
                if (vuoro)
                    if (AI == true)
                    {

                        voittaja = "Tietokone";
                        k.voitot = +1;
                    }
                    else
                        voittaja = pelaaja2;

                else
                        voittaja = pelaaja1;


                MessageBox.Show(voittaja + " Voitti pelin!", "Lopputulos");
               

            }
            else
            {
                if(Vuorot == 9 || VoittajaOn)
                    MessageBox.Show("Tasapeli!", "Lopputulos");
            }
        }

        private void SuljeNapit() // Tällä suljetaan napit kun peli on päättynyt. 
        {
            try 
            { 
                    foreach (Control c in Controls)
                    {
                        try
                        { 
                            Button b = (Button)c;
                            b.Enabled = false;
                        }
                        catch { }
                    }
            }
            catch { }
        }

        private void yksinpeliToolStripMenuItem_Click(object sender, EventArgs e) // Tällä pääsee haastamaan tietokonetta pelissä.
        {
            
            vuoro = true;
            Vuorot = 0;
            AI = true;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }

        } 

        private void kaksinpeliToolStripMenuItem_Click(object sender, EventArgs e) // Tällä pääsee pelaamaan kahdestaan.
        {
            AI = false;
            vuoro = true;
            Vuorot = 0;

            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }

        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            
            if(vuoro)

                if (AI == true)
                {
                    label1.Text = "On tietokoneen vuoro";
                }
                else
                    label1.Text = pelaaja2 + " on sinun vuorosi.";

            if (!vuoro)
                label1.Text = pelaaja1 + " on sinun vuorosi.";
        } // Ilmoittaa kenen vuoro on seuraavaksi.

        private void Form1_Load(object sender, EventArgs e)
        {

            Pelaajat f2 = new Pelaajat();
            f2.ShowDialog();


        } // Tällä otetaan tieto Pelaajatieto lomakkeelta.
    }

}
