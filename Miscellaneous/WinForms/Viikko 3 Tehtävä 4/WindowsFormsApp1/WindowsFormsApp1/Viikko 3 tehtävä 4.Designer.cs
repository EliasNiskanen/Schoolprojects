
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbLuku = new System.Windows.Forms.TextBox();
            this.ssStatus = new System.Windows.Forms.StatusStrip();
            this.tsslOk = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbToinenLuku = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ssStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Syötä luku:";
            // 
            // tbLuku
            // 
            this.tbLuku.Location = new System.Drawing.Point(112, 40);
            this.tbLuku.Margin = new System.Windows.Forms.Padding(2);
            this.tbLuku.Name = "tbLuku";
            this.tbLuku.Size = new System.Drawing.Size(242, 20);
            this.tbLuku.TabIndex = 1;
            this.tbLuku.Leave += new System.EventHandler(this.tbLuku_Leave);
            // 
            // ssStatus
            // 
            this.ssStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslOk});
            this.ssStatus.Location = new System.Drawing.Point(0, 123);
            this.ssStatus.Name = "ssStatus";
            this.ssStatus.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.ssStatus.Size = new System.Drawing.Size(362, 22);
            this.ssStatus.TabIndex = 2;
            this.ssStatus.Text = "statusStrip1";
            // 
            // tsslOk
            // 
            this.tsslOk.Name = "tsslOk";
            this.tsslOk.Size = new System.Drawing.Size(22, 17);
            this.tsslOk.Text = "Ok";
            // 
            // tbToinenLuku
            // 
            this.tbToinenLuku.Location = new System.Drawing.Point(112, 70);
            this.tbToinenLuku.Margin = new System.Windows.Forms.Padding(2);
            this.tbToinenLuku.Name = "tbToinenLuku";
            this.tbToinenLuku.Size = new System.Drawing.Size(242, 20);
            this.tbToinenLuku.TabIndex = 4;
            this.tbToinenLuku.Leave += new System.EventHandler(this.tbLuku_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Syötä toinen luku:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 145);
            this.Controls.Add(this.tbToinenLuku);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssStatus);
            this.Controls.Add(this.tbLuku);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Viikko 3 Tehtävä 4";
            this.Load += new System.EventHandler(this.form1_Load);
            this.ssStatus.ResumeLayout(false);
            this.ssStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbToinenLuku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip ssStatus;
        private System.Windows.Forms.ToolStripStatusLabel tsslOk;
        private System.Windows.Forms.TextBox tbLuku;
        private System.Windows.Forms.Label label1;
    }
}

