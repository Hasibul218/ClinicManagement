using MetroFramework.Forms;
using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Repository;
using System;
using System.Text.RegularExpressions;
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
    public partial class PatientRegistration : MetroForm
    {
        Patient pa = new Patient();
        User u = new User();
       

        RegistrationRepo prepo = new RegistrationRepo();
        UserRepository urepo = new UserRepository();
        AdminRepo arepo = new AdminRepo();
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Ds1 { get; set; }
        DataTable dt = new DataTable();
     
        private DataTable Dt { get; set; }
        public PatientRegistration()
        {
            InitializeComponent();
            string query = "select * from ClinicManagement.dbo.divission";
            Dt = DataAccess.GetDataTable(query);
            ComDivission.ValueMember = "divissionid";
            ComDivission.DisplayMember = "divissionname";
            ComDivission.DataSource = Dt;
            ComDistrict.Enabled = false;
            ComThana.Enabled = false;
        }

        private void Cbox_district_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComDistrict.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagement.dbo.thana where districtid='" + ComDistrict.SelectedValue.ToString() + "' ;";

                Dt = DataAccess.GetDataTable(query);
                ComThana.DataSource = Dt;
                ComThana.ValueMember = "thanaid";
                ComThana.DisplayMember = "thananame";
                ComThana.Enabled = true;

            }
        }

        private void Cbox_divission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComDivission.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagement.dbo.district where divissionid='" + ComDivission.SelectedValue.ToString() + "' ;";
                Dt = DataAccess.GetDataTable(query);
                ComDistrict.ValueMember = "districtid";
                ComDistrict.DisplayMember = "districtname";
                ComDistrict.DataSource = Dt;
                ComDistrict.Enabled = true;
                ComThana.Enabled = false;
            }
        }

        private void Btn_signup_Click(object sender, EventArgs e)
        {
            //cheak box cheak
            if (this.cbxAgreement.Checked)
            {
                //all field cheak
                if (string.IsNullOrEmpty(this.txtUserid.Text) || string.IsNullOrEmpty(this.txtUserName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtConPassword.Text) || string.IsNullOrEmpty(this.txtPhoneNumber.Text) || string.IsNullOrEmpty(this.txtEmail.Text))
                {
                    MessageBox.Show("Please fill up all fields");
                }
                else
                {

                        //password == confirmpassword
                        if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                    {

                        //email check
                        Regex emailch;
                        emailch = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                        if (!emailch.IsMatch(txtEmail.Text.Trim()))

                        {
                            MessageBox.Show("E-mail address format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtEmail.Focus();
                        }
                        else
                        {
                            //phone num validation
                            Regex re = new Regex("^[0-9]{11}$");
                            bool isValid = re.IsMatch(txtPhoneNumber.Text);
                            if ((!isValid))
                            {
                                MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else { 
                            //
                            string sql = "select userid from login where userid='" + this.txtUserid.Text + "';";
                            string sqll = "select userid from temploginReg where userid='" + this.txtUserid.Text + "';";
                            this.Ds = DataAccess.GetDataSet(sql);
                            this.Ds1 = DataAccess.GetDataSet(sqll);
                            if (this.Ds.Tables[0].Rows.Count == 1 || this.Ds1.Tables[0].Rows.Count == 1)
                            {
                                MessageBox.Show(this, "Your given user id already exist!");
                            }
                            else
                            {
                                string radio = null;
                                if (RadioMale.Checked)
                                {
                                    radio = RadioMale.Text;
                                }
                                if (RadioFemale.Checked)
                                {
                                    radio = RadioFemale.Text;
                                }

                                //Data Insert Part
                                pa.Userid = this.txtUserid.Text;
                                u.Userid = this.txtUserid.Text;
                                pa.Username = this.txtUserName.Text;
                                pa.Gender = radio;
                                u.Password = this.txtPassword.Text;
                                pa.Phone = this.txtPhoneNumber.Text;
                                pa.Email = this.txtEmail.Text;
                                pa.DateOfBirth = this.txtDateOfBirth.Text;
                                pa.Divission = this.ComDivission.Text;
                                pa.District = this.ComDistrict.Text;
                                pa.Thana = this.ComThana.Text;
                                u.Status = "patient";
                                arepo.AddUserInfromation(u);
                                prepo.AddPatientInfromation(pa);
                                Login l = new Login();
                                this.Visible = false;
                                l.Visible = true;
                            }
                            //
                        }
                        }

                        }
                        else
                        {
                            MessageBox.Show(this, "Password & Con. Password Doesn't Match.");
                        }
 
                }
            }
            else
            {
                MessageBox.Show(this, "Please check the agreement box to continue!");
            }
        }

        private void Txt_name_Click(object sender, EventArgs e)
        {

        }

        private void Txt_phone_Click(object sender, EventArgs e)
        {

        }

        private void BntBackHomePage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
            
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            //string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            //if (Regex.IsMatch(txtEmail.Text, pattern))
            //{
            //    //MessageBox.Show("")
            //}

            //else
            //{
            //    MessageBox.Show("Please provide valid email address.");
            //}
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            //Regex mRegxExpression;

            if (txtEmail.Text.Trim() != string.Empty)

            {

                //mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                //if (!mRegxExpression.IsMatch(txtEmail.Text.Trim()))

                //{

                //    MessageBox.Show("E-mail address format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //    txtEmail.Focus();

                //}

            }

            //Regex re = new Regex("^[0-9]{11}");
            //bool isValid = re.IsMatch(txtPhoneNumber.Text);
            //if (!isValid)
            //{
            //    MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
    

