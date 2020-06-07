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
using ClinicManagement.Data;
using MetroFramework.Forms;

namespace ClinicManagement
{
    public partial class AdminProfile : MetroForm
    {
        DataSet ds = new DataSet();

        private Admin ad;
        public AdminProfile() { }
        public AdminProfile(Admin ad)
        {
            InitializeComponent();
 
            this.ad = ad;
         
        }

        private void BtnPatientList_Click(object sender, EventArgs e)
        {
            AdminPatientList pg = new AdminPatientList(ad);
            this.Visible = false;
            pg.Visible = true;
        }

        private void BtnClinicList_Click(object sender, EventArgs e)
        {
            AdminClinicList ac = new AdminClinicList(ad);
            this.Visible = false;
            ac.Visible = true;
        }

        private void BtnDoctorList_Click(object sender, EventArgs e)
        {
            AdminDoctorsList add = new AdminDoctorsList(ad);
            this.Visible = false;
            add.Visible = true;
        }

        private void BtnRegistrationClinic_Click(object sender, EventArgs e)
        {
            ClinicRegistration cr = new ClinicRegistration(ad);
            this.Visible = false;
            cr.Visible = true;
        }

        private void BtnDoctorRequest_Click(object sender, EventArgs e)
        {
            DoctorRegReqToAdmin drra = new DoctorRegReqToAdmin(ad);
            this.Visible = false;
            drra.Visible = true;
        }
    }
}
