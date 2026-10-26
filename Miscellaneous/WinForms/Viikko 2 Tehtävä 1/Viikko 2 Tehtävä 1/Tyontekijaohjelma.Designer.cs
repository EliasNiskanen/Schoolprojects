
namespace Viikko_2_Tehtävä_1
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
            this.tbEtunimi = new System.Windows.Forms.TextBox();
            this.tbSukunimi = new System.Windows.Forms.TextBox();
            this.mcSyntymaaika = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.rbJohtaja = new System.Windows.Forms.RadioButton();
            this.rbAsiantuntija = new System.Windows.Forms.RadioButton();
            this.rbProjektityontekija = new System.Windows.Forms.RadioButton();
            this.rbSuunnittelija = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.mcAloituspaiva = new System.Windows.Forms.MonthCalendar();
            this.mcLopetuspaiva = new System.Windows.Forms.MonthCalendar();
            this.lbTyontekijat = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSyntymaaika = new System.Windows.Forms.Button();
            this.btnAloituspaiva = new System.Windows.Forms.Button();
            this.btnLopetuspaiva = new System.Windows.Forms.Button();
            this.btnLisaa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(74, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etunimi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(75, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sukunimi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbEtunimi
            // 
            this.tbEtunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbEtunimi.Location = new System.Drawing.Point(79, 49);
            this.tbEtunimi.Name = "tbEtunimi";
            this.tbEtunimi.Size = new System.Drawing.Size(100, 26);
            this.tbEtunimi.TabIndex = 2;
            this.tbEtunimi.TextChanged += new System.EventHandler(this.tbEtunimi_TextChanged);
            // 
            // tbSukunimi
            // 
            this.tbSukunimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.tbSukunimi.Location = new System.Drawing.Point(78, 101);
            this.tbSukunimi.Name = "tbSukunimi";
            this.tbSukunimi.Size = new System.Drawing.Size(100, 26);
            this.tbSukunimi.TabIndex = 3;
            this.tbSukunimi.TextChanged += new System.EventHandler(this.tbSukunimi_TextChanged);
            // 
            // mcSyntymaaika
            // 
            this.mcSyntymaaika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mcSyntymaaika.Location = new System.Drawing.Point(78, 156);
            this.mcSyntymaaika.Name = "mcSyntymaaika";
            this.mcSyntymaaika.TabIndex = 4;
            this.mcSyntymaaika.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(74, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Syntymäaika";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbJohtaja
            // 
            this.rbJohtaja.AutoSize = true;
            this.rbJohtaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbJohtaja.Location = new System.Drawing.Point(251, 387);
            this.rbJohtaja.Name = "rbJohtaja";
            this.rbJohtaja.Size = new System.Drawing.Size(81, 24);
            this.rbJohtaja.TabIndex = 14;
            this.rbJohtaja.Text = "Johtaja";
            this.rbJohtaja.UseVisualStyleBackColor = true;
            this.rbJohtaja.CheckedChanged += new System.EventHandler(this.rbJohtaja_CheckedChanged);
            // 
            // rbAsiantuntija
            // 
            this.rbAsiantuntija.AutoSize = true;
            this.rbAsiantuntija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbAsiantuntija.Location = new System.Drawing.Point(251, 350);
            this.rbAsiantuntija.Name = "rbAsiantuntija";
            this.rbAsiantuntija.Size = new System.Drawing.Size(114, 24);
            this.rbAsiantuntija.TabIndex = 13;
            this.rbAsiantuntija.Text = "Asiantuntija";
            this.rbAsiantuntija.UseVisualStyleBackColor = true;
            this.rbAsiantuntija.CheckedChanged += new System.EventHandler(this.rbAsiantuntija_CheckedChanged);
            // 
            // rbProjektityontekija
            // 
            this.rbProjektityontekija.AutoSize = true;
            this.rbProjektityontekija.Checked = true;
            this.rbProjektityontekija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbProjektityontekija.Location = new System.Drawing.Point(78, 350);
            this.rbProjektityontekija.Name = "rbProjektityontekija";
            this.rbProjektityontekija.Size = new System.Drawing.Size(153, 24);
            this.rbProjektityontekija.TabIndex = 12;
            this.rbProjektityontekija.TabStop = true;
            this.rbProjektityontekija.Text = "Projektityöntekijä";
            this.rbProjektityontekija.UseVisualStyleBackColor = true;
            this.rbProjektityontekija.CheckedChanged += new System.EventHandler(this.rdProjektityöntekijä_CheckedChanged);
            // 
            // rbSuunnittelija
            // 
            this.rbSuunnittelija.AutoSize = true;
            this.rbSuunnittelija.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.rbSuunnittelija.Location = new System.Drawing.Point(78, 387);
            this.rbSuunnittelija.Name = "rbSuunnittelija";
            this.rbSuunnittelija.Size = new System.Drawing.Size(118, 24);
            this.rbSuunnittelija.TabIndex = 11;
            this.rbSuunnittelija.Text = "Suunnittelija";
            this.rbSuunnittelija.UseVisualStyleBackColor = true;
            this.rbSuunnittelija.CheckedChanged += new System.EventHandler(this.rbSuunnittelija_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(75, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Työnimike";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(81, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Aloituspäivä";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(81, 623);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lopetuspäivä";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // mcAloituspaiva
            // 
            this.mcAloituspaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mcAloituspaiva.Location = new System.Drawing.Point(85, 443);
            this.mcAloituspaiva.Name = "mcAloituspaiva";
            this.mcAloituspaiva.TabIndex = 18;
            this.mcAloituspaiva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // mcLopetuspaiva
            // 
            this.mcLopetuspaiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.mcLopetuspaiva.Location = new System.Drawing.Point(79, 652);
            this.mcLopetuspaiva.Name = "mcLopetuspaiva";
            this.mcLopetuspaiva.TabIndex = 19;
            this.mcLopetuspaiva.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar3_DateChanged);
            // 
            // lbTyontekijat
            // 
            this.lbTyontekijat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbTyontekijat.FormattingEnabled = true;
            this.lbTyontekijat.ItemHeight = 20;
            this.lbTyontekijat.Location = new System.Drawing.Point(512, 443);
            this.lbTyontekijat.Name = "lbTyontekijat";
            this.lbTyontekijat.Size = new System.Drawing.Size(528, 204);
            this.lbTyontekijat.TabIndex = 20;
            this.lbTyontekijat.SelectedIndexChanged += new System.EventHandler(this.lbTyontekijat_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(508, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Työntekijät";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // btnSyntymaaika
            // 
            this.btnSyntymaaika.Location = new System.Drawing.Point(278, 222);
            this.btnSyntymaaika.Name = "btnSyntymaaika";
            this.btnSyntymaaika.Size = new System.Drawing.Size(75, 23);
            this.btnSyntymaaika.TabIndex = 22;
            this.btnSyntymaaika.Text = "Ota talteen";
            this.btnSyntymaaika.UseVisualStyleBackColor = true;
            this.btnSyntymaaika.Click += new System.EventHandler(this.btnSyntymaaika_Click);
            // 
            // btnAloituspaiva
            // 
            this.btnAloituspaiva.Location = new System.Drawing.Point(275, 517);
            this.btnAloituspaiva.Name = "btnAloituspaiva";
            this.btnAloituspaiva.Size = new System.Drawing.Size(75, 23);
            this.btnAloituspaiva.TabIndex = 23;
            this.btnAloituspaiva.Text = "Ota talteen";
            this.btnAloituspaiva.UseVisualStyleBackColor = true;
            this.btnAloituspaiva.Click += new System.EventHandler(this.btnAloituspaiva_Click);
            // 
            // btnLopetuspaiva
            // 
            this.btnLopetuspaiva.Location = new System.Drawing.Point(269, 731);
            this.btnLopetuspaiva.Name = "btnLopetuspaiva";
            this.btnLopetuspaiva.Size = new System.Drawing.Size(75, 23);
            this.btnLopetuspaiva.TabIndex = 24;
            this.btnLopetuspaiva.Text = "Ota talteen";
            this.btnLopetuspaiva.UseVisualStyleBackColor = true;
            this.btnLopetuspaiva.Click += new System.EventHandler(this.btnLopetuspaiva_Click);
            // 
            // btnLisaa
            // 
            this.btnLisaa.Location = new System.Drawing.Point(674, 352);
            this.btnLisaa.Name = "btnLisaa";
            this.btnLisaa.Size = new System.Drawing.Size(221, 69);
            this.btnLisaa.TabIndex = 25;
            this.btnLisaa.Text = "LISÄÄ";
            this.btnLisaa.UseVisualStyleBackColor = true;
            this.btnLisaa.Click += new System.EventHandler(this.btnLisaa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 840);
            this.Controls.Add(this.btnLisaa);
            this.Controls.Add(this.btnLopetuspaiva);
            this.Controls.Add(this.btnAloituspaiva);
            this.Controls.Add(this.btnSyntymaaika);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbTyontekijat);
            this.Controls.Add(this.mcLopetuspaiva);
            this.Controls.Add(this.mcAloituspaiva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbJohtaja);
            this.Controls.Add(this.rbAsiantuntija);
            this.Controls.Add(this.rbProjektityontekija);
            this.Controls.Add(this.rbSuunnittelija);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mcSyntymaaika);
            this.Controls.Add(this.tbSukunimi);
            this.Controls.Add(this.tbEtunimi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEtunimi;
        private System.Windows.Forms.TextBox tbSukunimi;
        private System.Windows.Forms.MonthCalendar mcSyntymaaika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbJohtaja;
        private System.Windows.Forms.RadioButton rbAsiantuntija;
        private System.Windows.Forms.RadioButton rbProjektityontekija;
        private System.Windows.Forms.RadioButton rbSuunnittelija;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar mcAloituspaiva;
        private System.Windows.Forms.MonthCalendar mcLopetuspaiva;
        private System.Windows.Forms.ListBox lbTyontekijat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSyntymaaika;
        private System.Windows.Forms.Button btnAloituspaiva;
        private System.Windows.Forms.Button btnLopetuspaiva;
        private System.Windows.Forms.Button btnLisaa;
    }
}

