namespace _3
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
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.tbAttempts = new System.Windows.Forms.TextBox();
            this.lblYesNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(17, 15);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(43, 13);
            this.lblUserID.TabIndex = 0;
            this.lblUserID.Text = "User ID";
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Location = new System.Drawing.Point(12, 41);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(53, 13);
            this.lblPassWord.TabIndex = 1;
            this.lblPassWord.Text = "Password";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(71, 12);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(100, 20);
            this.tbUserID.TabIndex = 2;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Location = new System.Drawing.Point(71, 38);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.Size = new System.Drawing.Size(100, 20);
            this.tbPassWord.TabIndex = 3;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(71, 90);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 4;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAttempts
            // 
            this.lblAttempts.AutoSize = true;
            this.lblAttempts.Location = new System.Drawing.Point(17, 67);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(48, 13);
            this.lblAttempts.TabIndex = 5;
            this.lblAttempts.Text = "Attempts";
            // 
            // tbAttempts
            // 
            this.tbAttempts.Location = new System.Drawing.Point(71, 64);
            this.tbAttempts.Name = "tbAttempts";
            this.tbAttempts.Size = new System.Drawing.Size(19, 20);
            this.tbAttempts.TabIndex = 6;
            this.tbAttempts.Text = "3";
            // 
            // lblYesNo
            // 
            this.lblYesNo.AutoSize = true;
            this.lblYesNo.Location = new System.Drawing.Point(71, 116);
            this.lblYesNo.Name = "lblYesNo";
            this.lblYesNo.Size = new System.Drawing.Size(44, 13);
            this.lblYesNo.TabIndex = 7;
            this.lblYesNo.Text = "Yes/No";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 149);
            this.Controls.Add(this.lblYesNo);
            this.Controls.Add(this.tbAttempts);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tbPassWord);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblAttempts;
        private System.Windows.Forms.TextBox tbAttempts;
        private System.Windows.Forms.Label lblYesNo;
    }
}

