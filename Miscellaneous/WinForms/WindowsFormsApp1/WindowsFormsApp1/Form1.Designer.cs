
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
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnJako = new System.Windows.Forms.Button();
            this.btnKerto = new System.Windows.Forms.Button();
            this.btnMiinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnPlus.Location = new System.Drawing.Point(160, 202);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(195, 84);
            this.btnPlus.TabIndex = 0;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnJako
            // 
            this.btnJako.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnJako.Location = new System.Drawing.Point(413, 312);
            this.btnJako.Name = "btnJako";
            this.btnJako.Size = new System.Drawing.Size(195, 84);
            this.btnJako.TabIndex = 1;
            this.btnJako.Text = "/";
            this.btnJako.UseVisualStyleBackColor = true;
            this.btnJako.Click += new System.EventHandler(this.btnJako_Click);
            // 
            // btnKerto
            // 
            this.btnKerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnKerto.Location = new System.Drawing.Point(160, 312);
            this.btnKerto.Name = "btnKerto";
            this.btnKerto.Size = new System.Drawing.Size(195, 84);
            this.btnKerto.TabIndex = 2;
            this.btnKerto.Text = "*";
            this.btnKerto.UseVisualStyleBackColor = true;
            this.btnKerto.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnMiinus
            // 
            this.btnMiinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold);
            this.btnMiinus.Location = new System.Drawing.Point(413, 202);
            this.btnMiinus.Name = "btnMiinus";
            this.btnMiinus.Size = new System.Drawing.Size(195, 84);
            this.btnMiinus.TabIndex = 3;
            this.btnMiinus.Text = "-";
            this.btnMiinus.UseVisualStyleBackColor = true;
            this.btnMiinus.Click += new System.EventHandler(this.btnMiinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMiinus);
            this.Controls.Add(this.btnKerto);
            this.Controls.Add(this.btnJako);
            this.Controls.Add(this.btnPlus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnJako;
        private System.Windows.Forms.Button btnKerto;
        private System.Windows.Forms.Button btnMiinus;
    }
}

