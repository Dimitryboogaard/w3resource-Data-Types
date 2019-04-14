namespace _5
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
            this.btnAntwoord = new System.Windows.Forms.Button();
            this.tbOmtrek = new System.Windows.Forms.TextBox();
            this.tbOpperVlakte = new System.Windows.Forms.TextBox();
            this.lblOmtrek = new System.Windows.Forms.Label();
            this.lblOpperVlakte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStraal
            // 
            this.tbStraal.Location = new System.Drawing.Point(83, 12);
            this.tbStraal.Name = "tbStraal";
            this.tbStraal.Size = new System.Drawing.Size(100, 20);
            this.tbStraal.TabIndex = 0;
            // 
            // lblStraal
            // 
            this.lblStraal.AutoSize = true;
            this.lblStraal.Location = new System.Drawing.Point(43, 15);
            this.lblStraal.Name = "lblStraal";
            this.lblStraal.Size = new System.Drawing.Size(34, 13);
            this.lblStraal.TabIndex = 1;
            this.lblStraal.Text = "Straal";
            // 
            // btnAntwoord
            // 
            this.btnAntwoord.Location = new System.Drawing.Point(83, 38);
            this.btnAntwoord.Name = "btnAntwoord";
            this.btnAntwoord.Size = new System.Drawing.Size(75, 23);
            this.btnAntwoord.TabIndex = 2;
            this.btnAntwoord.Text = "Antwoord";
            this.btnAntwoord.UseVisualStyleBackColor = true;
            this.btnAntwoord.Click += new System.EventHandler(this.btnAntwoord_Click);
            // 
            // tbOmtrek
            // 
            this.tbOmtrek.Location = new System.Drawing.Point(83, 67);
            this.tbOmtrek.Name = "tbOmtrek";
            this.tbOmtrek.Size = new System.Drawing.Size(100, 20);
            this.tbOmtrek.TabIndex = 3;
            // 
            // tbOpperVlakte
            // 
            this.tbOpperVlakte.Location = new System.Drawing.Point(83, 93);
            this.tbOpperVlakte.Name = "tbOpperVlakte";
            this.tbOpperVlakte.Size = new System.Drawing.Size(100, 20);
            this.tbOpperVlakte.TabIndex = 4;
            // 
            // lblOmtrek
            // 
            this.lblOmtrek.AutoSize = true;
            this.lblOmtrek.Location = new System.Drawing.Point(36, 70);
            this.lblOmtrek.Name = "lblOmtrek";
            this.lblOmtrek.Size = new System.Drawing.Size(41, 13);
            this.lblOmtrek.TabIndex = 5;
            this.lblOmtrek.Text = "Omtrek";
            // 
            // lblOpperVlakte
            // 
            this.lblOpperVlakte.AutoSize = true;
            this.lblOpperVlakte.Location = new System.Drawing.Point(12, 96);
            this.lblOpperVlakte.Name = "lblOpperVlakte";
            this.lblOpperVlakte.Size = new System.Drawing.Size(65, 13);
            this.lblOpperVlakte.TabIndex = 6;
            this.lblOpperVlakte.Text = "Oppervlakte";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 148);
            this.Controls.Add(this.lblOpperVlakte);
            this.Controls.Add(this.lblOmtrek);
            this.Controls.Add(this.tbOpperVlakte);
            this.Controls.Add(this.tbOmtrek);
            this.Controls.Add(this.btnAntwoord);
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
        private System.Windows.Forms.Button btnAntwoord;
        private System.Windows.Forms.TextBox tbOmtrek;
        private System.Windows.Forms.TextBox tbOpperVlakte;
        private System.Windows.Forms.Label lblOmtrek;
        private System.Windows.Forms.Label lblOpperVlakte;
    }
}

