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

namespace ClinicManagement
{
    public partial class PatientProfile : MetroForm
    {
        private DataSet Ds { get; set; }
        private Patient pa;
        public PatientProfile(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
        }

        private void BtnToDoctorSchedule_Click(object sender, EventArgs e)
        {
            TakeAppointment ta = new TakeAppointment(pa);
            this.Visible = false;
            ta.Visible = true;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            PatientEditProfile pe = new PatientEditProfile(pa);
            this.Visible = false;
            pe.Visible = true;
        }

        private void BtnLogoutPatient_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Visible = false;
            lg.Visible = true;
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            PatientHistory ph = new PatientHistory(pa);
            this.Visible = false;
            ph.Visible = true;
        }
    }
}
