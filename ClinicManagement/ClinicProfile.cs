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
    public partial class ClinicProfile : MetroForm
    {
        private DataSet Ds { get; set; }
        private Clinic ci;
       // private User u;
        public ClinicProfile(Clinic ci)
        {
            InitializeComponent();
            this.ci = ci;
           // this.u = u;
        }

        private void ClinicProfile_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogoutClinic_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Visible = false;
            lg.Visible = true;
        }

        private void BtnEditProfile_Click(object sender, EventArgs e)
        {
            ClinicEditProfile ce = new ClinicEditProfile(ci);
            this.Visible = false;
            ce.Visible = true;
        }
    }
}
