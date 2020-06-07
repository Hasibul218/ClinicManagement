using ClinicManagement.Entities;
using ClinicManagement.Data;
using MetroFramework.Forms;
using ClinicManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class RequestedAppointment : MetroForm
    {
        private Doctor dr = new Doctor();
        private Patient pa = new Patient();
        private Clinic cl = new Clinic();
        private DataSet Ds { get; set; }
        private DoctorRepo drepo = new DoctorRepo();

        public RequestedAppointment(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
            string sql = "select * from tempReqAppoDoc where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sql);
            this.GridReqAppo.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridReqAppo.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile(dr);
            this.Visible = false;
            dp.Visible = true;
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            string sql = this.GridReqAppo.CurrentRow.Cells["patientname"].Value.ToString();
            MessageBox.Show("Do you Want to Delete " + sql + "?");
            string id = this.GridReqAppo.CurrentRow.Cells["id"].Value.ToString();
            string sqll = "delete from tempReqAppoDoc where id='" + id + "';";
            DataAccess.ExecuteQuery(sqll);
            string sql1 = "select * from tempReqAppoDoc where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sql1);
            this.GridReqAppo.DataSource = this.Ds.Tables[0];
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string un = this.GridReqAppo.CurrentRow.Cells["patientname"].Value.ToString();
            MessageBox.Show("Do you want take an add to" + un + "?");
            pa.Userid = this.GridReqAppo.CurrentRow.Cells["patientid"].Value.ToString();
            pa.Username = this.GridReqAppo.CurrentRow.Cells["patientname"].Value.ToString();
            pa.Gender = this.GridReqAppo.CurrentRow.Cells["patientgender"].Value.ToString();
            pa.Email = this.GridReqAppo.CurrentRow.Cells["patientemail"].Value.ToString();
            pa.DateOfBirth = this.GridReqAppo.CurrentRow.Cells["dateOfBirth"].Value.ToString();
            dr.Userid = this.GridReqAppo.CurrentRow.Cells["doctorid"].Value.ToString();
            dr.Date = this.GridReqAppo.CurrentRow.Cells["date"].Value.ToString();
            dr.Time = this.GridReqAppo.CurrentRow.Cells["time"].Value.ToString();
            cl.Userid = this.GridReqAppo.CurrentRow.Cells["clinicid"].Value.ToString();
            cl.Username = this.GridReqAppo.CurrentRow.Cells["clinicname"].Value.ToString();
            cl.Divission = this.GridReqAppo.CurrentRow.Cells["divission"].Value.ToString();
            cl.District = this.GridReqAppo.CurrentRow.Cells["district"].Value.ToString();
            cl.Thana = this.GridReqAppo.CurrentRow.Cells["thana"].Value.ToString();

            drepo.AddPatientWatingListInfromation(pa, dr, cl);

            ////sending patientwaitindata data
            string unn = this.GridReqAppo.CurrentRow.Cells["id"].Value.ToString();
            string buser = "delete from tempReqAppoDoc where id='" + unn + "'";
            DataAccess.ExecuteQuery(buser);

            ////calling the gridview again after delelting
            string sql1 = "select * from tempReqAppoDoc where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sql1);
            this.GridReqAppo.DataSource = this.Ds.Tables[0];
        }
    }
}
