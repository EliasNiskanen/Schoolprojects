
namespace Viikko_2_Tehtävä_3
{
    partial class Tehtävä3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.tbPuhnro = new System.Windows.Forms.TextBox();
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPostinro = new System.Windows.Forms.TextBox();
            this.tbLahiosoite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.tbPostitp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.lbHenkilot = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(88, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Syntymäaika";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            this.label3.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbPuhnro
            // 
            this.tbPuhnro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbPuhnro.Location = new System.Drawing.Point(91, 183);
            this.tbPuhnro.Name = "tbPuhnro";
            this.tbPuhnro.Size = new System.Drawing.Size(100, 26);
            this.tbPuhnro.TabIndex = 6;
            this.tbPuhnro.TextChanged += new System.EventHandler(this.tbPuhnro_TextChanged);
            this.tbPuhnro.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbEtunimi.Location = new System.Drawing.Point(92, 79);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 26);
            this.tbEtunimi.TabIndex = 4;
            this.tbEtunimi.TextChanged += new System.EventHandler(this.tbEtunimi_TextChanged);
            this.tbEtunimi.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(88, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Puhelinnumero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(88, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Etunimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbPostinro
            // 
            this.tbPostinro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbPostinro.Location = new System.Drawing.Point(90, 289);
            this.tbPostinro.Name = "tbPostinro";
            this.tbPostinro.Size = new System.Drawing.Size(100, 26);
            this.tbPostinro.TabIndex = 8;
            this.tbPostinro.TextChanged += new System.EventHandler(this.tbPostinro_TextChanged);
            this.tbPostinro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPostinro_KeyPress);
            this.tbPostinro.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbLahiosoite
            // 
            this.tbLahiosoite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbLahiosoite.Location = new System.Drawing.Point(91, 237);
            this.tbLahiosoite.Name = "tbLahiosoite";
            this.tbLahiosoite.Size = new System.Drawing.Size(100, 26);
            this.tbLahiosoite.TabIndex = 7;
            this.tbLahiosoite.TextChanged += new System.EventHandler(this.tbLahiosoite_TextChanged);
            this.tbLahiosoite.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(87, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Postinumero";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(86, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Lähiosoite";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            this.label5.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbSukunimi.Location = new System.Drawing.Point(91, 131);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 26);
            this.tbSukunimi.TabIndex = 5;
            this.tbSukunimi.TextChanged += new System.EventHandler(this.tbSukunimi_TextChanged);
            this.tbSukunimi.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // tbPostitp
            // 
            this.tbPostitp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbPostitp.Location = new System.Drawing.Point(91, 343);
            this.tbPostitp.Name = "tbPostitp";
            this.tbPostitp.Size = new System.Drawing.Size(100, 26);
            this.tbPostitp.TabIndex = 9;
            this.tbPostitp.TextChanged += new System.EventHandler(this.tbPostitp_TextChanged);
            this.tbPostitp.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(88, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sukunimi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            this.label6.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(86, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 34;
            this.label7.Text = "Postitoimipaikka";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            this.label7.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(565, 79);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(257, 83);
            this.btnLisaa.TabIndex = 11;
            this.btnLisaa.Text = "LISÄÄ";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            this.btnLisaa.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // lbHenkilot
            // 
            this.lbHenkilot.FormattingEnabled = true;
            this.lbHenkilot.Location = new System.Drawing.Point(532, 191);
            this.lbHenkilot.Name = "lbHenkilot";
            this.lbHenkilot.Size = new System.Drawing.Size(342, 212);
            this.lbHenkilot.TabIndex = 12;
            this.lbHenkilot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbHenkilot_MouseClick);
            this.lbHenkilot.SelectedIndexChanged += new System.EventHandler(this.lbHenkilot_SelectedIndexChanged);
            this.lbHenkilot.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(92, 430);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.dateTimePicker1.Leave += new System.EventHandler(this.dateTimePicker1_Leave);
            // 
            // Tehtävä3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 690);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbHenkilot);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbPostitp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbPostinro);
            this.Controls.Add(this.tbLahiosoite);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPuhnro);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "Tehtävä3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPuhnro;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPostinro;
        private System.Windows.Forms.TextBox tbLahiosoite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.TextBox tbPostitp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLisaa;
        private System.Windows.Forms.ListBox lbHenkilot;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

