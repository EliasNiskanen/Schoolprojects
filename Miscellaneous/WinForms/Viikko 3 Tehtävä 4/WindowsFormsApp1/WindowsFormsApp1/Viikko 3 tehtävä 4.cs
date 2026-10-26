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
        public Form1()
        {
            InitializeComponent();
        }
        private void tbLuku_Leave(object sender, EventArgs e)
        {
            int l;

            TextBox tb = (TextBox)sender;

            try
            {
                l = int.Parse(tb.Text);
                tsslOk.Text = "Ok";
            }
            catch (Exception ex)
            {
                tsslOk.Text = "Virhe syötteessä " + ex.Message;
                tb.Focus();
            }

        }

        private void form1_Load(object sender, EventArgs e)
        {

        }
    }
}
