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
    public partial class ClinicEditProfile : MetroForm
    {
        Clinic ci;
        
        DataSet Ds { get; set; }
        DataSet Ds1 { get; set; }


        public ClinicEditProfile(Clinic ci)
        {
            InitializeComponent();
            this.ci = ci;

            txtName.Enabled = false;
            txtPassword.Enabled = false;
            txtConPassword.Enabled = false;
            txtPhone.Enabled = false;
            btnSave.Visible = false;

            string sql = "select * from login where userid='" + ci.Userid + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            User u = new User(Ds);

            txtUserId.Text = ci.Userid;
            txtName.Text = ci.Username;
            txtPassword.Text = u.Password;
            txtConPassword.Text = u.Password;
            txtPhone.Text = ci.Phone;
            txtDivission.Text = ci.Divission;
            txtDistrict.Text = ci.District;
            txtThana.Text = ci.Thana;

        }
       
        private void BntBackClinicHome_Click(object sender, EventArgs e)
        {
            ClinicProfile cp = new ClinicProfile(ci);
            this.Visible = false;
            cp.Visible = true;
        }

        private void ClinicEditProfile_Load(object sender, EventArgs e)
        {
            string sql = "select * from clinic where userid='" + ci.Userid + "'";
            this.Ds = DataAccess.GetDataSet(sql);
            string sqll = "select * from login where userid='" + ci.Userid + "'";
            this.Ds1 = DataAccess.GetDataSet(sqll);
            User u = new User(Ds1);
            Clinic cii = new Clinic(Ds);
            txtUserId.Text = cii.Userid;
            txtName.Text = cii.Username;
            txtPassword.Text = u.Password;
            //txtConPassword.Text = u.Password;
            txtPhone.Text = cii.Phone;
            txtDivission.Text = cii.Divission;
            txtDistrict.Text = cii.District;
            txtThana.Text = cii.Thana;

        }

        private void MetroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtName.Enabled = true;
            txtPassword.Enabled = true;
            txtConPassword.Enabled = true;
            txtPhone.Enabled = true;
            btnSave.Visible = true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Update Your Data","Do you want to update your data",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtDivission.Text) || string.IsNullOrEmpty(txtDistrict.Text) || string.IsNullOrEmpty(txtThana.Text) || string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Please Fill all the fields.");
                }
                else
                {
                    if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                    {
                        string sql = @"update clinic set username='" + this.txtName.Text + @"',
                        divission= '" + this.txtDivission.Text + @"',
                        district ='" + this.txtDistrict.Text + @"',
                        thana='" + this.txtThana.Text + @"',
                        phone='" + this.txtPhone.Text + @"'
                        where userid='" + ci.Userid + "';";
                        DataAccess.ExecuteQuery(sql);
                        string sqll = @"update login set password='" + this.txtPassword.Text + @"' where userid='" + ci.Userid + "';";
                        DataAccess.ExecuteQuery(sqll);


                        MessageBox.Show("Data has been updated");
                    }
                    else
                    {
                        MessageBox.Show("Password & Confirm Password Doesn't Match.");
                    }
                }
                txtName.Enabled = false;
                txtPassword.Enabled = false;
                txtConPassword.Enabled = false;
                txtPhone.Enabled = false;
                btnSave.Visible = false;
            }else
            { }
        }
    }
}
