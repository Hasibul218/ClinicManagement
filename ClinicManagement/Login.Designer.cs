namespace ClinicManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_userid = new MetroFramework.Controls.MetroTextBox();
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.bntBackHomePage = new MetroFramework.Controls.MetroButton();
            this.ChPassword = new MetroFramework.Controls.MetroCheckBox();
            this.txt_password = new MetroFramework.Controls.MetroTextBox();
            this.bntExit = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // txt_userid
            // 
            // 
            // 
            // 
            this.txt_userid.CustomButton.Image = null;
            this.txt_userid.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_userid.CustomButton.Name = "";
            this.txt_userid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_userid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_userid.CustomButton.TabIndex = 1;
            this.txt_userid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_userid.CustomButton.UseSelectable = true;
            this.txt_userid.CustomButton.Visible = false;
            this.txt_userid.Lines = new string[0];
            this.txt_userid.Location = new System.Drawing.Point(129, 180);
            this.txt_userid.MaxLength = 32767;
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.PasswordChar = '\0';
            this.txt_userid.PromptText = "User Id";
            this.txt_userid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_userid.SelectedText = "";
            this.txt_userid.SelectionLength = 0;
            this.txt_userid.SelectionStart = 0;
            this.txt_userid.ShortcutsEnabled = true;
            this.txt_userid.Size = new System.Drawing.Size(173, 23);
            this.txt_userid.TabIndex = 5;
            this.txt_userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_userid.UseSelectable = true;
            this.txt_userid.WaterMark = "User Id";
            this.txt_userid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_userid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_login
            // 
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Location = new System.Drawing.Point(129, 315);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(82, 23);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Log In";
            this.btn_login.UseSelectable = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click_1);
            // 
            // bntBackHomePage
            // 
            this.bntBackHomePage.Location = new System.Drawing.Point(339, 17);
            this.bntBackHomePage.Name = "bntBackHomePage";
            this.bntBackHomePage.Size = new System.Drawing.Size(75, 23);
            this.bntBackHomePage.TabIndex = 8;
            this.bntBackHomePage.Text = "Back";
            this.bntBackHomePage.UseSelectable = true;
            this.bntBackHomePage.Click += new System.EventHandler(this.BntBackHomePage_Click);
            // 
            // ChPassword
            // 
            this.ChPassword.AutoSize = true;
            this.ChPassword.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.ChPassword.Location = new System.Drawing.Point(129, 284);
            this.ChPassword.Name = "ChPassword";
            this.ChPassword.Size = new System.Drawing.Size(120, 19);
            this.ChPassword.TabIndex = 9;
            this.ChPassword.Text = "Show Password";
            this.ChPassword.UseSelectable = true;
            this.ChPassword.CheckedChanged += new System.EventHandler(this.ChPassword_CheckedChanged);
            // 
            // txt_password
            // 
            // 
            // 
            // 
            this.txt_password.CustomButton.Image = null;
            this.txt_password.CustomButton.Location = new System.Drawing.Point(151, 1);
            this.txt_password.CustomButton.Name = "";
            this.txt_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txt_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_password.CustomButton.TabIndex = 1;
            this.txt_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_password.CustomButton.UseSelectable = true;
            this.txt_password.CustomButton.Visible = false;
            this.txt_password.Lines = new string[0];
            this.txt_password.Location = new System.Drawing.Point(129, 251);
            this.txt_password.MaxLength = 32767;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PromptText = "Password";
            this.txt_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_password.SelectedText = "";
            this.txt_password.SelectionLength = 0;
            this.txt_password.SelectionStart = 0;
            this.txt_password.ShortcutsEnabled = true;
            this.txt_password.Size = new System.Drawing.Size(173, 23);
            this.txt_password.TabIndex = 10;
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.UseSelectable = true;
            this.txt_password.WaterMark = "Password";
            this.txt_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bntExit
            // 
            this.bntExit.Location = new System.Drawing.Point(220, 315);
            this.bntExit.Name = "bntExit";
            this.bntExit.Size = new System.Drawing.Size(82, 23);
            this.bntExit.TabIndex = 11;
            this.bntExit.Text = "Exit";
            this.bntExit.UseSelectable = true;
            this.bntExit.Click += new System.EventHandler(this.BntExit_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 437);
            this.Controls.Add(this.bntExit);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.ChPassword);
            this.Controls.Add(this.bntBackHomePage);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login Frame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_userid;
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton bntBackHomePage;
        private MetroFramework.Controls.MetroCheckBox ChPassword;
        private MetroFramework.Controls.MetroTextBox txt_password;
        private MetroFramework.Controls.MetroButton bntExit;
    }
}

