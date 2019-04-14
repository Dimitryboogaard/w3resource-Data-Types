namespace _2
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
            this.rtUitvoer = new System.Windows.Forms.RichTextBox();
            this.tbGetal = new System.Windows.Forms.TextBox();
            this.tbBreedte = new System.Windows.Forms.TextBox();
            this.lblGetal = new System.Windows.Forms.Label();
            this.lblBreedte = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtUitvoer
            // 
            this.rtUitvoer.Location = new System.Drawing.Point(168, 12);
            this.rtUitvoer.Name = "rtUitvoer";
            this.rtUitvoer.Size = new System.Drawing.Size(190, 236);
            this.rtUitvoer.TabIndex = 0;
            this.rtUitvoer.Text = "";
            // 
            // tbGetal
            // 
            this.tbGetal.Location = new System.Drawing.Point(62, 12);
            this.tbGetal.Name = "tbGetal";
            this.tbGetal.Size = new System.Drawing.Size(100, 20);
            this.tbGetal.TabIndex = 1;
            // 
            // tbBreedte
            // 
            this.tbBreedte.Location = new System.Drawing.Point(62, 38);
            this.tbBreedte.Name = "tbBreedte";
            this.tbBreedte.Size = new System.Drawing.Size(100, 20);
            this.tbBreedte.TabIndex = 2;
            // 
            // lblGetal
            // 
            this.lblGetal.AutoSize = true;
            this.lblGetal.Location = new System.Drawing.Point(24, 15);
            this.lblGetal.Name = "lblGetal";
            this.lblGetal.Size = new System.Drawing.Size(32, 13);
            this.lblGetal.TabIndex = 3;
            this.lblGetal.Text = "Getal";
            // 
            // lblBreedte
            // 
            this.lblBreedte.AutoSize = true;
            this.lblBreedte.Location = new System.Drawing.Point(12, 41);
            this.lblBreedte.Name = "lblBreedte";
            this.lblBreedte.Size = new System.Drawing.Size(44, 13);
            this.lblBreedte.TabIndex = 4;
            this.lblBreedte.Text = "Breedte";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(62, 64);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 5;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 275);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblBreedte);
            this.Controls.Add(this.lblGetal);
            this.Controls.Add(this.tbBreedte);
            this.Controls.Add(this.tbGetal);
            this.Controls.Add(this.rtUitvoer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtUitvoer;
        private System.Windows.Forms.TextBox tbGetal;
        private System.Windows.Forms.TextBox tbBreedte;
        private System.Windows.Forms.Label lblGetal;
        private System.Windows.Forms.Label lblBreedte;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

