using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viikko_2_Tehtävä_3
{
    public partial class Tehtävä3 : Form
    {
        public Tehtävä3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbHenkilot_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tbEtunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLisaa_Click(object sender, EventArgs e)
        {
            string henkilostr;
            henkilostr = tbEtunimi.Text + " ";
            henkilostr += tbSukunimi.Text + " ";
            henkilostr += tbPuhnro.Text + " ";
            henkilostr += dateTimePicker1.Value.ToShortDateString() + " ";
            henkilostr += tbLahiosoite.Text + " ";
            henkilostr += tbPostinro.Text + " ";
            henkilostr += tbPostitp.Text;
            lbHenkilot.Items.Add(henkilostr);
        }

        private void tbSukunimi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPostitp_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tbPostinro_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbLahiosoite_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbPuhnro_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbHenkilot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbHenkilot.SelectedIndex != -1)
            {
                string[] purettu = lbHenkilot.Items[lbHenkilot.SelectedIndex].ToString().Split(' ');
                tbEtunimi.Text = purettu[0];
                tbSukunimi.Text = purettu[1];
                tbPuhnro.Text = purettu[2];
                dateTimePicker1.Value = DateTime.Parse(purettu[3]);
                tbLahiosoite.Text = purettu[4];
                tbPostinro.Text = purettu[5];
                tbPostitp.Text = purettu[6];

                lbHenkilot.Items.RemoveAt(lbHenkilot.SelectedIndex);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSyntymaaika_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbPostinro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
