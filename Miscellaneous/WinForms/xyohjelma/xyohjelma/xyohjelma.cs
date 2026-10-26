using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xyohjelma
{
    public partial class xyohjelma : Form
    {
        private Button btnVaihda2 = null;

        public xyohjelma()
        {
            InitializeComponent();
        }
        private void tbY_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbX_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnVaihda_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Button btnVaihda2 = new System.Windows.Forms.Button();

            if (btnVaihda == null)
            {
                int l = 0;
                int k = 0;

                Point p1;
                p1.Vaihtox = l;


                if (int.TryParse(tbX.Text, out l) == false)
                {
                    l = 0;
                }
                else
                {
                    l = int.Parse(tbX.Text);
                }
                tbX.Text = l.ToString();

                p1.Vaihtoy = k;
                if (int.TryParse(tbY.Text, out k) == false)
                {
                    k = 0;
                }
                else
                {
                    k = int.Parse(tbY.Text);
                }
                tbY.Text = k.ToString();

                btnVaihda = new Button();


                btnVaihda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
                btnVaihda.Location = new System.Drawing.Point(p1.Vaihtox, p1.Vaihtoy);
                btnVaihda.Name = "btnVaihda2";
                btnVaihda.Size = new System.Drawing.Size(96, 51);
                btnVaihda.TabIndex = 4;
                btnVaihda.Text = "Vaihda";
                btnVaihda.UseVisualStyleBackColor = true;
                btnVaihda.Click += new System.EventHandler(this.btnVaihda_Click);

                this.Controls.Add(btnVaihda);

            }
            else
            {
                Point p1;
                p1.Vaihtox = int.Parse(tbX.Text);
                p1.Vaihtoy = int.Parse(tbY.Text);

                btnVaihda.Location = new System.Drawing.Point(p1.Vaihtox, p1.Vaihtoy);

            }
        }

        private void tbX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if ((!char.IsNumber(ch)) && (!char.IsControl(ch)))
            {
                e.Handled = true;
            }
        }

        private void tbY_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if ((!char.IsNumber(ch)) && (!char.IsControl(ch)))
            {
                e.Handled = true;
            }

            //En saanut ohjelmaa toimimaan täysin niinkuin pitää, ohjelma ei kuitenkaan huomioi tällä hetkellä kuin positiivisia lukuja ja backspacen eli periaatteessa toimii kuten pitää mutta ei osaa muuttaa arvoa 0 arvoksi, jos syötetään väärä arvo. ONko neuvoja?
            //Määritin perusarvoksi kuitenkin 0 kun ohjelma käynnistetään. 

        }
    }
}
