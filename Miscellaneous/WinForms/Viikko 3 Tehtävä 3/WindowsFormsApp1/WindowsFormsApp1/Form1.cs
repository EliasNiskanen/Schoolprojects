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
    public partial class Form1 : Form
    {
        int msec;
        int osumat, hudit;
        Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
        }


        private void LaskeNapinPaikka()
        {
            int x, y;

            if (ClientSize.Width - btnHitMe.Width >= 0)
                x = rnd.Next(0, ClientSize.Width - btnHitMe.Width + 1);
            else
                x = 0;

            if (ClientSize.Height - btnHitMe.Height - statusStrip.Height - toolStrip.Height >= 0)
                y = rnd.Next(0, ClientSize.Height - btnHitMe.Height - statusStrip.Height - toolStrip.Height + 1);
            else
                y = 0;
            btnHitMe.Location = new Point(x, y + toolStrip.Height);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrAjastin.Enabled = true;
            tmrToinenAjastin.Enabled = true;
            tmrAjastin.Interval = 3000;
            msec = 0;
            osumat = hudit = 0;

            LaskeNapinPaikka();
            btnHitMe.Visible = true;
        }

        private void tmrAjastin_Tick(object sender, EventArgs e)
        {
            hudit++;

            if (hudit < 3)
            {
                LaskeNapinPaikka();
            }
            else
            {
                tmrAjastin.Enabled = false;
                tmrToinenAjastin.Enabled = false;
                btnHitMe.Visible = false;

                MessageBox.Show("Peli päättyi! Osumia " + osumat + " kpl");
            }
        }

        private void tmrToinenAjastin_Tick(object sender, EventArgs e)
        {
            msec += tmrToinenAjastin.Interval;
            tssAika.Text = "Aika : " + ((double)msec / 1000).ToString("0.0") + " s";
            tssOsumat.Text = "Osumat : " + osumat;
            tssHudit.Text = "Hudit : " + hudit;
        }

        private void btnHitMe_Click(object sender, EventArgs e)
        {
            osumat++;
            tmrAjastin.Enabled = false;

            tmrAjastin.Interval -= 20;
            if (tmrAjastin.Interval < 50)
            {
                tmrAjastin.Interval = 50;
            }

            LaskeNapinPaikka();

            tmrAjastin.Enabled = true;
        }
    }
}
