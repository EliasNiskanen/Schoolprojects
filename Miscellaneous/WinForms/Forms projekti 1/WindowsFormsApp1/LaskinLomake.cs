using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LaskinLomake : Form
    {
        public List<Henkilo> henkilot = new List<Henkilo>();

        public LaskinLomake()
        {
            InitializeComponent();
        }

        private void LaskinLomake_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Laskin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int Luku1 = int.Parse(tbluku1.Text);
            int Luku2 = int.Parse(tbLuku2.Text);

            int Summa = Luku1 + Luku2;

            tbTulos.Text = Summa.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            Henkilo h1;
            h1.Nimi = tbNimi.Text;
            h1.Ika = (int)nudIka.Value;
            h1.Elakkeella = cbElakkeella.Checked;

            if (rbEronnut.Checked)
                h1.Siviilisaaty = rbEronnut.Text;
            else if (rbLeski.Checked)
                h1.Siviilisaaty = rbLeski.Text;
            else if (rdNaimaton.Checked) 
                h1.Siviilisaaty = rdNaimaton.Text;
            else 
                h1.Siviilisaaty = rbNaimisissa.Text;

            //lbHenkilot.Items.Add(h1.Nimi);
            henkilot.Add(h1);

            lbHenkilot.Items.Clear();

            foreach (var item in henkilot)
            {
                lbHenkilot.Items.Add(item.PalautaTiedot());
            }
        }

        private void btnNaytalista_Click(object sender, EventArgs e)
        {
            FrmHenkilot FrmHenkilot = new FrmHenkilot(this);
            FrmHenkilot.Show();



        }

        private void toolTip9_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
