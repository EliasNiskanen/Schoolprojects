using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Henkilo> henkilot = new List<Henkilo>();

            Henkilo h1 = new Henkilo("Elias", "Niskanen");
            henkilot.Add(h1);

            Henkilo h2 = new Henkilo("Samu", "Hämäläinen");
            henkilot.Add(h2);

            Henkilo h3 = new Henkilo("Martti", "Laakso");
            henkilot.Add(h3);

            dgvHenkilot.DataSource = henkilot;
        }
    }
}
