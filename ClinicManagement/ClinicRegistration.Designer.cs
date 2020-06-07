namespace ClinicManagement
{
    partial class ClinicRegistration
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
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.comThana = new MetroFramework.Controls.MetroComboBox();
            this.comDistrict = new MetroFramework.Controls.MetroComboBox();
            this.comDivission = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnAddclinic = new MetroFramework.Controls.MetroButton();
            this.txtConPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnBackHomePage = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtUserId
            // 
            // 
            // 
            // 
            this.txtUserId.CustomButton.Image = null;
            this.txtUserId.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtUserId.CustomButton.Name = "";
            this.txtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserId.CustomButton.TabIndex = 1;
            this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserId.CustomButton.UseSelectable = true;
            this.txtUserId.CustomButton.Visible = false;
            this.txtUserId.Lines = new string[0];
            this.txtUserId.Location = new System.Drawing.Point(296, 138);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.PromptText = "User Id";
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.SelectionLength = 0;
            this.txtUserId.SelectionStart = 0;
            this.txtUserId.ShortcutsEnabled = true;
            this.txtUserId.Size = new System.Drawing.Size(169, 23);
            this.txtUserId.TabIndex = 31;
            this.txtUserId.UseSelectable = true;
            this.txtUserId.WaterMark = "User Id";
            this.txtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(296, 184);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PromptText = "Name";
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(169, 23);
            this.txtName.TabIndex = 30;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMark = "Name";
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // comThana
            // 
            this.comThana.FormattingEnabled = true;
            this.comThana.ItemHeight = 23;
            this.comThana.Location = new System.Drawing.Point(554, 355);
            this.comThana.Name = "comThana";
            this.comThana.PromptText = "Thana";
            this.comThana.Size = new System.Drawing.Size(121, 29);
            this.comThana.TabIndex = 29;
            this.comThana.UseSelectable = true;
            // 
            // comDistrict
            // 
            this.comDistrict.FormattingEnabled = true;
            this.comDistrict.ItemHeight = 23;
            this.comDistrict.Location = new System.Drawing.Point(425, 355);
            this.comDistrict.Name = "comDistrict";
            this.comDistrict.PromptText = "District";
            this.comDistrict.Size = new System.Drawing.Size(121, 29);
            this.comDistrict.TabIndex = 28;
            this.comDistrict.UseSelectable = true;
            this.comDistrict.SelectedIndexChanged += new System.EventHandler(this.ComDistrict_SelectedIndexChanged);
            // 
            // comDivission
            // 
            this.comDivission.FormattingEnabled = true;
            this.comDivission.ItemHeight = 23;
            this.comDivission.Location = new System.Drawing.Point(296, 355);
            this.comDivission.Name = "comDivission";
            this.comDivission.PromptText = "Divission";
            this.comDivission.Size = new System.Drawing.Size(121, 29);
            this.comDivission.TabIndex = 27;
            this.comDivission.UseSelectable = true;
            this.comDivission.SelectedIndexChanged += new System.EventHandler(this.ComDivission_SelectedIndexChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(152, 361);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(91, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Clinic Address";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(152, 188);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(80, 19);
            this.metroLabel2.TabIndex = 25;
            this.metroLabel2.Text = "Clinic Name";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(152, 142);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "User Id";
            // 
            // BtnAddclinic
            // 
            this.BtnAddclinic.Location = new System.Drawing.Point(399, 487);
            this.BtnAddclinic.Name = "BtnAddclinic";
            this.BtnAddclinic.Size = new System.Drawing.Size(75, 23);
            this.BtnAddclinic.TabIndex = 32;
            this.BtnAddclinic.Text = "Add Clinic";
            this.BtnAddclinic.UseSelectable = true;
            this.BtnAddclinic.Click += new System.EventHandler(this.BtnAddclinic_Click);
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
            this.txtConPassword.Location = new System.Drawing.Point(296, 269);
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
            this.txtConPassword.TabIndex = 43;
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
            this.txtPassword.Location = new System.Drawing.Point(296, 228);
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
            this.txtPassword.TabIndex = 42;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMark = "Password";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(152, 228);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(63, 19);
            this.metroLabel9.TabIndex = 41;
            this.metroLabel9.Text = "Password";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(152, 269);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(115, 19);
            this.metroLabel8.TabIndex = 40;
            this.metroLabel8.Text = "Confirm Password";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(296, 312);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PromptText = "01XXXXXXXXX";
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(169, 23);
            this.txtPhone.TabIndex = 45;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMark = "01XXXXXXXXX";
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(152, 312);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 19);
            this.metroLabel4.TabIndex = 44;
            this.metroLabel4.Text = "Phone";
            // 
            // btnBackHomePage
            // 
            this.btnBackHomePage.Location = new System.Drawing.Point(738, 24);
            this.btnBackHomePage.Name = "btnBackHomePage";
            this.btnBackHomePage.Size = new System.Drawing.Size(75, 23);
            this.btnBackHomePage.TabIndex = 46;
            this.btnBackHomePage.Text = "Back";
            this.btnBackHomePage.UseSelectable = true;
            this.btnBackHomePage.Click += new System.EventHandler(this.BtnBackHomePage_Click);
            // 
            // ClinicRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 556);
            this.Controls.Add(this.btnBackHomePage);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtConPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.BtnAddclinic);
            this.Controls.Add(this.txtUserId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.comThana);
            this.Controls.Add(this.comDistrict);
            this.Controls.Add(this.comDivission);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "ClinicRegistration";
            this.Text = "Clinic Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroComboBox comThana;
        private MetroFramework.Controls.MetroComboBox comDistrict;
        private MetroFramework.Controls.MetroComboBox comDivission;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnAddclinic;
        private MetroFramework.Controls.MetroTextBox txtConPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnBackHomePage;
    }
}