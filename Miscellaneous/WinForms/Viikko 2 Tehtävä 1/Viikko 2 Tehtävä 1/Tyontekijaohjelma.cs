using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viikko_2_Tehtävä_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar3_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbJohtaja_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbAsiantuntija_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdProjektityöntekijä_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSuunnittelija_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbSukunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEtunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAloituspaiva_Click(object sender, EventArgs e)
        {
            string Aloitus = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            Tyontekijat t1;
            t1.Alotuspaiva = Aloitus;


        }

        private void btnSyntymaaika_Click(object sender, EventArgs e)
        {
            string Syntyma = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            Tyontekijat t1;
            t1.Syntymaaika = Syntyma;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lbTyontekijat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLopetuspaiva_Click(object sender, EventArgs e)
        {
            string Lopetus = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            Tyontekijat t1;
            t1.Lopetuspaiva = Lopetus;
        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Tyontekijat t1;
            t1.Etunimi = tbEtunimi.Text;
            t1.Sukunimi = tbSukunimi.Text;
            string Syntyma = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            t1.Syntymaaika = Syntyma;
            string Aloitus = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            t1.Alotuspaiva = Aloitus;
            string Lopetus = mcAloituspaiva.SelectionRange.Start.ToShortDateString();
            t1.Lopetuspaiva = Lopetus;

            if (rbJohtaja.Checked)
                t1.Titteli = rbJohtaja.Text;
            else if (rbSuunnittelija.Checked)
                t1.Titteli = rbSuunnittelija.Text;
            else if (rbAsiantuntija.Checked)
                t1.Titteli = rbAsiantuntija.Text;
            else
                t1.Titteli = rbProjektityontekija.Text;


            lbTyontekijat.Items.Add(t1.Etunimi + " " + t1.Sukunimi + " " + t1.Syntymaaika + " " + t1.Titteli + " " + t1.Alotuspaiva + " " + t1.Lopetuspaiva);
        
        }
    }
}
