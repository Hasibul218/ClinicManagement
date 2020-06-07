namespace ClinicManagement
{
    partial class AdminProfile
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
            this.BtnPatientList = new MetroFramework.Controls.MetroButton();
            this.BtnClinicList = new MetroFramework.Controls.MetroButton();
            this.BtnDoctorList = new MetroFramework.Controls.MetroButton();
            this.btnRegistrationClinic = new MetroFramework.Controls.MetroButton();
            this.btnDoctorRequest = new MetroFramework.Controls.MetroButton();
            this.btnLogoutAdmin = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // BtnPatientList
            // 
            this.BtnPatientList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPatientList.Location = new System.Drawing.Point(383, 202);
            this.BtnPatientList.Name = "BtnPatientList";
            this.BtnPatientList.Size = new System.Drawing.Size(126, 23);
            this.BtnPatientList.TabIndex = 0;
            this.BtnPatientList.Text = "Patient List";
            this.BtnPatientList.UseSelectable = true;
            this.BtnPatientList.Click += new System.EventHandler(this.BtnPatientList_Click);
            // 
            // BtnClinicList
            // 
            this.BtnClinicList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClinicList.Location = new System.Drawing.Point(383, 357);
            this.BtnClinicList.Name = "BtnClinicList";
            this.BtnClinicList.Size = new System.Drawing.Size(126, 23);
            this.BtnClinicList.TabIndex = 1;
            this.BtnClinicList.Text = "Clinic List";
            this.BtnClinicList.UseSelectable = true;
            this.BtnClinicList.Click += new System.EventHandler(this.BtnClinicList_Click);
            // 
            // BtnDoctorList
            // 
            this.BtnDoctorList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDoctorList.Location = new System.Drawing.Point(383, 308);
            this.BtnDoctorList.Name = "BtnDoctorList";
            this.BtnDoctorList.Size = new System.Drawing.Size(126, 23);
            this.BtnDoctorList.TabIndex = 2;
            this.BtnDoctorList.Text = "Doctor List";
            this.BtnDoctorList.UseSelectable = true;
            this.BtnDoctorList.Click += new System.EventHandler(this.BtnDoctorList_Click);
            // 
            // btnRegistrationClinic
            // 
            this.btnRegistrationClinic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrationClinic.Location = new System.Drawing.Point(383, 250);
            this.btnRegistrationClinic.Name = "btnRegistrationClinic";
            this.btnRegistrationClinic.Size = new System.Drawing.Size(126, 23);
            this.btnRegistrationClinic.TabIndex = 3;
            this.btnRegistrationClinic.Text = "Clinic Registration";
            this.btnRegistrationClinic.UseSelectable = true;
            this.btnRegistrationClinic.Click += new System.EventHandler(this.BtnRegistrationClinic_Click);
            // 
            // btnDoctorRequest
            // 
            this.btnDoctorRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorRequest.Location = new System.Drawing.Point(383, 409);
            this.btnDoctorRequest.Name = "btnDoctorRequest";
            this.btnDoctorRequest.Size = new System.Drawing.Size(126, 23);
            this.btnDoctorRequest.TabIndex = 4;
            this.btnDoctorRequest.Text = "Doctor\'s Request";
            this.btnDoctorRequest.UseSelectable = true;
            this.btnDoctorRequest.Click += new System.EventHandler(this.BtnDoctorRequest_Click);
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(1071, 22);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnLogoutAdmin.TabIndex = 5;
            this.btnLogoutAdmin.Text = "Log Out";
            this.btnLogoutAdmin.UseSelectable = true;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 561);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Controls.Add(this.btnDoctorRequest);
            this.Controls.Add(this.btnRegistrationClinic);
            this.Controls.Add(this.BtnDoctorList);
            this.Controls.Add(this.BtnClinicList);
            this.Controls.Add(this.BtnPatientList);
            this.Name = "AdminProfile";
            this.Text = "Admin Home Page";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnPatientList;
        private MetroFramework.Controls.MetroButton BtnClinicList;
        private MetroFramework.Controls.MetroButton BtnDoctorList;
        private MetroFramework.Controls.MetroButton btnRegistrationClinic;
        private MetroFramework.Controls.MetroButton btnDoctorRequest;
        private MetroFramework.Controls.MetroButton btnLogoutAdmin;
    }
}