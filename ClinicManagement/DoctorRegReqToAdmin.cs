using ClinicManagement.Data;
using ClinicManagement.Entities;
using ClinicManagement.Repository;
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
    public partial class DoctorRegReqToAdmin : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        User u = new User();
        Admin ad = new Admin();
        Doctor dr = new Doctor();
        AdminRepo arepo = new AdminRepo();
        string sql;
        public DoctorRegReqToAdmin(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            sql = "select * from tempDoctorReg";
            this.PopulateGridView(sql);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
        }
        void PopulateGridView(string sql)
        {
            this.GridDoctorsList.AutoGenerateColumns = false;
            this.Ds = DataAccess.GetDataSet(sql);
        }
        private void GrdDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void BtnFromDoctorsList_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
        private void GridDoctorsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // if(GridDoctorsList.Columns[e.ColumnIndex].Name=="Accept")
            //{
            //    if(MessageBox.Show("Are you sure want to delete this record ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            //    {

            //        string id= this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            //        string sql="delete * from doctor where userid='id'";
            //        sql = "select * from doctor";
            //        this.PopulateGridView(sql);
            //        this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            //    }
            //}
        }

        private void GridDoctorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string id = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            //string sql = "select * from doctor where userid='" + id + "';";
            //this.Ds = DataAccess.GetDataSet(sql);
            //if (this.Ds.Tables[0].Rows.Count == 1)
            //{
            //    if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        sql = "delete * from doctor where userid='" + id + "'";
            //        string sqll = "select * from doctor";
            //        this.PopulateGridView(sqll);
            //        this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            //    }
            //}  
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            //string username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            //string sql = "delete from doctor where userid='" + userid + "';";
            //string sqll = "delete from login where userid='" + userid + "';";
            //DataAccess.ExecuteQuery(sql);
            //DataAccess.ExecuteQuery(sqll);
            //MessageBox.Show(username + " has been deleted.");
            //string sql1 = "select * from doctor";
            //this.PopulateGridView(sql1);
            //this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            ////btnDelete.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ////string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            //string username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();

            //string sql = @"update doctor set userid= '" + this.txtUserId.Text + @"',
            //   username= '" + this.txtUserName.Text + @"',
            //   gender= '" + this.txtGender.Text + @"',
            //   phone= '" + this.txtPhone.Text + @"',
            //   email= '" + this.txtEmail.Text + @"',
            //   dateOfBirth= '" + this.Dtpicker.Text + @"',
            //   specialty= '" + this.txtSpeciality.Text + @"',
            //   degree= '" + this.txtDegree.Text + @"',
            //   bmdcregno= '" + this.txtBmdcRegNo.Text + @"',
            //   description= '" + this.txtDescription.Text + @"',
            //   divission= '" + this.txtDivission.Text + @"',
            //            district ='" + this.txtDistrict.Text + @"',
            //            thana='" + this.txtThana.Text + @"'
            //            where id='" + this.txtId.Text + "';";

            //DataAccess.ExecuteQuery(sql);
            //MessageBox.Show(username + "'s Data has been updated");

            //string sql1 = "select * from doctor";
            //this.PopulateGridView(sql1);
            //this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            //btnEdit.Enabled = false;
            //btnDelete.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //txtUserName.Enabled = true;
            //txtPhone.Enabled = true;
            //txtEmail.Enabled = true;
            //txtSpeciality.Enabled = true;
            //txtDegree.Enabled = true;
            //txtDescription.Enabled = true;
            //txtDivission.Enabled = true;
            //txtDistrict.Enabled = true;
            //txtThana.Enabled = true;
            //btnSave.Visible = true;
        }

        private void DoctorRegReqToAdmin_Load(object sender, EventArgs e)
        {

        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            string un = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            MessageBox.Show("Do you Want to Add " + un + "?");
            //sending doctor data
            dr.Userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            dr.Username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            dr.Gender = this.GridDoctorsList.CurrentRow.Cells["gender"].Value.ToString();
            dr.Phone = this.GridDoctorsList.CurrentRow.Cells["phone"].Value.ToString();
            dr.Email = this.GridDoctorsList.CurrentRow.Cells["email"].Value.ToString();
            dr.DateOfBirth = this.GridDoctorsList.CurrentRow.Cells["dateOfBirth"].Value.ToString();
            dr.Specialty = this.GridDoctorsList.CurrentRow.Cells["specialty"].Value.ToString();
            dr.Degree = this.GridDoctorsList.CurrentRow.Cells["degree"].Value.ToString();
            dr.BMDCRegno = this.GridDoctorsList.CurrentRow.Cells["bmdcregno"].Value.ToString();
            dr.Description = this.GridDoctorsList.CurrentRow.Cells["description"].Value.ToString();
            dr.Divission = this.GridDoctorsList.CurrentRow.Cells["divission"].Value.ToString();
            dr.District = this.GridDoctorsList.CurrentRow.Cells["district"].Value.ToString();
            dr.Thana = this.GridDoctorsList.CurrentRow.Cells["thana"].Value.ToString();
            arepo.AddDoctorInfromation(dr);
           
            //sending tempreg data
            string buser = "select * from temploginReg where userid='" + dr.Userid + "'";
            this.Ds = DataAccess.GetDataSet(buser);
            u = new User(Ds);
            arepo.AddUserInfromation(u);

            ////temp and doctor deleting query
            ///temp deleting
            buser = "delete from temploginReg where userid='" + u.Userid + "'";
            DataAccess.ExecuteQuery(buser);

            //doctor deleting
            string sql = "delete from tempDoctorReg where userid='" + dr.Userid + "';";
            DataAccess.ExecuteQuery(sql);

            //calling the gridview again after delelting
            string sql1 = "select * from tempDoctorReg";
            this.PopulateGridView(sql1);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            string un = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            MessageBox.Show("Do you Want to Delete " + un + "?");
            string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            string sql = "delete from tempDoctorReg where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            string sql1 = "select * from tempDoctorReg";
            this.PopulateGridView(sql1);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
        }
    }
}
