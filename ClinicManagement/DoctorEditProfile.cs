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
    public partial class DoctorEditProfile : MetroForm
    {
        Doctor dr;
        List<Panel> listPanel = new List<Panel>();
        int index;
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }
        public DoctorEditProfile(Doctor dr)
        {
            InitializeComponent();
            this.dr = dr;
            txtUserid.Enabled = false;
            txtUserName.Enabled = false;
            txtPassword.Enabled = false;
            txtConPassword.Enabled = false;
            txtEmail.Enabled = false;
            txtPhone.Enabled = false;
            txtDateofBirth.Enabled = false;
            txtGender.Enabled = false;
            txtSpecialty.Enabled = false;
            txtDegree.Enabled = false;
            txtDiscription.Enabled = false;
            txtDivission.Enabled = false;
            txtDistrict.Enabled = false;
            txtThana.Enabled = false;
            btnSave.Visible = false;
        }

        private void BntNext_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
            {
                listPanel[++index].BringToFront();
                //BtnSignUp.Enabled = true;
                //BtnNext.Enabled = false;

            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listPanel[--index].BringToFront();
                //BtnSignUp.Enabled = false;
                //BtnNext.Enabled = true;
            }
        }

        private void DoctorEditProfile_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel[index].BringToFront();

            string sql = "select * from doctor where userid='" + dr.Userid + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from login where userid='" + dr.Userid + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            User u = new User(Ds1);
            Doctor d = new Doctor(Ds);
            txtUserid.Text = d.Userid;
            txtUserName.Text = d.Username;
            txtPassword.Text = u.Password;
            txtConPassword.Text = u.Password;
            txtGender.Text = d.Gender;
            txtPhone.Text = d.Phone;
            txtEmail.Text = d.Email;
            txtDateofBirth.Text = d.DateOfBirth;
            txtSpecialty.Text = dr.Specialty;
            txtDegree.Text = dr.Degree;
            txtDiscription.Text = dr.Description;
            txtBmdcRegno.Text = dr.BMDCRegno;
            txtDivission.Text = d.Divission;
            txtDistrict.Text = d.District;
            txtThana.Text = d.Thana;
        }

        private void BtnBackDoctorProfile_Click(object sender, EventArgs e)
        {
            DoctorProfile dp = new DoctorProfile(dr);
            this.Visible = false;
            dp.Visible = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
            txtUserName.Enabled = true;
            txtPassword.Enabled = true;
            txtConPassword.Enabled = true;
            txtPhone.Enabled = true;
            txtDateofBirth.Enabled = true;
            txtSpecialty.Enabled = true;
            txtDegree.Enabled = true;
            txtDiscription.Enabled = true;
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

                if (string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConPassword.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtSpecialty.Text)||string.IsNullOrEmpty(txtDegree.Text)||string.IsNullOrEmpty(txtDiscription.Text) || string.IsNullOrEmpty(txtDateofBirth.Text) || string.IsNullOrEmpty(txtDivission.Text) || string.IsNullOrEmpty(txtDivission.Text) || string.IsNullOrEmpty(txtDistrict.Text) || string.IsNullOrEmpty(txtThana.Text))
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                    {
                        string sql = @"update doctor set username='" + this.txtUserName.Text + @"',
                        gender='" + this.txtGender.Text + @"',
                        phone='" + this.txtPhone.Text + @"',
                        email='" + this.txtEmail.Text + @"',
                        dateOfBirth='" + this.txtDateofBirth.Text + @"',
                        specialty='" + this.txtSpecialty.Text + @"',
                        degree='" + this.txtDegree.Text + @"',
                        bmdcregno='" + this.txtBmdcRegno.Text + @"',
                        description='" + this.txtDiscription.Text + @"',
                        divission= '" + this.txtDivission.Text + @"',
                        district ='" + this.txtDistrict.Text + @"',
                        thana='" + this.txtThana.Text + @"'
                        
                        where userid='" + dr.Userid + "';";
                        DataAccess.ExecuteQuery(sql);
                        string sqll = @"update login set password='" + this.txtPassword.Text + @"' where userid='" + dr.Userid + "';";
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
                txtPhone.Enabled = false;
                txtEmail.Enabled = false;
                txtDateofBirth.Enabled = false;
                txtDivission.Enabled = false;
                txtDistrict.Enabled = false;
                txtThana.Enabled = false;
                btnSave.Visible = false;

            }
            else { }
            }
    }
}
