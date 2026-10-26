
namespace Viikko_2_Tehtävä_4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNimi = new System.Windows.Forms.TextBox();
            this.cmbMitattavaarvo = new System.Windows.Forms.ComboBox();
            this.cbToiminnassa = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSijaisnti = new System.Windows.Forms.ComboBox();
            this.dgvLaitteet = new System.Windows.Forms.DataGridView();
            this.btnVie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaitteet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mitattava arvo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbNimi
            // 
            this.tbNimi.Location = new System.Drawing.Point(153, 49);
            this.tbNimi.Name = "tbNimi";
            this.tbNimi.Size = new System.Drawing.Size(121, 20);
            this.tbNimi.TabIndex = 2;
            this.tbNimi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbMitattavaarvo
            // 
            this.cmbMitattavaarvo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMitattavaarvo.FormattingEnabled = true;
            this.cmbMitattavaarvo.Items.AddRange(new object[] {
            "Lämpötila",
            "Kosteus",
            "PH",
            "Tuulen nopeus"});
            this.cmbMitattavaarvo.Location = new System.Drawing.Point(153, 87);
            this.cmbMitattavaarvo.Name = "cmbMitattavaarvo";
            this.cmbMitattavaarvo.Size = new System.Drawing.Size(121, 21);
            this.cmbMitattavaarvo.TabIndex = 3;
            this.cmbMitattavaarvo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbToiminnassa
            // 
            this.cbToiminnassa.AutoSize = true;
            this.cbToiminnassa.Location = new System.Drawing.Point(153, 138);
            this.cbToiminnassa.Name = "cbToiminnassa";
            this.cbToiminnassa.Size = new System.Drawing.Size(85, 17);
            this.cbToiminnassa.TabIndex = 5;
            this.cbToiminnassa.Text = "Toiminnassa";
            this.cbToiminnassa.UseVisualStyleBackColor = true;
            this.cbToiminnassa.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sijainti";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbSijaisnti
            // 
            this.cmbSijaisnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSijaisnti.FormattingEnabled = true;
            this.cmbSijaisnti.Items.AddRange(new object[] {
            "SIsällä",
            "Ulkona",
            "Ulkona Suojatusti"});
            this.cmbSijaisnti.Location = new System.Drawing.Point(153, 193);
            this.cmbSijaisnti.Name = "cmbSijaisnti";
            this.cmbSijaisnti.Size = new System.Drawing.Size(121, 21);
            this.cmbSijaisnti.TabIndex = 7;
            this.cmbSijaisnti.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // dgvLaitteet
            // 
            this.dgvLaitteet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLaitteet.Location = new System.Drawing.Point(153, 238);
            this.dgvLaitteet.Name = "dgvLaitteet";
            this.dgvLaitteet.Size = new System.Drawing.Size(240, 150);
            this.dgvLaitteet.TabIndex = 8;
            this.dgvLaitteet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnVie
            // 
            this.btnVie.Location = new System.Drawing.Point(455, 119);
            this.btnVie.Name = "btnVie";
            this.btnVie.Size = new System.Drawing.Size(214, 95);
            this.btnVie.TabIndex = 9;
            this.btnVie.Text = "Vie";
            this.btnVie.UseVisualStyleBackColor = true;
            this.btnVie.Click += new System.EventHandler(this.btnVie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVie);
            this.Controls.Add(this.dgvLaitteet);
            this.Controls.Add(this.cmbSijaisnti);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbToiminnassa);
            this.Controls.Add(this.cmbMitattavaarvo);
            this.Controls.Add(this.tbNimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaitteet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNimi;
        private System.Windows.Forms.ComboBox cmbMitattavaarvo;
        private System.Windows.Forms.CheckBox cbToiminnassa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSijaisnti;
        private System.Windows.Forms.DataGridView dgvLaitteet;
        private System.Windows.Forms.Button btnVie;
    }
}

