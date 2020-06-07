using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{
    public class Doctor : Common
    {

        private string bmdcregno;
        public string Description { get; set; }
        public string Specialty { get; set; }
        public string Degree { get; set; }
        public string Date { get; set; }
       public string Time { get; set; }

        public string BMDCRegno
        {
            get { return bmdcregno; }
            set { bmdcregno = value; }
        }
        public Doctor(){}
        public Doctor(string userid, string username, string gender, string phone, string email, string dateOfBirth, string divission, string district, string thana, string description, string specialty, string bmdcregno, string degree) : base(userid,username, gender, phone, email, dateOfBirth, divission,district,thana)
        {
            
            this.Description = description;
            this.Specialty = specialty;
            this.BMDCRegno = bmdcregno;
            this.Degree = degree;
    
        }


        public Doctor(DataSet doctor)
        {
            try
            {
                base.Userid = doctor.Tables[0].Rows[0][1].ToString();
                base.Username = doctor.Tables[0].Rows[0][2].ToString();
                base.Gender = doctor.Tables[0].Rows[0][3].ToString();
                base.Phone = doctor.Tables[0].Rows[0][4].ToString();
                base.Email = doctor.Tables[0].Rows[0][5].ToString();
                base.DateOfBirth = doctor.Tables[0].Rows[0][6].ToString();
                this.Degree = doctor.Tables[0].Rows[0][7].ToString();
                this.Specialty = doctor.Tables[0].Rows[0][8].ToString();
                this.BMDCRegno = doctor.Tables[0].Rows[0][9].ToString();
                this.Description = doctor.Tables[0].Rows[0][10].ToString();
                base.Divission = doctor.Tables[0].Rows[0][11].ToString();
                base.District = doctor.Tables[0].Rows[0][12].ToString();
                base.Thana = doctor.Tables[0].Rows[0][13].ToString();
               

            }
            catch (Exception )
            {
                MessageBox.Show("Coudn't get Information");
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
