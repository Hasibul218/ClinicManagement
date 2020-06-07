namespace ClinicManagement
{
    partial class PatientRegistration
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnSignUp = new MetroFramework.Controls.MetroButton();
            this.txtConPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbxAgreement = new MetroFramework.Controls.MetroCheckBox();
            this.txtDateOfBirth = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.RadioFemale = new MetroFramework.Controls.MetroRadioButton();
            this.RadioMale = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtUserid = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.ComThana = new MetroFramework.Controls.MetroComboBox();
            this.ComDistrict = new MetroFramework.Controls.MetroComboBox();
            this.ComDivission = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.bntBackHomePage = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.BtnSignUp);
            this.metroPanel1.Controls.Add(this.txtConPassword);
            this.metroPanel1.Controls.Add(this.txtPassword);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.cbxAgreement);
            this.metroPanel1.Controls.Add(this.txtDateOfBirth);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtPhoneNumber);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.RadioFemale);
            this.metroPanel1.Controls.Add(this.RadioMale);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtUserName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.txtUserid);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.ComThana);
            this.metroPanel1.Controls.Add(this.ComDistrict);
            this.metroPanel1.Controls.Add(this.ComDivission);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(169, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(797, 513);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnSignUp
            // 
            this.BtnSignUp.Location = new System.Drawing.Point(386, 443);
            this.BtnSignUp.Name = "BtnSignUp";
            this.BtnSignUp.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUp.TabIndex = 40;
            this.BtnSignUp.Text = "Sign Up";
            this.BtnSignUp.UseSelectable = true;
            this.BtnSignUp.Click += new System.EventHandler(this.Btn_signup_Click);
            // 
            // txtConPassword
            // 
            // 
            // 
            // 
            this.txtConPassword.CustomButton.Image = null;
            this.txtConPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtConPassword.CustomButton.Name = "";
            this.txtConPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConPassword.CustomButton.TabIndex = 1;
            this.txtConPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConPassword.CustomButton.UseSelectable = true;
            this.txtConPassword.CustomButton.Visible = false;
            this.txtConPassword.Lines = new string[0];
            this.txtConPassword.Location = new System.Drawing.Point(320, 139);
            this.txtConPassword.MaxLength = 32767;
            this.txtConPassword.Name = "txtConPassword";
            this.txtConPassword.PasswordChar = '*';
            this.txtConPassword.PromptText = "Confirm Password";
            this.txtConPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConPassword.SelectedText = "";
            this.txtConPassword.SelectionLength = 0;
            this.txtConPassword.SelectionStart = 0;
            this.txtConPassword.ShortcutsEnabled = true;
            this.txtConPassword.Size = new System.Drawing.Size(169, 23);
            this.txtConPassword.TabIndex = 39;
            this.txtConPassword.UseSelectable = true;
            this.txtConPassword.WaterMark = "Confirm Password";
            this.txtConPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(320, 98);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(169, 23);
            this.txtPassword.TabIndex = 38;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(176, 98);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 37;
            this.metroLabel9.Text = "Password";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(176, 139);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(115, 19);
            this.metroLabel8.TabIndex = 36;
            this.metroLabel8.Text = "Confirm Password";
            // 
            // cbxAgreement
            // 
            this.cbxAgreement.AutoSize = true;
            this.cbxAgreement.Location = new System.Drawing.Point(38, 390);
            this.cbxAgreement.Name = "cbxAgreement";
            this.cbxAgreement.Size = new System.Drawing.Size(735, 15);
            this.cbxAgreement.TabIndex = 35;
            this.cbxAgreement.Text = "I agree with the terms and conditions of this Software.I hereby declare that the " +
    "above given details are true to the best of  my Knowlage.";
            this.cbxAgreement.UseSelectable = true;
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.CustomFormat = "yyyy-MM-DD";
            this.txtDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateOfBirth.Location = new System.Drawing.Point(320, 287);
            this.txtDateOfBirth.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(169, 29);
            this.txtDateOfBirth.TabIndex = 34;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(176, 293);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(87, 19);
            this.metroLabel6.TabIndex = 33;
            this.metroLabel6.Text = "Date Of Birth";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(320, 249);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "example123@abc.com";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(169, 23);
            this.txtEmail.TabIndex = 32;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMark = "example123@abc.com";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.TxtEmail_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(176, 249);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 31;
            this.metroLabel5.Text = "Email";
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(320, 210);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PromptText = "01XXXXXXXXX";
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(169, 23);
            this.txtPhoneNumber.TabIndex = 30;
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMark = "01XXXXXXXXX";
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Click += new System.EventHandler(this.Txt_phone_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(176, 210);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Phone";
            // 
            // RadioFemale
            // 
            this.RadioFemale.AutoSize = true;
            this.RadioFemale.Location = new System.Drawing.Point(428, 177);
            this.RadioFemale.Name = "RadioFemale";
            this.RadioFemale.Size = new System.Drawing.Size(61, 15);
            this.RadioFemale.TabIndex = 28;
            this.RadioFemale.Text = "Female";
            this.RadioFemale.UseSelectable = true;
            // 
            // RadioMale
            // 
            this.RadioMale.AutoSize = true;
            this.RadioMale.Location = new System.Drawing.Point(320, 177);
            this.RadioMale.Name = "RadioMale";
            this.RadioMale.Size = new System.Drawing.Size(49, 15);
            this.RadioMale.TabIndex = 27;
            this.RadioMale.Text = "Male";
            this.RadioMale.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(176, 173);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(52, 19);
            this.metroLabel3.TabIndex = 26;
            this.metroLabel3.Text = "Gender";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(320, 58);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PromptText = "Name";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(169, 23);
            this.txtUserName.TabIndex = 25;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMark = "Name";
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtUserName.Click += new System.EventHandler(this.Txt_name_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(176, 58);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Name";
            // 
            // txtUserid
            // 
            // 
            // 
            // 
            this.txtUserid.CustomButton.Image = null;
            this.txtUserid.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUserid.CustomButton.Name = "";
            this.txtUserid.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserid.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserid.CustomButton.TabIndex = 1;
            this.txtUserid.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserid.CustomButton.UseSelectable = true;
            this.txtUserid.CustomButton.Visible = false;
            this.txtUserid.Lines = new string[0];
            this.txtUserid.Location = new System.Drawing.Point(320, 18);
            this.txtUserid.MaxLength = 32767;
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.PasswordChar = '\0';
            this.txtUserid.PromptText = "User Id";
            this.txtUserid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserid.SelectedText = "";
            this.txtUserid.SelectionLength = 0;
            this.txtUserid.SelectionStart = 0;
            this.txtUserid.ShortcutsEnabled = true;
            this.txtUserid.Size = new System.Drawing.Size(169, 23);
            this.txtUserid.TabIndex = 23;
            this.txtUserid.UseSelectable = true;
            this.txtUserid.WaterMark = "User Id";
            this.txtUserid.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserid.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(176, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "User Id";
            // 
            // ComThana
            // 
            this.ComThana.FormattingEnabled = true;
            this.ComThana.ItemHeight = 23;
            this.ComThana.Location = new System.Drawing.Point(565, 330);
            this.ComThana.Name = "ComThana";
            this.ComThana.PromptText = "Thana";
            this.ComThana.Size = new System.Drawing.Size(121, 29);
            this.ComThana.TabIndex = 21;
            this.ComThana.UseSelectable = true;
            // 
            // ComDistrict
            // 
            this.ComDistrict.FormattingEnabled = true;
            this.ComDistrict.ItemHeight = 23;
            this.ComDistrict.Location = new System.Drawing.Point(442, 330);
            this.ComDistrict.Name = "ComDistrict";
            this.ComDistrict.PromptText = "District";
            this.ComDistrict.Size = new System.Drawing.Size(121, 29);
            this.ComDistrict.TabIndex = 20;
            this.ComDistrict.UseSelectable = true;
            this.ComDistrict.SelectedIndexChanged += new System.EventHandler(this.Cbox_district_SelectedIndexChanged);
            // 
            // ComDivission
            // 
            this.ComDivission.FormattingEnabled = true;
            this.ComDivission.ItemHeight = 23;
            this.ComDivission.Location = new System.Drawing.Point(320, 330);
            this.ComDivission.Name = "ComDivission";
            this.ComDivission.PromptText = "Divission";
            this.ComDivission.Size = new System.Drawing.Size(121, 29);
            this.ComDivission.TabIndex = 19;
            this.ComDivission.UseSelectable = true;
            this.ComDivission.SelectedIndexChanged += new System.EventHandler(this.Cbox_divission_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(176, 334);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(56, 19);
            this.metroLabel7.TabIndex = 18;
            this.metroLabel7.Text = "Address";
            // 
            // bntBackHomePage
            // 
            this.bntBackHomePage.Location = new System.Drawing.Point(973, 18);
            this.bntBackHomePage.Name = "bntBackHomePage";
            this.bntBackHomePage.Size = new System.Drawing.Size(75, 23);
            this.bntBackHomePage.TabIndex = 2;
            this.bntBackHomePage.Text = "Back";
            this.bntBackHomePage.UseSelectable = true;
            this.bntBackHomePage.Click += new System.EventHandler(this.BntBackHomePage_Click);
            // 
            // PatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 602);
            this.Controls.Add(this.bntBackHomePage);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PatientRegistration";
            this.Text = "Patient Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtConPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroCheckBox cbxAgreement;
        private MetroFramework.Controls.MetroDateTime txtDateOfBirth;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroRadioButton RadioFemale;
        private MetroFramework.Controls.MetroRadioButton RadioMale;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtUserid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox ComThana;
        private MetroFramework.Controls.MetroComboBox ComDistrict;
        private MetroFramework.Controls.MetroComboBox ComDivission;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton BtnSignUp;
        private MetroFramework.Controls.MetroButton bntBackHomePage;
    }
}