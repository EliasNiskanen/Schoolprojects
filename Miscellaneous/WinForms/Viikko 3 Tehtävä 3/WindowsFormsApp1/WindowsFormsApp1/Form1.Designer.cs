
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHitMe = new System.Windows.Forms.Button();
            this.tmrAjastin = new System.Windows.Forms.Timer(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnStart = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssAika = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssOsumat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssHudit = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrToinenAjastin = new System.Windows.Forms.Timer(this.components);
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHitMe
            // 
            this.btnHitMe.Location = new System.Drawing.Point(300, 208);
            this.btnHitMe.Name = "btnHitMe";
            this.btnHitMe.Size = new System.Drawing.Size(75, 23);
            this.btnHitMe.TabIndex = 0;
            this.btnHitMe.Text = "Lyö!";
            this.btnHitMe.UseVisualStyleBackColor = true;
            this.btnHitMe.Visible = false;
            this.btnHitMe.Click += new System.EventHandler(this.btnHitMe_Click);
            // 
            // tmrAjastin
            // 
            this.tmrAjastin.Interval = 2000;
            this.tmrAjastin.Tick += new System.EventHandler(this.tmrAjastin_Tick);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(460, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnStart
            // 
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(24, 24);
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTime,
            this.toolStripStatusLabel1,
            this.tssAika,
            this.tssOsumat,
            this.tssHudit});
            this.statusStrip.Location = new System.Drawing.Point(0, 290);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(460, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslTime
            // 
            this.tsslTime.Name = "tsslTime";
            this.tsslTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tssAika
            // 
            this.tssAika.Name = "tssAika";
            this.tssAika.Size = new System.Drawing.Size(68, 17);
            this.tssAika.Text = "  Aika : 0,0 s";
            // 
            // tssOsumat
            // 
            this.tssOsumat.Name = "tssOsumat";
            this.tssOsumat.Size = new System.Drawing.Size(64, 17);
            this.tssOsumat.Text = "Osumat : 0";
            // 
            // tssHudit
            // 
            this.tssHudit.Name = "tssHudit";
            this.tssHudit.Size = new System.Drawing.Size(49, 17);
            this.tssHudit.Text = "Hudit: 0";
            // 
            // tmrToinenAjastin
            // 
            this.tmrToinenAjastin.Tick += new System.EventHandler(this.tmrToinenAjastin_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 312);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnHitMe);
            this.Name = "Form1";
            this.Text = "Viikko 3 Tuntitehtävä 6";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHitMe;
        private System.Windows.Forms.Timer tmrAjastin;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnStart;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssAika;
        private System.Windows.Forms.Timer tmrToinenAjastin;
        private System.Windows.Forms.ToolStripStatusLabel tssOsumat;
        private System.Windows.Forms.ToolStripStatusLabel tssHudit;
    }
}

