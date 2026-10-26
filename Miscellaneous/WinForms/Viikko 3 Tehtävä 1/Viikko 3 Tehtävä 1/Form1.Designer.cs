
namespace Viikko_3_Tehtävä_1
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
            this.btnYksi = new System.Windows.Forms.Button();
            this.btnkaksi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnYksi
            // 
            this.btnYksi.Location = new System.Drawing.Point(33, 100);
            this.btnYksi.Name = "btnYksi";
            this.btnYksi.Size = new System.Drawing.Size(75, 23);
            this.btnYksi.TabIndex = 0;
            this.btnYksi.Text = "Paina";
            this.btnYksi.UseVisualStyleBackColor = true;
            this.btnYksi.TextChanged += new System.EventHandler(this.btnYksi_TextChanged);
            this.btnYksi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnkaksi
            // 
            this.btnkaksi.Location = new System.Drawing.Point(33, 200);
            this.btnkaksi.Name = "btnkaksi";
            this.btnkaksi.Size = new System.Drawing.Size(75, 23);
            this.btnkaksi.TabIndex = 1;
            this.btnkaksi.Text = "Paina";
            this.btnkaksi.UseVisualStyleBackColor = true;
            this.btnkaksi.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnkaksi);
            this.Controls.Add(this.btnYksi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYksi;
        private System.Windows.Forms.Button btnkaksi;
    }
}

