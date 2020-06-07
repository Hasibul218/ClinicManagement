namespace ClinicManagement
{
    partial class TakeAppointment
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
            this.GrdDoctorSchedule = new MetroFramework.Controls.MetroGrid();
            this.doctorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctoremail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clinicname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.divission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBackPaPage = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.BtnSearchId = new MetroFramework.Controls.MetroButton();
            this.txtDocNameSeach = new MetroFramework.Controls.MetroTextBox();
            this.txtDocIdSearch = new MetroFramework.Controls.MetroTextBox();
            this.htmlLabel3 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel2 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.BtnSendRequest = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrdDoctorSchedule)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrdDoctorSchedule
            // 
            this.GrdDoctorSchedule.AllowUserToAddRows = false;
            this.GrdDoctorSchedule.AllowUserToDeleteRows = false;
            this.GrdDoctorSchedule.AllowUserToResizeRows = false;
            this.GrdDoctorSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrdDoctorSchedule.BackgroundColor = System.Drawing.Color.Gray;
            this.GrdDoctorSchedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GrdDoctorSchedule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GrdDoctorSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDoctorSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GrdDoctorSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdDoctorSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorid,
            this.doctorname,
            this.date,
            this.time,
            this.specialty,
            this.doctoremail,
            this.clinicid,
            this.clinicname,
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
            this.GrdDoctorSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            this.GrdDoctorSchedule.EnableHeadersVisualStyles = false;
            this.GrdDoctorSchedule.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrdDoctorSchedule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrdDoctorSchedule.Location = new System.Drawing.Point(450, 63);
            this.GrdDoctorSchedule.Name = "GrdDoctorSchedule";
            this.GrdDoctorSchedule.ReadOnly = true;
            this.GrdDoctorSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GrdDoctorSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.GrdDoctorSchedule.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.GrdDoctorSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrdDoctorSchedule.Size = new System.Drawing.Size(816, 467);
            this.GrdDoctorSchedule.TabIndex = 0;
            // 
            // doctorid
            // 
            this.doctorid.DataPropertyName = "doctorid";
            this.doctorid.HeaderText = "Doctor ID";
            this.doctorid.Name = "doctorid";
            this.doctorid.ReadOnly = true;
            // 
            // doctorname
            // 
            this.doctorname.DataPropertyName = "doctorname";
            this.doctorname.HeaderText = "Doctor Name";
            this.doctorname.Name = "doctorname";
            this.doctorname.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Sit Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Sit Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // specialty
            // 
            this.specialty.DataPropertyName = "specialty";
            this.specialty.HeaderText = "Specialty";
            this.specialty.Name = "specialty";
            this.specialty.ReadOnly = true;
            // 
            // doctoremail
            // 
            this.doctoremail.DataPropertyName = "doctoremail";
            this.doctoremail.HeaderText = "Doctor Email";
            this.doctoremail.Name = "doctoremail";
            this.doctoremail.ReadOnly = true;
            // 
            // clinicid
            // 
            this.clinicid.DataPropertyName = "clinicid";
            this.clinicid.HeaderText = "Clinic ID";
            this.clinicid.Name = "clinicid";
            this.clinicid.ReadOnly = true;
            // 
            // clinicname
            // 
            this.clinicname.DataPropertyName = "clinicname";
            this.clinicname.HeaderText = "Sit Clinic";
            this.clinicname.Name = "clinicname";
            this.clinicname.ReadOnly = true;
            // 
            // divission
            // 
            this.divission.DataPropertyName = "divission";
            this.divission.HeaderText = "Clinic Divission";
            this.divission.Name = "divission";
            this.divission.ReadOnly = true;
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "Clinic District";
            this.district.Name = "district";
            this.district.ReadOnly = true;
            // 
            // thana
            // 
            this.thana.DataPropertyName = "thana";
            this.thana.HeaderText = "Clinic Thana";
            this.thana.Name = "thana";
            this.thana.ReadOnly = true;
            // 
            // BtnBackPaPage
            // 
            this.BtnBackPaPage.Location = new System.Drawing.Point(233, 34);
            this.BtnBackPaPage.Name = "BtnBackPaPage";
            this.BtnBackPaPage.Size = new System.Drawing.Size(75, 23);
            this.BtnBackPaPage.TabIndex = 1;
            this.BtnBackPaPage.Text = "Back";
            this.BtnBackPaPage.UseSelectable = true;
            this.BtnBackPaPage.Click += new System.EventHandler(this.BtnBackPaPage_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.BtnSearchId);
            this.metroPanel1.Controls.Add(this.txtDocNameSeach);
            this.metroPanel1.Controls.Add(this.txtDocIdSearch);
            this.metroPanel1.Controls.Add(this.htmlLabel3);
            this.metroPanel1.Controls.Add(this.htmlLabel2);
            this.metroPanel1.Controls.Add(this.htmlLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(421, 467);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // BtnSearchId
            // 
            this.BtnSearchId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnSearchId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSearchId.Location = new System.Drawing.Point(43, 152);
            this.BtnSearchId.Name = "BtnSearchId";
            this.BtnSearchId.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchId.TabIndex = 7;
            this.BtnSearchId.Text = "Search";
            this.BtnSearchId.UseSelectable = true;
            this.BtnSearchId.Click += new System.EventHandler(this.BtnSearchId_Click);
            // 
            // txtDocNameSeach
            // 
            // 
            // 
            // 
            this.txtDocNameSeach.CustomButton.Image = null;
            this.txtDocNameSeach.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtDocNameSeach.CustomButton.Name = "";
            this.txtDocNameSeach.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocNameSeach.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocNameSeach.CustomButton.TabIndex = 1;
            this.txtDocNameSeach.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocNameSeach.CustomButton.UseSelectable = true;
            this.txtDocNameSeach.CustomButton.Visible = false;
            this.txtDocNameSeach.Lines = new string[0];
            this.txtDocNameSeach.Location = new System.Drawing.Point(250, 110);
            this.txtDocNameSeach.MaxLength = 32767;
            this.txtDocNameSeach.Name = "txtDocNameSeach";
            this.txtDocNameSeach.PasswordChar = '\0';
            this.txtDocNameSeach.PromptText = "Input Name";
            this.txtDocNameSeach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocNameSeach.SelectedText = "";
            this.txtDocNameSeach.SelectionLength = 0;
            this.txtDocNameSeach.SelectionStart = 0;
            this.txtDocNameSeach.ShortcutsEnabled = true;
            this.txtDocNameSeach.Size = new System.Drawing.Size(121, 23);
            this.txtDocNameSeach.TabIndex = 6;
            this.txtDocNameSeach.UseSelectable = true;
            this.txtDocNameSeach.WaterMark = "Input Name";
            this.txtDocNameSeach.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocNameSeach.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocNameSeach.TextChanged += new System.EventHandler(this.TxtDocNameSeach_TextChanged);
            this.txtDocNameSeach.Click += new System.EventHandler(this.TxtDocNameSeach_Click);
            // 
            // txtDocIdSearch
            // 
            this.txtDocIdSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.txtDocIdSearch.CustomButton.Image = null;
            this.txtDocIdSearch.CustomButton.Location = new System.Drawing.Point(85, 1);
            this.txtDocIdSearch.CustomButton.Name = "";
            this.txtDocIdSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDocIdSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocIdSearch.CustomButton.TabIndex = 1;
            this.txtDocIdSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocIdSearch.CustomButton.UseSelectable = true;
            this.txtDocIdSearch.CustomButton.Visible = false;
            this.txtDocIdSearch.Lines = new string[0];
            this.txtDocIdSearch.Location = new System.Drawing.Point(32, 111);
            this.txtDocIdSearch.MaxLength = 32767;
            this.txtDocIdSearch.Name = "txtDocIdSearch";
            this.txtDocIdSearch.PasswordChar = '\0';
            this.txtDocIdSearch.PromptText = "Input Id";
            this.txtDocIdSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocIdSearch.SelectedText = "";
            this.txtDocIdSearch.SelectionLength = 0;
            this.txtDocIdSearch.SelectionStart = 0;
            this.txtDocIdSearch.ShortcutsEnabled = true;
            this.txtDocIdSearch.Size = new System.Drawing.Size(107, 23);
            this.txtDocIdSearch.TabIndex = 5;
            this.txtDocIdSearch.UseSelectable = true;
            this.txtDocIdSearch.WaterMark = "Input Id";
            this.txtDocIdSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocIdSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocIdSearch.Click += new System.EventHandler(this.TxtDocIdSearch_Click);
            // 
            // htmlLabel3
            // 
            this.htmlLabel3.AutoScroll = true;
            this.htmlLabel3.AutoScrollMinSize = new System.Drawing.Size(75, 23);
            this.htmlLabel3.AutoSize = false;
            this.htmlLabel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.htmlLabel3.Location = new System.Drawing.Point(275, 72);
            this.htmlLabel3.Name = "htmlLabel3";
            this.htmlLabel3.Size = new System.Drawing.Size(75, 23);
            this.htmlLabel3.TabIndex = 4;
            this.htmlLabel3.Text = "Doctor Name";
            // 
            // htmlLabel2
            // 
            this.htmlLabel2.AutoScroll = true;
            this.htmlLabel2.AutoScrollMinSize = new System.Drawing.Size(57, 23);
            this.htmlLabel2.AutoSize = false;
            this.htmlLabel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.htmlLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.htmlLabel2.Location = new System.Drawing.Point(57, 72);
            this.htmlLabel2.Name = "htmlLabel2";
            this.htmlLabel2.Size = new System.Drawing.Size(61, 23);
            this.htmlLabel2.TabIndex = 3;
            this.htmlLabel2.Text = "Doctor ID";
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(61, 23);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.htmlLabel1.Location = new System.Drawing.Point(166, 43);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(64, 23);
            this.htmlLabel1.TabIndex = 2;
            this.htmlLabel1.Text = "Search By";
            // 
            // BtnSendRequest
            // 
            this.BtnSendRequest.Location = new System.Drawing.Point(1148, 532);
            this.BtnSendRequest.Name = "BtnSendRequest";
            this.BtnSendRequest.Size = new System.Drawing.Size(118, 23);
            this.BtnSendRequest.TabIndex = 3;
            this.BtnSendRequest.Text = "Send Request";
            this.BtnSendRequest.UseSelectable = true;
            this.BtnSendRequest.Click += new System.EventHandler(this.BtnSendRequest_Click);
            // 
            // TakeAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 578);
            this.Controls.Add(this.BtnSendRequest);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BtnBackPaPage);
            this.Controls.Add(this.GrdDoctorSchedule);
            this.Name = "TakeAppointment";
            this.Text = "Take Appointment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.GrdDoctorSchedule)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid GrdDoctorSchedule;
        private MetroFramework.Controls.MetroButton BtnBackPaPage;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel2;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel3;
        private MetroFramework.Controls.MetroTextBox txtDocNameSeach;
        private MetroFramework.Controls.MetroTextBox txtDocIdSearch;
        private MetroFramework.Controls.MetroButton BtnSearchId;
        private MetroFramework.Controls.MetroButton BtnSendRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorname;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialty;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctoremail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clinicname;
        private System.Windows.Forms.DataGridViewTextBoxColumn divission;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn thana;
    }
}