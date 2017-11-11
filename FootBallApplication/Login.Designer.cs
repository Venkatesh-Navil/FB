namespace FootBallApplication
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnllogin = new System.Windows.Forms.Panel();
            this.pnlcancel = new System.Windows.Forms.Panel();
            this.pnllogi1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblforgotpassword = new System.Windows.Forms.Label();
            this.lblnewuser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(28, 207);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(232, 25);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPassword.Location = new System.Drawing.Point(28, 279);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(232, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(458, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "KICKME";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pnllogin
            // 
            this.pnllogin.BackColor = System.Drawing.Color.Transparent;
            this.pnllogin.Location = new System.Drawing.Point(28, 13);
            this.pnllogin.Name = "pnllogin";
            this.pnllogin.Size = new System.Drawing.Size(111, 28);
            this.pnllogin.TabIndex = 4;
            this.pnllogin.Visible = false;
            this.pnllogin.Paint += new System.Windows.Forms.PaintEventHandler(this.pnllogin_Paint);
            this.pnllogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnllogin_MouseDown);
            // 
            // pnlcancel
            // 
            this.pnlcancel.BackColor = System.Drawing.Color.Transparent;
            this.pnlcancel.Location = new System.Drawing.Point(783, 14);
            this.pnlcancel.Name = "pnlcancel";
            this.pnlcancel.Size = new System.Drawing.Size(91, 21);
            this.pnlcancel.TabIndex = 4;
            this.pnlcancel.Visible = false;
            this.pnlcancel.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlcancel_Paint);
            this.pnlcancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlcancel_MouseDown);
            // 
            // pnllogi1
            // 
            this.pnllogi1.BackColor = System.Drawing.Color.Transparent;
            this.pnllogi1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnllogi1.Location = new System.Drawing.Point(148, 338);
            this.pnllogi1.Name = "pnllogi1";
            this.pnllogi1.Size = new System.Drawing.Size(112, 31);
            this.pnllogi1.TabIndex = 5;
            this.pnllogi1.Paint += new System.Windows.Forms.PaintEventHandler(this.pnllogi1_Paint);
            this.pnllogi1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnllogi1_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Exit";
            this.label1.Visible = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::FootBallApplication.Properties.Resources.ven;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(424, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 35);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // lblforgotpassword
            // 
            this.lblforgotpassword.AutoSize = true;
            this.lblforgotpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblforgotpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblforgotpassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgotpassword.ForeColor = System.Drawing.Color.Crimson;
            this.lblforgotpassword.Location = new System.Drawing.Point(150, 316);
            this.lblforgotpassword.Name = "lblforgotpassword";
            this.lblforgotpassword.Size = new System.Drawing.Size(107, 15);
            this.lblforgotpassword.TabIndex = 12;
            this.lblforgotpassword.Text = "Forgot Password ?";
            this.lblforgotpassword.Click += new System.EventHandler(this.lblforgotpassword_Click);
            // 
            // lblnewuser
            // 
            this.lblnewuser.AutoSize = true;
            this.lblnewuser.BackColor = System.Drawing.Color.Transparent;
            this.lblnewuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblnewuser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnewuser.ForeColor = System.Drawing.Color.Crimson;
            this.lblnewuser.Location = new System.Drawing.Point(162, 159);
            this.lblnewuser.Name = "lblnewuser";
            this.lblnewuser.Size = new System.Drawing.Size(124, 15);
            this.lblnewuser.TabIndex = 11;
            this.lblnewuser.Text = "Create your account !";
            this.lblnewuser.Click += new System.EventHandler(this.lblnewuser_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(26, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Don\'t have an account ?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FootBallApplication.Properties.Resources.Loginnfb;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(680, 475);
            this.Controls.Add(this.lblforgotpassword);
            this.Controls.Add(this.lblnewuser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnllogi1);
            this.Controls.Add(this.pnlcancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnllogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(696, 514);
            this.MinimumSize = new System.Drawing.Size(696, 514);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnllogin;
        private System.Windows.Forms.Panel pnlcancel;
        private System.Windows.Forms.Panel pnllogi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblforgotpassword;
        private System.Windows.Forms.Label lblnewuser;
        private System.Windows.Forms.Label label5;
    }
}