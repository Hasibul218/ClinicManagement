using ClinicManagement.Data;
using ClinicManagement.Entities;
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
    public partial class PatientsRecords : MetroForm
    {
        Doctor dr = new Doctor();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PatientsRecords(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
            string sql = "select * from patienthistory where doctorid='" + dr.Userid + "';";
            this.PopulateGridView(sql);
            this.GridPatientHistory.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridPatientHistory.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            DoctorProfile pp = new DoctorProfile(dr);
            this.Visible = false;
            pp.Visible = true;
        }
    }
}

