using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool muuttunut;
        public Form1()
        {
            InitializeComponent();

        }

        private void tbTeksti_TextChanged(object sender, EventArgs e)
        {
            muuttunut = true;

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"c:\temp\teksti.txt");
            tbTeksti.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("c:\\temp\\teksti.txt");
            sw.WriteLine(tbTeksti.Text);
            sw.Close();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

                tbTeksti.Lines = tbTeksti.Lines.Where(line => !line.Contains(toolStripTextBox1.Text)).ToArray();

            //Kyseinen poistaa tällä hetkellä koko linen missä kyseinen esim sana on, muuten toimii oikein!
        }
    }
}
