namespace _8
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
            this.tbStraal = new System.Windows.Forms.TextBox();
            this.lblStraal = new System.Windows.Forms.Label();
            this.tbOppervlakte = new System.Windows.Forms.TextBox();
            this.lblOppervlakte = new System.Windows.Forms.Label();
            this.tbInhoud = new System.Windows.Forms.TextBox();
            this.lblInhoud = new System.Windows.Forms.Label();
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbStraal
            // 
            this.tbStraal.Location = new System.Drawing.Point(83, 6);
            this.tbStraal.Name = "tbStraal";
            this.tbStraal.Size = new System.Drawing.Size(100, 20);
            this.tbStraal.TabIndex = 0;
            // 
            // lblStraal
            // 
            this.lblStraal.AutoSize = true;
            this.lblStraal.Location = new System.Drawing.Point(43, 9);
            this.lblStraal.Name = "lblStraal";
            this.lblStraal.Size = new System.Drawing.Size(34, 13);
            this.lblStraal.TabIndex = 1;
            this.lblStraal.Text = "Straal";
            // 
            // tbOppervlakte
            // 
            this.tbOppervlakte.Location = new System.Drawing.Point(83, 61);
            this.tbOppervlakte.Name = "tbOppervlakte";
            this.tbOppervlakte.Size = new System.Drawing.Size(100, 20);
            this.tbOppervlakte.TabIndex = 2;
            // 
            // lblOppervlakte
            // 
            this.lblOppervlakte.AutoSize = true;
            this.lblOppervlakte.Location = new System.Drawing.Point(12, 64);
            this.lblOppervlakte.Name = "lblOppervlakte";
            this.lblOppervlakte.Size = new System.Drawing.Size(65, 13);
            this.lblOppervlakte.TabIndex = 3;
            this.lblOppervlakte.Text = "Oppervlakte";
            // 
            // tbInhoud
            // 
            this.tbInhoud.Location = new System.Drawing.Point(83, 87);
            this.tbInhoud.Name = "tbInhoud";
            this.tbInhoud.Size = new System.Drawing.Size(100, 20);
            this.tbInhoud.TabIndex = 4;
            // 
            // lblInhoud
            // 
            this.lblInhoud.AutoSize = true;
            this.lblInhoud.Location = new System.Drawing.Point(37, 90);
            this.lblInhoud.Name = "lblInhoud";
            this.lblInhoud.Size = new System.Drawing.Size(40, 13);
            this.lblInhoud.TabIndex = 5;
            this.lblInhoud.Text = "Inhoud";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(83, 32);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 6;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 139);
            this.Controls.Add(this.btnAntwoord);
            this.Controls.Add(this.lblInhoud);
            this.Controls.Add(this.tbInhoud);
            this.Controls.Add(this.lblOppervlakte);
            this.Controls.Add(this.tbOppervlakte);
            this.Controls.Add(this.lblStraal);
            this.Controls.Add(this.tbStraal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStraal;
        private System.Windows.Forms.Label lblStraal;
        private System.Windows.Forms.TextBox tbOppervlakte;
        private System.Windows.Forms.Label lblOppervlakte;
        private System.Windows.Forms.TextBox tbInhoud;
        private System.Windows.Forms.Label lblInhoud;
        private System.Windows.Forms.Button btnAntwoord;
    }
}

