
namespace ClinicManagement
{
    partial class PatientsRecords
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
            this.GridPatientHistory = new MetroFramework.Controls.MetroGrid();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testclinicname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testclinicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.report = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GridPatientHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(110, 29);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseSelectable = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // GridPatientHistory
            // 
            this.GridPatientHistory.AllowUserToAddRows = false;
            this.GridPatientHistory.AllowUserToDeleteRows = false;
            this.GridPatientHistory.AllowUserToResizeRows = false;
            this.GridPatientHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridPatientHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPatientHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridPatientHistory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GridPatientHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPatientHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GridPatientHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridPatientHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorid,
            this.date,
            this.time,
            this.patientid,
            this.symptom,
            this.disease,
            this.test,
            this.testclinicname,
            this.testclinicid,
            this.report,
            this.medicines,
            this.clinicname,
            this.clinicid,
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
            this.GridPatientHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.GridPatientHistory.Enabled = false;
            this.GridPatientHistory.EnableHeadersVisualStyles = false;
            this.GridPatientHistory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPatientHistory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GridPatientHistory.Location = new System.Drawing.Point(23, 76);
            this.GridPatientHistory.Name = "GridPatientHistory";
            this.GridPatientHistory.ReadOnly = true;
            this.GridPatientHistory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridPatientHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GridPatientHistory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GridPatientHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridPatientHistory.Size = new System.Drawing.Size(1227, 499);
            this.GridPatientHistory.TabIndex = 1;
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor Id";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            this.doctorid.Visible = false;
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
            // patientid
            // 
            this.patientid.DataPropertyName = "patientid";
            this.patientid.HeaderText = "Patient Id";
            this.patientid.Name = "patientid";
            this.patientid.ReadOnly = true;
            // 
            // symptom
            // 
            this.symptom.DataPropertyName = "symptom";
            this.symptom.HeaderText = "Sympthom";
            this.symptom.Name = "symptom";
            this.symptom.ReadOnly = true;
            // 
            // disease
            // 
            this.disease.DataPropertyName = "disease";
            this.disease.HeaderText = "Disease";
            this.disease.Name = "disease";
            this.disease.ReadOnly = true;
            // 
            // test
            // 
            this.test.DataPropertyName = "test";
            this.test.HeaderText = "Test";
            this.test.Name = "test";
            this.test.ReadOnly = true;
            // 
            // testclinicname
            // 
            this.testclinicname.DataPropertyName = "testclinicname";
            this.testclinicname.HeaderText = "Test Clinic Name";
            this.testclinicname.Name = "testclinicname";
            this.testclinicname.ReadOnly = true;
            // 
            // testclinicid
            // 
            this.testclinicid.DataPropertyName = "testclinicid";
            this.testclinicid.HeaderText = "Test Clinic Id";
            this.testclinicid.Name = "testclinicid";
            this.testclinicid.ReadOnly = true;
            // 
            // report
            // 
            this.report.DataPropertyName = "report";
            this.report.HeaderText = "Report";
            this.report.Name = "report";
            this.report.ReadOnly = true;
            // 
            // medicines
            // 
            this.medicines.DataPropertyName = "medicines";
            this.medicines.HeaderText = "Medicines";
            this.medicines.Name = "medicines";
            this.medicines.ReadOnly = true;
            // 
            // clinicname
            // 
            this.clinicname.DataPropertyName = "clinicname";
            this.clinicname.HeaderText = "Clinic Name";
            this.clinicname.Name = "clinicname";
            this.clinicname.ReadOnly = true;
            // 
            // clinicid
            // 
            this.clinicid.DataPropertyName = "clinicid";
            this.clinicid.HeaderText = "Clinic Id";
            this.clinicid.Name = "clinicid";
            this.clinicid.ReadOnly = true;
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
            // PatientsRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 598);
            this.Controls.Add(this.GridPatientHistory);
            this.Controls.Add(this.BtnBack);
            this.Name = "PatientsRecords";
            this.Text = "History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GridPatientHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton BtnBack;
        private MetroFramework.Controls.MetroGrid GridPatientHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientid;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptom;
        private System.Windows.Forms.DataGridViewTextBoxColumn disease;
        private System.Windows.Forms.DataGridViewTextBoxColumn test;
        private System.Windows.Forms.DataGridViewTextBoxColumn testclinicname;
        private System.Windows.Forms.DataGridViewTextBoxColumn testclinicid;
        private System.Windows.Forms.DataGridViewTextBoxColumn report;
        private System.Windows.Forms.DataGridViewTextBoxColumn medicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicid;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
    }
}