using ClinicManagement.Data;
using MetroFramework.Forms;
using ClinicManagement.Entities;
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
    public partial class AdminPatientList : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        Admin ad;
        public AdminPatientList(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;

           string sql = "select * from patient";
            this.PopulateGridView(sql);
            this.GridPatientList.DataSource = this.Ds.Tables[0];
            //button false
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSave.Visible = false;
            //txt fild false
            txtUserName.Enabled = false;
            txtDivission.Enabled = false;
            txtDistrict.Enabled = false;
            txtThana.Enabled = false;
            txtPhone.Enabled = false;

        }
        void PopulateGridView(string sql)
        {
           this.GridPatientList.AutoGenerateColumns = false;  //Optional false 
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GridPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.GridPatientList.CurrentRow.Cells["id"].Value.ToString();
            this.txtUserName.Text = this.GridPatientList.CurrentRow.Cells["username"].Value.ToString();
            this.txtUserId.Text = this.GridPatientList.CurrentRow.Cells["userid"].Value.ToString();
            this.txtGender.Text = this.GridPatientList.CurrentRow.Cells["gender"].Value.ToString();
            this.txtEmail.Text = this.GridPatientList.CurrentRow.Cells["email"].Value.ToString();
            this.Dtpicker.Text = this.GridPatientList.CurrentRow.Cells["dateOfBirth"].Value.ToString();
            this.txtDivission.Text = this.GridPatientList.CurrentRow.Cells["divission"].Value.ToString();
            this.txtDistrict.Text = this.GridPatientList.CurrentRow.Cells["district"].Value.ToString();
            this.txtThana.Text = this.GridPatientList.CurrentRow.Cells["thana"].Value.ToString();
            this.txtPhone.Text = this.GridPatientList.CurrentRow.Cells["phone"].Value.ToString();
            // MessageBox.Show("Data has been pushed from grid!");
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
           // btnSave.Visible = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userid = this.GridPatientList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GridPatientList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from patient where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from patient";
            this.PopulateGridView(sql1);
            this.GridPatientList.DataSource = this.Ds.Tables[0];
            txtId.Clear();
            txtUserId.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtThana.Clear();
            txtDivission.Clear();
            txtDistrict.Clear();
            Dtpicker.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Access Denied");
        }

        private void BtnBackAdmin_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
    }
}
