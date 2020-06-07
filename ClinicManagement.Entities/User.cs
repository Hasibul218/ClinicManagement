using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{
    public class User : Common
    {
        public string Password { get; set; }
        public string Status { get; set; }

        public User()
        { }
        public User(DataSet login)
        {
            try
            {
                base.Userid = login.Tables[0].Rows[0][1].ToString();
                this.Password = login.Tables[0].Rows[0][2].ToString();
                this.Status = login.Tables[0].Rows[0][3].ToString();

   
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Coudn't get User Information");
               // MessageBox.Show(ex.Message);
            }
        }





    }
}