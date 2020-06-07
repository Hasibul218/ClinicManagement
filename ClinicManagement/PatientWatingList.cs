using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Repository;
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

namespace ClinicManagement
{
    public partial class PatientWatingList : MetroForm
    {

        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }

        private Clinic cl = new Clinic();
        private Doctor dr = new Doctor();
        private Patient pa = new Patient();

        private DoctorRepo drepo = new DoctorRepo();
        public PatientWatingList(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
            string sql = "select * from patientWatingList where doctorid='" + dr.Userid + "'";
            this.PopulateGridView(sql);
            this.GirdPaWaitinList.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GirdPaWaitinList.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile(dr);
            this.Visible = false;
            dp.Visible = true;
        }

        private void GirdPaWaitinList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pa.Userid = this.GirdPaWaitinList.CurrentRow.Cells["patientid"].Value.ToString();
            pa.Username = this.GirdPaWaitinList.CurrentRow.Cells["patientname"].Value.ToString();
            pa.Gender = this.GirdPaWaitinList.CurrentRow.Cells["patientgender"].Value.ToString();
            pa.Email = this.GirdPaWaitinList.CurrentRow.Cells["patientemail"].Value.ToString();
            pa.DateOfBirth = this.GirdPaWaitinList.CurrentRow.Cells["dateOfBirth"].Value.ToString();

            dr.Date = this.GirdPaWaitinList.CurrentRow.Cells["date"].Value.ToString();
            dr.Time = this.GirdPaWaitinList.CurrentRow.Cells["time"].Value.ToString();

            cl.Userid = this.GirdPaWaitinList.CurrentRow.Cells["clinicid"].Value.ToString();
            cl.Username = this.GirdPaWaitinList.CurrentRow.Cells["clinicname"].Value.ToString();
            cl.Divission = this.GirdPaWaitinList.CurrentRow.Cells["divission"].Value.ToString();
            cl.District = this.GirdPaWaitinList.CurrentRow.Cells["district"].Value.ToString();
            cl.Thana = this.GirdPaWaitinList.CurrentRow.Cells["thana"].Value.ToString();
            //drepo.AddDoctorInfromation(dr);



            /////////////////////
            Prescription p = new Prescription(dr, pa, cl);
            p.Visible = true;
        }
    }
}
