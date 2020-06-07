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
    public partial class AdminClinicList : MetroForm
    {
        Admin ad;
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
        public AdminClinicList(Admin ad)
        {
            InitializeComponent();
            this.ad = ad;
            string sql = "select * from clinic";
            this.PopulateGridView(sql);
            this.GrdClinicList.DataSource = this.Ds.Tables[0];
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
            this.GrdClinicList.AutoGenerateColumns = false;  //Optional false
            this.Ds = DataAccess.GetDataSet(sql);
        }

        private void GridPatientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.GrdClinicList.CurrentRow.Cells["id"].Value.ToString();
            this.txtUserName.Text = this.GrdClinicList.CurrentRow.Cells["username"].Value.ToString();
            this.txtUserId.Text = this.GrdClinicList.CurrentRow.Cells["userid"].Value.ToString();
            this.txtDivission.Text = this.GrdClinicList.CurrentRow.Cells["divission"].Value.ToString();
            this.txtDistrict.Text = this.GrdClinicList.CurrentRow.Cells["district"].Value.ToString();
            this.txtThana.Text = this.GrdClinicList.CurrentRow.Cells["thana"].Value.ToString();
            this.txtPhone.Text = this.GrdClinicList.CurrentRow.Cells["phone"].Value.ToString();

            //MessageBox.Show("Data has been pushed from grid!");
            btnEdit.Enabled = true;
            //btnSave.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {

            string userid = this.GrdClinicList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GrdClinicList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from clinic where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from clinic";
            this.PopulateGridView(sql1);
            this.GrdClinicList.DataSource = this.Ds.Tables[0];
            txtId.Clear();
            txtUserId.Clear();
            txtUserName.Clear();
            txtPhone.Clear();
            txtThana.Clear();
            txtDivission.Clear();
            txtDistrict.Clear();
            btnSave.Visible = false;
            btnEdit.Enabled = false;

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtDivission.Enabled = true;
            txtDistrict.Enabled = true;
            txtThana.Enabled = true;
            txtPhone.Enabled = true;
            btnSave.Visible = true;

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //update query
            string username = this.GrdClinicList.CurrentRow.Cells["username"].Value.ToString();

            string sql = @"update clinic set 
                        userid= '" + this.txtUserId.Text + @"',
			            username= '" + this.txtUserName.Text + @"',
			            phone= '" + this.txtPhone.Text + @"',
			            divission= '" + this.txtDivission.Text + @"',
                        district ='" + this.txtDistrict.Text + @"',
                        thana='" + this.txtThana.Text + @"'
                        where id='" + this.txtId.Text + "';";

            DataAccess.ExecuteQuery(sql);
            MessageBox.Show(username + "'s Data has been updated");

            string sql1 = "select * from clinic";
            this.PopulateGridView(sql1);
            this.GrdClinicList.DataSource = this.Ds.Tables[0];
        }

        private void BtnBackAdmin_Click(object sender, EventArgs e)
        {
            AdminProfile ap = new AdminProfile(ad);
            this.Visible = false;
            ap.Visible = true;
        }
    }
}
