using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{
   public class Clinic : Common
    {
        public Clinic()
        { }
        public Clinic(string userid,string username, string divission, string district, string thana, string phone) : base(userid,username, divission,district,thana, phone)
        {

        }
       
 public Clinic(DataSet clinic)
        {
            try
            { 
            base.Userid = clinic.Tables[0].Rows[0][1].ToString();
            base.Username = clinic.Tables[0].Rows[0][2].ToString();
            base.Divission = clinic.Tables[0].Rows[0][3].ToString();
            base.District = clinic.Tables[0].Rows[0][4].ToString();
            base.Thana = clinic.Tables[0].Rows[0][5].ToString();
            base.Phone = clinic.Tables[0].Rows[0][6].ToString();

        }
            catch (Exception ex)
            {
               MessageBox.Show("Coudn't get Information");
               MessageBox.Show(ex.Message);
            }
        }
    }
}
