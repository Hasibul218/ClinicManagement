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
using ClinicManagement.Data;

namespace ClinicManagement
{
    public partial class PatientEditProfile : MetroForm
    {
        Patient pa;
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }
        public PatientEditProfile(Patient pa)
        {
            InitializeComponent();
            this.pa = pa;
            txtUserid.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtConPassword.Enabled = false;
            txtGender.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtEmail.Enabled = false;
            txtDateOfBirth.Enabled = false;
            txtDivission.Enabled = false;
            txtDistrict.Enabled = false;
            txtThana.Enabled = false;
            btnSave.Visible = false;
        }

        private void BtnBackProfile_Click(object sender, EventArgs e)
        {
            PatientProfile pp = new PatientProfile(pa);
            this.Visible = false;
            pp.Visible = true;
        }

        private void PatientEditProfile_Load(object sender, EventArgs e)
        {
            string sql = "select * from patient where userid='" + pa.Userid + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from login where userid='" + pa.Userid + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            User u = new User(Ds1);
            Patient p = new Patient(Ds);
            txtUserid.Text = p.Userid;
            txtUserName.Text = p.Username;
            txtPassword.Text = u.Password;
            txtConPassword.Text = u.Password;
            txtGender.Text = p.Gender;
            txtPhoneNumber.Text = p.Phone;
            txtEmail.Text = p.Email;
            txtDateOfBirth.Text = p.DateOfBirth;
            txtDivission.Text = p.Divission;
            txtDistrict.Text = p.District;
            txtThana.Text = p.Thana;


        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtConPassword.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtEmail.Enabled = true;
            txtDateOfBirth.Enabled = true;
            txtDivission.Enabled = true;
            txtDistrict.Enabled = true;
            txtThana.Enabled = true;
            btnSave.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update Your Data", "Do you want to update your data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConPassword.Text) || string.IsNullOrEmpty(txtPhoneNumber.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDateOfBirth.Text) || string.IsNullOrEmpty(txtDivission.Text) || string.IsNullOrEmpty(txtDivission.Text) || string.IsNullOrEmpty(txtDistrict.Text) || string.IsNullOrEmpty(txtThana.Text))
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                    {
                        string sql = @"update patient set username='" + this.txtUserName.Text + @"',
                        gender='" + this.txtGender.Text + @"',
                        phone='" + this.txtPhoneNumber.Text + @"',
                        email='" + this.txtEmail.Text + @"',
                        dateOfBirth='" + this.txtDateOfBirth.Text + @"',
                        divission= '" + this.txtDivission.Text + @"',
                        district ='" + this.txtDistrict.Text + @"',
                        thana='" + this.txtThana.Text + @"'
                        
                        where userid='" + pa.Userid + "';";
                        DataAccess.ExecuteQuery(sql);
                        string sqll = @"update login set password='" + this.txtPassword.Text + @"' where userid='" + pa.Userid + "';";
                        DataAccess.ExecuteQuery(sqll);
                        MessageBox.Show("Data has been updated");
                    }
                    else
                    {
                        MessageBox.Show("Password & Confirm Password Doesn't match.");
                    }

                }


                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                txtConPassword.Enabled = false;
                txtPhoneNumber.Enabled = false;
                txtEmail.Enabled = false;
                txtDateOfBirth.Enabled = false;
                txtDivission.Enabled = false;
                txtDistrict.Enabled = false;
                txtThana.Enabled = false;
                btnSave.Visible = false;
            }
            else { }
        } 
    }
}
