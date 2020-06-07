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
using MetroFramework.Forms;

namespace ClinicManagement
{
    public partial class DoctorProfile : MetroForm
    {
        private DataSet Ds { get; set; }
        private Doctor dr;
        public DoctorProfile(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
        }

        private void BtnSetSchedule_Click(object sender, EventArgs e)
        {
            DoctorSetSchedule ds = new DoctorSetSchedule(dr);
            this.Visible = false;
            ds.Visible = true;
        }

        private void BtnReqAppointment_Click(object sender, EventArgs e)
        {
            RequestedAppointment dss = new RequestedAppointment(dr);
            this.Visible = false;
            dss.Visible = true;
        }

        private void BtnLogoutDoctor_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Visible = false;
            lg.Visible = true;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            DoctorEditProfile de = new DoctorEditProfile(dr);
            this.Visible = false;
            de.Visible = true;

        }

        private void BtnPaWaitingList_Click(object sender, EventArgs e)
        {
            PatientWatingList pw = new PatientWatingList(dr);
            this.Visible = false;
            pw.Visible = true;
        }

        private void BntPatientRecord_Click(object sender, EventArgs e)
        {
            PatientsRecords pr = new PatientsRecords(dr);
            this.Visible = false;
            pr.Visible = true;
        }
    }
}
