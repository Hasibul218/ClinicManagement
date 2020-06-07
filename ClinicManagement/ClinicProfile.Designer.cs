namespace ClinicManagement
{
    partial class ClinicProfile
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
            this.btnLogoutClinic = new MetroFramework.Controls.MetroButton();
            this.btnEditProfile = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogoutClinic
            // 
            this.btnLogoutClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutClinic.Location = new System.Drawing.Point(962, 24);
            this.btnLogoutClinic.Name = "btnLogoutClinic";
            this.btnLogoutClinic.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutClinic.TabIndex = 1;
            this.btnLogoutClinic.Text = "Log Out";
            this.btnLogoutClinic.UseSelectable = true;
            this.btnLogoutClinic.Click += new System.EventHandler(this.BtnLogoutClinic_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(962, 117);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseSelectable = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // ClinicProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 585);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnLogoutClinic);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ClinicProfile";
            this.Text = "Clinic Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ClinicProfile_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogoutClinic;
        private MetroFramework.Controls.MetroButton btnEditProfile;
    }
}