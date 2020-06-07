namespace ClinicManagement
{
    partial class DoctorRegReqToAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntBackAdminProfile = new MetroFramework.Controls.MetroButton();
            this.GridDoctorsList = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bmdcregno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnAccept = new MetroFramework.Controls.MetroButton();
            this.BtnReject = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).BeginInit();
            this.SuspendLayout();
            // 
            // bntBackAdminProfile
            // 
            this.bntBackAdminProfile.Location = new System.Drawing.Point(1095, 20);
            this.bntBackAdminProfile.Name = "bntBackAdminProfile";
            this.bntBackAdminProfile.Size = new System.Drawing.Size(75, 23);
            this.bntBackAdminProfile.TabIndex = 56;
            this.bntBackAdminProfile.Text = "Back";
            this.bntBackAdminProfile.UseSelectable = true;
            this.bntBackAdminProfile.Click += new System.EventHandler(this.BtnFromDoctorsList_Click);
            // 
            // GridDoctorsList
            // 
            this.GridDoctorsList.AllowUserToAddRows = false;
            this.GridDoctorsList.AllowUserToDeleteRows = false;
            this.GridDoctorsList.AllowUserToResizeRows = false;
            this.GridDoctorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridDoctorsList.BackgroundColor = System.Drawing.Color.Silver;
            this.GridDoctorsList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridDoctorsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GridDoctorsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridDoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDoctorsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.userid,
            this.username,
            this.gender,
            this.phone,
            this.email,
            this.dateOfBirth,
            this.specialty,
            this.degree,
            this.bmdcregno,
            this.description,
            this.divission,
            this.district,
            this.thana});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridDoctorsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridDoctorsList.EnableHeadersVisualStyles = false;
            this.GridDoctorsList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridDoctorsList.GridColor = System.Drawing.Color.Blue;
            this.GridDoctorsList.Location = new System.Drawing.Point(11, 63);
            this.GridDoctorsList.Name = "GridDoctorsList";
            this.GridDoctorsList.ReadOnly = true;
            this.GridDoctorsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridDoctorsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridDoctorsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridDoctorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridDoctorsList.Size = new System.Drawing.Size(997, 521);
            this.GridDoctorsList.TabIndex = 57;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // userid
            // 
            this.userid.DataPropertyName = "userid";
            this.userid.HeaderText = "User ID";
            this.userid.Name = "userid";
            this.userid.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "User Name";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "Phone Number";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "Date Of Birth";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // degree
            // 
            this.degree.DataPropertyName = "degree";
            this.degree.HeaderText = "Degree";
            this.degree.Name = "degree";
            this.degree.ReadOnly = true;
            // 
            // bmdcregno
            // 
            this.bmdcregno.DataPropertyName = "bmdcregno";
            this.bmdcregno.HeaderText = "Bmdcreg No";
            this.bmdcregno.Name = "bmdcregno";
            this.bmdcregno.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // divission
            // 
            this.divission.DataPropertyName = "divission";
            this.divission.HeaderText = "Divission";
            this.divission.Name = "divission";
            this.divission.ReadOnly = true;
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "District";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // thana
            // 
            this.thana.DataPropertyName = "thana";
            this.thana.HeaderText = "Thana";
            this.thana.Name = "thana";
            this.thana.ReadOnly = true;
            // 
            // BtnAccept
            // 
            this.BtnAccept.Location = new System.Drawing.Point(1014, 106);
            this.BtnAccept.Name = "BtnAccept";
            this.BtnAccept.Size = new System.Drawing.Size(75, 23);
            this.BtnAccept.TabIndex = 58;
            this.BtnAccept.Text = "Accept";
            this.BtnAccept.UseSelectable = true;
            this.BtnAccept.Click += new System.EventHandler(this.BtnAccept_Click);
            // 
            // BtnReject
            // 
            this.BtnReject.Location = new System.Drawing.Point(1095, 106);
            this.BtnReject.Name = "BtnReject";
            this.BtnReject.Size = new System.Drawing.Size(75, 23);
            this.BtnReject.TabIndex = 59;
            this.BtnReject.Text = "Reject";
            this.BtnReject.UseSelectable = true;
            this.BtnReject.Click += new System.EventHandler(this.BtnReject_Click);
            // 
            // DoctorRegReqToAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 602);
            this.Controls.Add(this.BtnReject);
            this.Controls.Add(this.BtnAccept);
            this.Controls.Add(this.GridDoctorsList);
            this.Controls.Add(this.bntBackAdminProfile);
            this.Name = "DoctorRegReqToAdmin";
            this.Text = "Doctor\'sRegistrationList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoctorRegReqToAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDoctorsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton bntBackAdminProfile;
        private MetroFramework.Controls.MetroGrid GridDoctorsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn bmdcregno;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
        private MetroFramework.Controls.MetroButton BtnAccept;
        private MetroFramework.Controls.MetroButton BtnReject;
    }
}