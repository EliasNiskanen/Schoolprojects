using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viikko_2_Tehtävä_4
{
    public partial class Form1 : Form
    {
        public struct Laite
        {
            public string nimi;
            public string Nimi
            {
                get { return nimi; }

            }
            public string mitattavaArvo;
            public string MitattavaArvo
            {
                get { return mitattavaArvo; }

            }
            public string toiminnassa;
            public string Toiminnassa
            {
                get { return toiminnassa; }

            }
            public string sijainti;
            public string Sijainti
            {
                get { return sijainti; }

            }
        }

        public List<Laite> laitteet = new List<Laite>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVie_Click(object sender, EventArgs e)
        {
            Laite l;
            l.nimi = tbNimi.Text;
            l.mitattavaArvo = cmbMitattavaarvo.Text;
            l.sijainti = cmbSijaisnti.Text;
            if (cbToiminnassa.Checked)
            {
                l.toiminnassa = "Toiminnassa";
            }
            else
            {
                l.toiminnassa = "Ei toiminnassa";
            }
            laitteet.Add(l);
            dgvLaitteet.DataSource = null;
            dgvLaitteet.DataSource = laitteet;
        }
    }
}
