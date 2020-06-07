using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{
  public  class Patient : Common
    {
        public Patient()
        { }
        public Patient(string userid,string username, string gender, string phone, string email, string dateOfBirth, string divission, string district, string thana) : base(userid,username, gender, phone, email, dateOfBirth, divission,district,thana)
        {

        }

        public Patient(DataSet patient)
        {
            try
            {
                base.Userid = patient.Tables[0].Rows[0][1].ToString();
                base.Username = patient.Tables[0].Rows[0][2].ToString();
                base.Gender = patient.Tables[0].Rows[0][3].ToString();
                base.Phone = patient.Tables[0].Rows[0][4].ToString();
                base.Email = patient.Tables[0].Rows[0][5].ToString();
                base.DateOfBirth = patient.Tables[0].Rows[0][6].ToString();
                base.Divission = patient.Tables[0].Rows[0][7].ToString();
                base.District = patient.Tables[0].Rows[0][8].ToString();
                base.Thana = patient.Tables[0].Rows[0][9].ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Coudn't get Information");
                
            }
        }
    }
}
