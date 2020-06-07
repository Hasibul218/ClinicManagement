using ClinicManagement.Data;
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
using ClinicManagement.Entities;
using ClinicManagement.Repository;

namespace ClinicManagement
{
    public partial class DoctorSetSchedule : MetroForm
    {
        private DataSet Ds { get; set; }
        private DataTable dt { get; set; }
        DoctorRepo drepo = new DoctorRepo();
        Clinic ci = new Clinic();
        Doctor dr = new Doctor();
        public DoctorSetSchedule(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
            //gridview show
            //string sql = @"insert into doctorschedule(doctorid,doctorname,date,time,specialty,doctoremail,clinicname,clinicid,divission,district,thana) values('"+dr.Userid+"','"+dr.Username+"','"+Dtpiker+"','"+comTime+"','"+dr.Specialty+"','"+dr.Email+"','"+comClinicName+"','"+ci.Userid+"','"+txtDivission+"','"+txtDistrict+"','"+txtThana+"');";
            string sql = "select * from doctorschedule where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sql);
            this.GrdSetSchedule.DataSource = this.Ds.Tables[0];

            //clinic name load
            string query1 = "select * from ClinicManagement.dbo.clinic";
            dt = DataAccess.GetDataTable(query1);
            comClinicName.ValueMember = "username";
            comClinicName.DisplayMember = "username";
            comClinicName.DataSource = dt;
        }
        void PopulateGridView(string sql)
        {
            this.GrdSetSchedule.AutoGenerateColumns = true;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void ComDivission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComClinicName_SelectedIndexChanged(object sender, EventArgs e)
        {


            //string a = this.comClinicName.Text;
            string query1 = "select * from ClinicManagement.dbo.clinic where username='" + this.comClinicName.Text + "'";
            Ds = DataAccess.GetDataSet(query1);
            ci = new Clinic(Ds);
            //string b = ci.Divission;
            //string c = ci.District;
            //string d = ci.Thana;
            this.txtDivission.Text = ci.Divission;
            this.txtDistrict.Text = ci.District;
            this.txtThana.Text = ci.Thana;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            dr.Time = this.comTime.Text;
            dr.Date = this.Dtpiker.Text;
            drepo.AddDoctorScheduleInfromation(dr, ci);

            string sqll = "select * from doctorschedule where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sqll);
            this.GrdSetSchedule.DataSource = this.Ds.Tables[0];
        }

        private void BtnBackDocPro_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile(dr);
            this.Visible = false;
            dp.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string id = this.GrdSetSchedule.CurrentRow.Cells["id"].Value.ToString();
            string sql = "delete from doctorschedule where id='" + id + "'";
            DataAccess.ExecuteQuery(sql);
            string sql1 = "select * from doctorschedule where doctorid = '" + dr.Userid + "';";
            this.PopulateGridView(sql1);
            this.GrdSetSchedule.DataSource = this.Ds.Tables[0];
        }
    }
}
