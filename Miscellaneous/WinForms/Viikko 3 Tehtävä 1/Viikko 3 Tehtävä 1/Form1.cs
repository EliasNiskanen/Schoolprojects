using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Viikko_3_Tehtävä_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn.Name == ("btnYksi"))
            {
                TextBox txtLuonti1 = new TextBox();
                txtLuonti1.Leave += txtLuonti1_Leave;
                txtLuonti1.Name = "txtbox1";
                txtLuonti1.Location = new System.Drawing.Point(120, 100);
                txtLuonti1.Size = new System.Drawing.Size(200, 18);
                txtLuonti1.Leave += new EventHandler(txtLuonti1_Leave);
                this.Controls.Add(txtLuonti1);

            }
            else if (btn.Name == ("btnkaksi"))
            {
                TextBox txtLuonti2 = new TextBox();
                txtLuonti2.Leave += txtLuonti2_Leave;
                txtLuonti2.Name = "txtbox2";
                txtLuonti2.Location = new System.Drawing.Point(120, 200);
                txtLuonti2.Size = new System.Drawing.Size(200, 18);
                txtLuonti2.Leave += new EventHandler(txtLuonti2_Leave);
                this.Controls.Add(txtLuonti2);

            }
        }
        private void txtLuonti1_Leave(object sender, EventArgs e)
        {


            System.Windows.Forms.Button btnYksi1 = new System.Windows.Forms.Button();
            TextBox txtLuonti1 = (TextBox)sender;
            
            { 
                btnYksi1 = new Button();


                btnYksi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
                btnYksi1.Location = new System.Drawing.Point(33, 100);
                btnYksi1.Name = "btnYksi";
                btnYksi1.Size = new System.Drawing.Size(75, 23);
                btnYksi1.TabIndex = 4;
                btnYksi1.Text = (txtLuonti1.Text);
                btnYksi1.UseVisualStyleBackColor = true;
                txtLuonti1.Leave += new System.EventHandler(this.txtLuonti1_Leave);


                Controls.Add(btnYksi1);
                btnYksi.Dispose();
            }
        }
        private void txtLuonti2_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button btnkaksi2 = new System.Windows.Forms.Button();
            TextBox txtLuonti2 = (TextBox)sender;
            {

                btnkaksi2 = new Button();


                btnkaksi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
                btnkaksi2.Location = new System.Drawing.Point(33, 200);
                btnkaksi2.Name = "btnkaksi";
                btnkaksi2.Size = new System.Drawing.Size(75, 23);
                btnkaksi2.TabIndex = 4;
                btnkaksi2.Text = (txtLuonti2.Text);
                btnkaksi2.UseVisualStyleBackColor = true;
                txtLuonti2.Leave += new System.EventHandler(txtLuonti2_Leave);


                Controls.Add(btnkaksi2);
                btnkaksi.Dispose();
            }
        }

        private void btnYksi_TextChanged(object sender, EventArgs e)
        {

            
        }
        private void btnkaksi_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void txtLuonti1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLuonti2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
