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
    public partial class HomePage : MetroForm
    {

        public HomePage()
        {
            InitializeComponent();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            DoctorRegistration dr = new DoctorRegistration();
            this.Visible = false;
            dr.Visible = true;
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            PatientRegistration pr = new PatientRegistration();
            this.Visible = false;
            pr.Visible = true;
        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
 
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Visible = false;
            l.Visible = true;

            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit", "Are you sure want to exit ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else { }
        }
    }
}
