namespace _4
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
            this.tbGetal1 = new System.Windows.Forms.TextBox();
            this.tbOperatie = new System.Windows.Forms.TextBox();
            this.tbGetal2 = new System.Windows.Forms.TextBox();
            this.tbAntwoord = new System.Windows.Forms.TextBox();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.lblGetal1 = new System.Windows.Forms.Label();
            this.lblOperatie = new System.Windows.Forms.Label();
            this.lblGetal2 = new System.Windows.Forms.Label();
            this.lblAntwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbGetal1
            // 
            this.tbGetal1.Location = new System.Drawing.Point(70, 12);
            this.tbGetal1.Name = "tbGetal1";
            this.tbGetal1.Size = new System.Drawing.Size(100, 20);
            this.tbGetal1.TabIndex = 0;
            // 
            // tbOperatie
            // 
            this.tbOperatie.Location = new System.Drawing.Point(70, 38);
            this.tbOperatie.Name = "tbOperatie";
            this.tbOperatie.Size = new System.Drawing.Size(25, 20);
            this.tbOperatie.TabIndex = 1;
            // 
            // tbGetal2
            // 
            this.tbGetal2.Location = new System.Drawing.Point(70, 64);
            this.tbGetal2.Name = "tbGetal2";
            this.tbGetal2.Size = new System.Drawing.Size(100, 20);
            this.tbGetal2.TabIndex = 2;
            this.tbGetal2.Text = " ";
            // 
            // tbAntwoord
            // 
            this.tbAntwoord.Location = new System.Drawing.Point(70, 119);
            this.tbAntwoord.Name = "tbAntwoord";
            this.tbAntwoord.Size = new System.Drawing.Size(100, 20);
            this.tbAntwoord.TabIndex = 3;
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(70, 90);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 4;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // lblGetal1
            // 
            this.lblGetal1.AutoSize = true;
            this.lblGetal1.Location = new System.Drawing.Point(23, 15);
            this.lblGetal1.Name = "lblGetal1";
            this.lblGetal1.Size = new System.Drawing.Size(41, 13);
            this.lblGetal1.TabIndex = 5;
            this.lblGetal1.Text = "Getal 1";
            // 
            // lblOperatie
            // 
            this.lblOperatie.AutoSize = true;
            this.lblOperatie.Location = new System.Drawing.Point(17, 41);
            this.lblOperatie.Name = "lblOperatie";
            this.lblOperatie.Size = new System.Drawing.Size(47, 13);
            this.lblOperatie.TabIndex = 6;
            this.lblOperatie.Text = "Operatie";
            // 
            // lblGetal2
            // 
            this.lblGetal2.AutoSize = true;
            this.lblGetal2.Location = new System.Drawing.Point(23, 67);
            this.lblGetal2.Name = "lblGetal2";
            this.lblGetal2.Size = new System.Drawing.Size(41, 13);
            this.lblGetal2.TabIndex = 7;
            this.lblGetal2.Text = "Getal 2";
            // 
            // lblAntwoord
            // 
            this.lblAntwoord.AutoSize = true;
            this.lblAntwoord.Location = new System.Drawing.Point(12, 122);
            this.lblAntwoord.Name = "lblAntwoord";
            this.lblAntwoord.Size = new System.Drawing.Size(52, 13);
            this.lblAntwoord.TabIndex = 8;
            this.lblAntwoord.Text = "Antwoord";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(186, 151);
            this.Controls.Add(this.lblAntwoord);
            this.Controls.Add(this.lblGetal2);
            this.Controls.Add(this.lblOperatie);
            this.Controls.Add(this.lblGetal1);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.tbAntwoord);
            this.Controls.Add(this.tbGetal2);
            this.Controls.Add(this.tbOperatie);
            this.Controls.Add(this.tbGetal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbGetal1;
        private System.Windows.Forms.TextBox tbOperatie;
        private System.Windows.Forms.TextBox tbGetal2;
        private System.Windows.Forms.TextBox tbAntwoord;
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.Label lblGetal1;
        private System.Windows.Forms.Label lblOperatie;
        private System.Windows.Forms.Label lblGetal2;
        private System.Windows.Forms.Label lblAntwoord;
    }
}

