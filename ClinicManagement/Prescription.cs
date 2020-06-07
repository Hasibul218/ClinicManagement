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
    public partial class Prescription : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataTable Dt { get; set; }

        private Clinic cl = new Clinic();
        private Doctor dr = new Doctor();
        private Patient pa = new Patient();
        public PrescriptionClass ps = new PrescriptionClass();

        private PatientRepo prepo = new PatientRepo();
        public Prescription(Doctor dr, Patient pa, Clinic cl)
        {
            InitializeComponent();
            this.dr = dr;
            this.pa = pa;
            this.cl = cl;
            string query1 = "select * from disease";
            Dt = DataAccess.GetDataTable(query1);
            comDisease.ValueMember = "did";
            comDisease.DisplayMember = "dname";
            comDisease.DataSource = Dt;

            string query2 = "select * from test";
            Dt = DataAccess.GetDataTable(query2);
            comTest.ValueMember = "tid";
            comTest.DisplayMember = "tname";
            comTest.DataSource = Dt;

            string query3 = "select * from clinic";
            Dt = DataAccess.GetDataTable(query3);
            comClinic.ValueMember = "userid";
            comClinic.DisplayMember = "username";
            comClinic.DataSource = Dt;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            //PatientWatingList pwl = new PatientWatingList(dr);
            this.Visible = false;
            //pwl.Visible = true;
        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            this.txtPatientName.Text = pa.Username;
            this.txtPatientId.Text = pa.Userid;
            this.txtPatientGender.Text = pa.Gender;
            this.txtPatientEmail.Text = pa.Email;
            this.txtDateOfBirth.Text = pa.DateOfBirth;
        }

        private void BtnPrescription_Click(object sender, EventArgs e)
        {
            ps.Symptom = this.txtSymptom.Text;
            ps.Diseases = this.comDisease.Text;
            ps.Test = this.comTest.Text;
            ps.Testclinicname = this.comClinic.Text;
            string sql = "select * from clinic where username='" + this.comClinic.Text+ "'";
           
            Ds = DataAccess.GetDataSet(sql);
            Clinic c = new Clinic(Ds);
            string s = c.Userid;

            ps.Testclinicid = s;
            ps.Report = this.txtReport.Text;
            ps.Medicines = this.txtMedicines.Text;

            prepo.AddPatientHistoryInfromation(pa, dr, cl, ps);

            MessageBox.Show("Successfully Prescived!");
            this.Visible = false;
        }
    }
}
