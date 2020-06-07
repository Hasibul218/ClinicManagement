namespace ClinicManagement
{
    partial class PatientWatingList
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
            this.BtnBack = new MetroFramework.Controls.MetroButton();
            this.GirdPaWaitinList = new MetroFramework.Controls.MetroGrid();
            this.patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientgender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GirdPaWaitinList)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(201, 29);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseSelectable = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // GirdPaWaitinList
            // 
            this.GirdPaWaitinList.AllowUserToAddRows = false;
            this.GirdPaWaitinList.AllowUserToDeleteRows = false;
            this.GirdPaWaitinList.AllowUserToResizeRows = false;
            this.GirdPaWaitinList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GirdPaWaitinList.BackgroundColor = System.Drawing.Color.Silver;
            this.GirdPaWaitinList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GirdPaWaitinList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GirdPaWaitinList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GirdPaWaitinList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GirdPaWaitinList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GirdPaWaitinList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientid,
            this.patientname,
            this.patientgender,
            this.patientemail,
            this.dateOfBirth,
            this.date,
            this.time,
            this.clinicid,
            this.clinicname,
            this.divission,
            this.district,
            this.thana,
            this.doctorid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GirdPaWaitinList.DefaultCellStyle = dataGridViewCellStyle2;
            this.GirdPaWaitinList.EnableHeadersVisualStyles = false;
            this.GirdPaWaitinList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GirdPaWaitinList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GirdPaWaitinList.Location = new System.Drawing.Point(49, 100);
            this.GirdPaWaitinList.Name = "GirdPaWaitinList";
            this.GirdPaWaitinList.ReadOnly = true;
            this.GirdPaWaitinList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GirdPaWaitinList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GirdPaWaitinList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GirdPaWaitinList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GirdPaWaitinList.Size = new System.Drawing.Size(1164, 452);
            this.GirdPaWaitinList.TabIndex = 1;
            this.GirdPaWaitinList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GirdPaWaitinList_CellDoubleClick);
            // 
            // patientid
            // 
            this.patientid.DataPropertyName = "patientid";
            this.patientid.HeaderText = "Patient Id";
            this.patientid.Name = "patientid";
            this.patientid.ReadOnly = true;
            // 
            // patientname
            // 
            this.patientname.DataPropertyName = "patientname";
            this.patientname.HeaderText = "Patient Name";
            this.patientname.Name = "patientname";
            this.patientname.ReadOnly = true;
            // 
            // patientgender
            // 
            this.patientgender.DataPropertyName = "patientgender";
            this.patientgender.HeaderText = "Patient Gender";
            this.patientgender.Name = "patientgender";
            this.patientgender.ReadOnly = true;
            // 
            // patientemail
            // 
            this.patientemail.DataPropertyName = "patientemail";
            this.patientemail.HeaderText = "Patient Email";
            this.patientemail.Name = "patientemail";
            this.patientemail.ReadOnly = true;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.DataPropertyName = "dateOfBirth";
            this.dateOfBirth.HeaderText = "Date Of Birth";
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // clinicid
            // 
            this.clinicid.DataPropertyName = "clinicid";
            this.clinicid.HeaderText = "Clinic Id";
            this.clinicid.Name = "clinicid";
            this.clinicid.ReadOnly = true;
            // 
            // clinicname
            // 
            this.clinicname.DataPropertyName = "clinicname";
            this.clinicname.HeaderText = "Clinic Name";
            this.clinicname.Name = "clinicname";
            this.clinicname.ReadOnly = true;
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
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor Id";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Visible = false;
            // 
            // PatientWatingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 615);
            this.Controls.Add(this.GirdPaWaitinList);
            this.Controls.Add(this.BtnBack);
            this.Name = "PatientWatingList";
            this.Text = "PatientWatingList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GirdPaWaitinList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnBack;
        private MetroFramework.Controls.MetroGrid GirdPaWaitinList;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientname;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientgender;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicname;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
    }
}