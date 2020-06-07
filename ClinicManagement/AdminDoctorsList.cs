using ClinicManagement.Data;
using ClinicManagement.Entities;
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
    public partial class AdminDoctorsList : MetroForm
    {
        private DataAccess Da { get; set; }
        private DataSet Ds { get; set; }
       
        private Admin ad;
        string sql;
        public AdminDoctorsList(Admin ad)
        {
           
            InitializeComponent();
            this.ad = ad;
           
            sql = "select * from doctor";
            this.PopulateGridView(sql);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];

            txtUserName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtSpeciality.Enabled = false;
            txtDegree.Enabled = false;
            txtDescription.Enabled = false;
            txtDivission.Enabled = false;
            txtDistrict.Enabled = false;
            txtThana.Enabled = false;
            btnSave.Visible = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
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

        }

        private void GridDoctorsList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = this.GridDoctorsList.CurrentRow.Cells["id"].Value.ToString();
            this.txtUserId.Text = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            this.txtUserName.Text = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            this.txtGender.Text = this.GridDoctorsList.CurrentRow.Cells["gender"].Value.ToString();
            this.txtPhone.Text = this.GridDoctorsList.CurrentRow.Cells["phone"].Value.ToString();
            this.txtEmail.Text = this.GridDoctorsList.CurrentRow.Cells["email"].Value.ToString();
            this.Dtpicker.Text = this.GridDoctorsList.CurrentRow.Cells["dateOfBirth"].Value.ToString();
            this.txtSpeciality.Text = this.GridDoctorsList.CurrentRow.Cells["specialty"].Value.ToString();
            this.txtDegree.Text = this.GridDoctorsList.CurrentRow.Cells["degree"].Value.ToString();
            this.txtBmdcRegNo.Text = this.GridDoctorsList.CurrentRow.Cells["bmdcregno"].Value.ToString();
            this.txtDescription.Text = this.GridDoctorsList.CurrentRow.Cells["description"].Value.ToString();
            this.txtDivission.Text = this.GridDoctorsList.CurrentRow.Cells["divission"].Value.ToString();
            this.txtDistrict.Text = this.GridDoctorsList.CurrentRow.Cells["district"].Value.ToString();
            this.txtThana.Text = this.GridDoctorsList.CurrentRow.Cells["thana"].Value.ToString();
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            //MessageBox.Show("Data has bee pushed from grid!");
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();
            string sql = "delete from doctor where userid='" + userid + "';";
            string sqll = "delete from login where userid='" + userid + "';";
            DataAccess.ExecuteQuery(sql);
            DataAccess.ExecuteQuery(sqll);
            MessageBox.Show(username + " has been deleted.");
            string sql1 = "select * from doctor";
            this.PopulateGridView(sql1);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            btnDelete.Enabled = false;
            txtId.Clear();
            txtUserId.Clear();
            txtUserName.Clear();
            txtEmail.Clear();
            txtGender.Clear();
            txtPhone.Clear();
            txtSpeciality.Clear();
            txtThana.Clear();
            txtDivission.Clear();
            txtDistrict.Clear();
            txtDescription.Clear();
            txtBmdcRegNo.Clear();
            txtDegree.Clear();
            Dtpicker.Enabled = false;
            btnSave.Visible = false;
            btnEdit.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string userid = this.GridDoctorsList.CurrentRow.Cells["userid"].Value.ToString();
            string username = this.GridDoctorsList.CurrentRow.Cells["username"].Value.ToString();

            string sql = @"update doctor set userid= '" + this.txtUserId.Text + @"',
			            username= '" + this.txtUserName.Text + @"',
			            gender= '" + this.txtGender.Text + @"',
			            phone= '" + this.txtPhone.Text + @"',
			            email= '" + this.txtEmail.Text + @"',
			            dateOfBirth= '" + this.Dtpicker.Text + @"',
			            specialty= '" + this.txtSpeciality.Text + @"',
			            degree= '" + this.txtDegree.Text + @"',
			            bmdcregno= '" + this.txtBmdcRegNo.Text + @"',
			            description= '" + this.txtDescription.Text + @"',
			            divission= '" + this.txtDivission.Text + @"',
                        district ='" + this.txtDistrict.Text + @"',
                        thana='" + this.txtThana.Text + @"'
                        where id='" + this.txtId.Text + "';";

            DataAccess.ExecuteQuery(sql);
            MessageBox.Show(username + "'s Data has been updated");

            string sql1 = "select * from doctor";
            this.PopulateGridView(sql1);
            this.GridDoctorsList.DataSource = this.Ds.Tables[0];
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtUserName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtSpeciality.Enabled = true;
            txtDegree.Enabled = true;
            txtDescription.Enabled = true;
            txtDivission.Enabled = true;
            txtDistrict.Enabled = true;
            txtThana.Enabled = true;
            btnSave.Visible = true;
        }

    }
}
