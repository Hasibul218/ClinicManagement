using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Repository;

namespace ClinicManagement
{
    public partial class TakeAppointment : MetroForm
    {
        private Patient pa;
        private DataSet Ds { get; set; }
        private Doctor dr = new Doctor();
        private Clinic cl = new Clinic();
        private PatientRepo prepo = new PatientRepo();
        public TakeAppointment(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
            //string sql = "select * from doctorschedule";
            //this.PopulateGridView(sql);
            //this.GrdDoctorSchedule.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GrdDoctorSchedule.AutoGenerateColumns = false;          //optional
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void BtnBackPaPage_Click(object sender, EventArgs e)
        {
            PatientProfile pp = new PatientProfile(pa);
            this.Visible = false;
            pp.Visible = true;
        }

        private void TxtDocIdSearch_Click(object sender, EventArgs e)
        {

        }

        private void TxtDocNameSeach_Click(object sender, EventArgs e)
        {

        }

        private void BtnSearchId_Click(object sender, EventArgs e)
        {
            string sql = "select * from doctorschedule where doctorid like '" + this.txtDocIdSearch.Text + "';";
            this.PopulateGridView(sql);
            this.GrdDoctorSchedule.DataSource = this.Ds.Tables[0];
            txtDocIdSearch.Clear();
        }

        private void TxtDocNameSeach_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from doctorschedule where doctorname like '" + this.txtDocNameSeach.Text + "%';";
            this.PopulateGridView(sql);
            this.GrdDoctorSchedule.DataSource = this.Ds.Tables[0];
        }

        private void BtnSendRequest_Click(object sender, EventArgs e)
        {
            string un = this.GrdDoctorSchedule.CurrentRow.Cells["doctorname"].Value.ToString();
            MessageBox.Show("Do you want take an appointment to" + un + "?");
            dr.Userid = this.GrdDoctorSchedule.CurrentRow.Cells["doctorid"].Value.ToString();
            dr.Date = this.GrdDoctorSchedule.CurrentRow.Cells["date"].Value.ToString();
            dr.Time = this.GrdDoctorSchedule.CurrentRow.Cells["time"].Value.ToString();
            cl.Userid = this.GrdDoctorSchedule.CurrentRow.Cells["clinicid"].Value.ToString();
            cl.Username = this.GrdDoctorSchedule.CurrentRow.Cells["clinicname"].Value.ToString();
            cl.Divission = this.GrdDoctorSchedule.CurrentRow.Cells["divission"].Value.ToString();
            cl.District = this.GrdDoctorSchedule.CurrentRow.Cells["district"].Value.ToString();
            cl.Thana = this.GrdDoctorSchedule.CurrentRow.Cells["thana"].Value.ToString();

            prepo.AddtempReqAppoDocInfromation(pa, dr, cl);
        }
    }
}
