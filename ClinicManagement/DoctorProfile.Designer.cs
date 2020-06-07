namespace ClinicManagement
{
    partial class DoctorProfile
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
            this.btnLogoutDoctor = new MetroFramework.Controls.MetroButton();
            this.btnReqAppointment = new MetroFramework.Controls.MetroButton();
            this.btnSetSchedule = new MetroFramework.Controls.MetroButton();
            this.btnEditProfile = new MetroFramework.Controls.MetroButton();
            this.BtnPaWaitingList = new MetroFramework.Controls.MetroButton();
            this.bntPatientRecord = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnLogoutDoctor
            // 
            this.btnLogoutDoctor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutDoctor.Location = new System.Drawing.Point(992, 16);
            this.btnLogoutDoctor.Name = "btnLogoutDoctor";
            this.btnLogoutDoctor.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutDoctor.TabIndex = 1;
            this.btnLogoutDoctor.Text = "Log Out";
            this.btnLogoutDoctor.UseSelectable = true;
            this.btnLogoutDoctor.Click += new System.EventHandler(this.BtnLogoutDoctor_Click);
            // 
            // btnReqAppointment
            // 
            this.btnReqAppointment.Location = new System.Drawing.Point(924, 63);
            this.btnReqAppointment.Name = "btnReqAppointment";
            this.btnReqAppointment.Size = new System.Drawing.Size(143, 23);
            this.btnReqAppointment.TabIndex = 2;
            this.btnReqAppointment.Text = "Requested Appointment";
            this.btnReqAppointment.UseSelectable = true;
            this.btnReqAppointment.Click += new System.EventHandler(this.BtnReqAppointment_Click);
            // 
            // btnSetSchedule
            // 
            this.btnSetSchedule.Location = new System.Drawing.Point(878, 159);
            this.btnSetSchedule.Name = "btnSetSchedule";
            this.btnSetSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSetSchedule.TabIndex = 3;
            this.btnSetSchedule.Text = "Set Schedule";
            this.btnSetSchedule.UseSelectable = true;
            this.btnSetSchedule.Click += new System.EventHandler(this.BtnSetSchedule_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(788, 64);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.btnEditProfile.TabIndex = 4;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseSelectable = true;
            this.btnEditProfile.Click += new System.EventHandler(this.BtnEditProfile_Click);
            // 
            // BtnPaWaitingList
            // 
            this.BtnPaWaitingList.Location = new System.Drawing.Point(486, 277);
            this.BtnPaWaitingList.Name = "BtnPaWaitingList";
            this.BtnPaWaitingList.Size = new System.Drawing.Size(119, 23);
            this.BtnPaWaitingList.TabIndex = 5;
            this.BtnPaWaitingList.Text = "Patient Waiting List";
            this.BtnPaWaitingList.UseSelectable = true;
            this.BtnPaWaitingList.Click += new System.EventHandler(this.BtnPaWaitingList_Click);
            // 
            // bntPatientRecord
            // 
            this.bntPatientRecord.Location = new System.Drawing.Point(773, 277);
            this.bntPatientRecord.Name = "bntPatientRecord";
            this.bntPatientRecord.Size = new System.Drawing.Size(107, 23);
            this.bntPatientRecord.TabIndex = 6;
            this.bntPatientRecord.Text = "Patient Records";
            this.bntPatientRecord.UseSelectable = true;
            this.bntPatientRecord.Click += new System.EventHandler(this.BntPatientRecord_Click);
            // 
            // DoctorProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 577);
            this.Controls.Add(this.bntPatientRecord);
            this.Controls.Add(this.BtnPaWaitingList);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnSetSchedule);
            this.Controls.Add(this.btnReqAppointment);
            this.Controls.Add(this.btnLogoutDoctor);
            this.Name = "DoctorProfile";
            this.Text = "Doctor Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnLogoutDoctor;
        private MetroFramework.Controls.MetroButton btnReqAppointment;
        private MetroFramework.Controls.MetroButton btnSetSchedule;
        private MetroFramework.Controls.MetroButton btnEditProfile;
        private MetroFramework.Controls.MetroButton BtnPaWaitingList;
        private MetroFramework.Controls.MetroButton bntPatientRecord;
    }
}