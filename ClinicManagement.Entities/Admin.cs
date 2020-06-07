using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClinicManagement.Entities
{

   public class Admin : Common
    {
        public Admin() { }
        public Admin(string userid, string username) : base(userid, username)
        {

        }
        public Admin(DataSet admin)
        {
            try
            {
                base.Userid = admin.Tables[0].Rows[0][1].ToString();
                base.Username = admin.Tables[0].Rows[0][2].ToString();


            }
            catch (Exception )
            {
                MessageBox.Show("Coudn't get Information");
                }
        }
    }
}
