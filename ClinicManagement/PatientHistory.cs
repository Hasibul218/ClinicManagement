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
    public partial class PatientHistory : MetroForm
    {
        Patient pa = new Patient();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public PatientHistory(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
            string sql = "select * from patienthistory where patientid='" + pa.Userid + "';";
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
            PatientProfile pp = new PatientProfile(pa);
            this.Visible = false;
            pp.Visible = true;
        }
    }
}
