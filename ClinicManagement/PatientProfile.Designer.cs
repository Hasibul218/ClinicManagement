namespace ClinicManagement
{
    partial class PatientProfile
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
            this.btnLogoutPatient = new MetroFramework.Controls.MetroButton();
            this.btnToDoctorSchedule = new MetroFramework.Controls.MetroButton();
            this.btnEditProfile = new MetroFramework.Controls.MetroButton();
            this.btnHistory = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogoutPatient
            // 
            this.btnLogoutPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutPatient.Location = new System.Drawing.Point(1017, 14);
            this.btnLogoutPatient.Name = "btnLogoutPatient";
            this.btnLogoutPatient.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutPatient.TabIndex = 0;
            this.btnLogoutPatient.Text = "Log Out";
            this.btnLogoutPatient.UseSelectable = true;
            this.btnLogoutPatient.Click += new System.EventHandler(this.BtnLogoutPatient_Click);
            // 
            // btnToDoctorSchedule
            // 
            this.btnToDoctorSchedule.Location = new System.Drawing.Point(977, 63);
            this.btnToDoctorSchedule.Name = "btnToDoctorSchedule";
            this.btnToDoctorSchedule.Size = new System.Drawing.Size(115, 23);
            this.btnToDoctorSchedule.TabIndex = 1;
            this.btnToDoctorSchedule.Text = "Take Appointment";
            this.btnToDoctorSchedule.UseSelectable = true;
            this.btnToDoctorSchedule.Click += new System.EventHandler(this.BtnToDoctorSchedule_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(1017, 131);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.btnEditProfile.TabIndex = 2;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseSelectable = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Location = new System.Drawing.Point(808, 177);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 23);
            this.btnHistory.TabIndex = 3;
            this.btnHistory.Text = "History";
            this.btnHistory.UseSelectable = true;
            this.btnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // PatientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 587);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnToDoctorSchedule);
            this.Controls.Add(this.btnLogoutPatient);
            this.Name = "PatientProfile";
            this.Text = "PatientProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogoutPatient;
        private MetroFramework.Controls.MetroButton btnToDoctorSchedule;
        private MetroFramework.Controls.MetroButton btnEditProfile;
        private MetroFramework.Controls.MetroButton btnHistory;
    }
}