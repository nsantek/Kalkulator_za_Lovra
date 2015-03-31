namespace Kalkulator1
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
            this.prviBroj = new System.Windows.Forms.TextBox();
            this.drugiBroj = new System.Windows.Forms.TextBox();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.box12 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prviBroj
            // 
            this.prviBroj.Location = new System.Drawing.Point(12, 12);
            this.prviBroj.Name = "prviBroj";
            this.prviBroj.Size = new System.Drawing.Size(177, 20);
            this.prviBroj.TabIndex = 0;
            this.prviBroj.TextChanged += new System.EventHandler(this.prviBroj_TextChanged);
            // 
            // drugiBroj
            // 
            this.drugiBroj.Location = new System.Drawing.Point(13, 54);
            this.drugiBroj.Name = "drugiBroj";
            this.drugiBroj.Size = new System.Drawing.Size(176, 20);
            this.drugiBroj.TabIndex = 1;
            this.drugiBroj.TextChanged += new System.EventHandler(this.drugiBroj_TextChanged);
            // 
            // rezultat
            // 
            this.rezultat.Location = new System.Drawing.Point(89, 103);
            this.rezultat.Name = "rezultat";
            this.rezultat.Size = new System.Drawing.Size(100, 20);
            this.rezultat.TabIndex = 2;
            this.rezultat.TextChanged += new System.EventHandler(this.rezultat_TextChanged);
            // 
            // box12
            // 
            this.box12.Location = new System.Drawing.Point(13, 103);
            this.box12.Name = "box12";
            this.box12.Size = new System.Drawing.Size(70, 20);
            this.box12.TabIndex = 3;
            this.box12.TabStop = false;
            this.box12.Text = "Rezultat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(13, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "/";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(114, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "*";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.box12);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.drugiBroj);
            this.Controls.Add(this.prviBroj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox prviBroj;
        private System.Windows.Forms.TextBox drugiBroj;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.GroupBox box12;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
    }
}

