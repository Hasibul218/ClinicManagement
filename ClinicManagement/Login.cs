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
using MetroFramework.Forms;

namespace ClinicManagement
{
    public partial class Login : MetroForm
    {

        private DataSet Ds { get; set; }

        public Login()
        {
            InitializeComponent();
            txt_password.UseSystemPasswordChar = true;
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {


        }

        private void Btn_login_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userid.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Userid or Passwor Missing.");
            }
            else
            {
                try
                {
                    string sql = "select * from login where userid = '" + this.txt_userid.Text + "' AND password = '" + this.txt_password.Text + "' ;";
                    Ds = DataAccess.GetDataSet(sql);

                    User user = new User(Ds);

                    if (user.Status.Equals("admin"))
                    {
                        sql = "select * from admin where userid = '" + this.txt_userid.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);
                        Admin ad = new Admin(Ds);

                        AdminProfile ap = new AdminProfile(ad);
                        this.Visible = false;
                        ap.Visible = true;

                    }
                    else if (user.Status.Equals("doctor"))
                    {
                        sql = "select * from doctor where userid = '" + this.txt_userid.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);
                        Doctor dr = new Doctor(Ds);

                        DoctorProfile dp = new DoctorProfile(dr);
                        this.Visible = false;
                        dp.Visible = true;
                    }
                    else if (user.Status.Equals("patient"))
                    {
                        sql = "select * from patient where userid = '" + this.txt_userid.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);

                        Patient pa = new Patient(Ds);

                        PatientProfile pp = new PatientProfile(pa);
                        this.Visible = false;
                        pp.Visible = true;
                    }
                    else if (user.Status.Equals("clinic"))
                    {
                        sql = "select * from clinic where userid = '" + this.txt_userid.Text + "';";
                        Ds = DataAccess.GetDataSet(sql);

                        Clinic c = new Clinic(Ds);

                        ClinicProfile ci = new ClinicProfile(c);
                        this.Visible = false;
                        ci.Visible = true;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Userid and Password dosen't match!");
                }
            }
            
        }

        private void BntBackHomePage_Click(object sender, EventArgs e)
        {
            HomePage hp = new HomePage();
            this.Visible = false;
            hp.Visible = true;
        }

        private void ChPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(ChPassword.Checked)
            {
                ChPassword.Text = "Hide Password";
                txt_password.UseSystemPasswordChar = false;
            }
            else
            {
                ChPassword.Text = "Show Password";
                txt_password.UseSystemPasswordChar = true;
            }
        }

        private void Txt_password_Click(object sender, EventArgs e)
        {

        }

        private void BntExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Application Exit!","Are you sure want to exit ?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(dialogResult==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }
    }
    }

