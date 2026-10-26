
namespace xyohjelma
{
    partial class xyohjelma
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
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnVaihda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(59, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(59, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbX.Location = new System.Drawing.Point(100, 122);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 31);
            this.tbX.TabIndex = 2;
            this.tbX.Text = "0";
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbX_KeyPress);
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.tbY.Location = new System.Drawing.Point(100, 195);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 31);
            this.tbY.TabIndex = 3;
            this.tbY.Text = "0";
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbY_KeyPress);
            // 
            // btnVaihda
            // 
            this.btnVaihda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnVaihda.Location = new System.Drawing.Point(104, 274);
            this.btnVaihda.Name = "btnVaihda";
            this.btnVaihda.Size = new System.Drawing.Size(96, 51);
            this.btnVaihda.TabIndex = 4;
            this.btnVaihda.Text = "Vaihda";
            this.btnVaihda.UseVisualStyleBackColor = true;
            this.btnVaihda.Click += new System.EventHandler(this.btnVaihda_Click);
            // 
            // xyohjelma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.btnVaihda);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "xyohjelma";
            this.Text = "Paikanvaihto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnVaihda;
    }
}

