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
using System.Text.RegularExpressions;

namespace ClinicManagement
{
    public partial class ClinicRegistration : MetroForm
    {
        User u = new User();
        Clinic ci = new Clinic();

        UserRepository urepo = new UserRepository();
        RegistrationRepo crepo = new RegistrationRepo();
        AdminRepo arepo = new AdminRepo();


        private DataTable Dt { get; set; }
        private DataSet Ds { get; set; }
        private DataSet Ds1 { get; set; }

        DataTable dt = new DataTable();
        private DataAccess Da { get; set; }
        Admin ad = new Admin();


        public ClinicRegistration(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string query = "select * from ClinicManagement.dbo.divission";
            Dt = DataAccess.GetDataTable(query);
            comDivission.ValueMember = "divissionid";
            comDivission.DisplayMember = "divissionname";
            comDivission.DataSource = Dt;
            comDistrict.Enabled = false;
            comThana.Enabled = false;
        }

        private void ComDivission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDivission.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagement.dbo.district where divissionid='" + comDivission.SelectedValue.ToString() + "' ;";
                Dt = DataAccess.GetDataTable(query);
                comDistrict.ValueMember = "districtid";
                comDistrict.DisplayMember = "districtname";
                comDistrict.DataSource = Dt;
                comDistrict.Enabled = true;
                comThana.Enabled = false;
            }
        }

        private void ComDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comDistrict.SelectedValue.ToString() != null)
            {
                string query = "select * from ClinicManagement.dbo.thana where districtid='" + comDistrict.SelectedValue.ToString() + "' ;";

                Dt = DataAccess.GetDataTable(query);
                comThana.DataSource = Dt;
                comThana.ValueMember = "thanaid";
                comThana.DisplayMember = "thananame";
                comThana.Enabled = true;

            }
        }






        private void BtnAddclinic_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(this.txtUserId.Text) || string.IsNullOrEmpty(this.txtName.Text) || string.IsNullOrEmpty(this.txtPassword.Text) || string.IsNullOrEmpty(this.txtConPassword.Text) || string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Please fill up all fields.");
            }
            else
            {
                if (this.txtPassword.Text.Equals(this.txtConPassword.Text))
                {

                    //phone number validation
                    Regex re = new Regex("^[0-9]{11}$");
                    bool isValid = re.IsMatch(txtPhone.Text);
                    if ((!isValid))
                    {
                        MessageBox.Show("Phone number format is not correct.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //
                        string sql = "select userid from login where userid='" + this.txtUserId.Text + "';";
                        string sqll = "select userid from temploginReg where userid='" + this.txtUserId.Text + "';";
                        this.Ds = DataAccess.GetDataSet(sql);
                        this.Ds1 = DataAccess.GetDataSet(sqll);

                        if (this.Ds.Tables[0].Rows.Count == 1 || this.Ds1.Tables[0].Rows.Count == 1)
                        {
                            MessageBox.Show(this, "Your given user id already exist!");
                        }

                        else
                        {

                            u.Userid = this.txtUserId.Text;
                            u.Password = this.txtPassword.Text;
                            u.Status = "clinic";
                            ci.Userid = this.txtUserId.Text;
                            ci.Divission = this.comDivission.Text;
                            ci.District = this.comDistrict.Text;
                            ci.Thana = this.comThana.Text;
                            ci.Username = this.txtName.Text;
                            ci.Phone = this.txtPhone.Text;
                            arepo.AddUserInfromation(u);
                            crepo.AddClinicInfromation(ci);


                            Login l = new Login();
                            this.Visible = false;
                            l.Visible = true;

                        }

                        //
                    }
                }
                else
                {
                    MessageBox.Show(this, "Password & Con. Password Doesn't Match.");
                }
            }

        }

        private void BtnBackHomePage_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
    }
}

