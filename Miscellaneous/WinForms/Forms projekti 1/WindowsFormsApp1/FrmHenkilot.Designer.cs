
namespace WindowsFormsApp1
{
    partial class FrmHenkilot
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
            this.lbHenkilot = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbHenkilot
            // 
            this.lbHenkilot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbHenkilot.FormattingEnabled = true;
            this.lbHenkilot.ItemHeight = 20;
            this.lbHenkilot.Location = new System.Drawing.Point(61, 47);
            this.lbHenkilot.Name = "lbHenkilot";
            this.lbHenkilot.Size = new System.Drawing.Size(648, 544);
            this.lbHenkilot.TabIndex = 0;
            // 
            // FrmHenkilot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 652);
            this.Controls.Add(this.lbHenkilot);
            this.Name = "FrmHenkilot";
            this.Text = "FrmHenkilot";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbHenkilot;
    }
}