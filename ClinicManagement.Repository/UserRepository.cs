using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicManagement.Entities;
using ClinicManagement.Data;
using System.Windows.Forms;

namespace ClinicManagement.Repository
{
   public class UserRepository
    {
        public void AddUserInfromationToTemploginTable(User u)
        {
            try
            {
                string sql = "insert into temploginReg (userid,password,status) values  ('" + u.Userid + "','" + u.Password + "','" + u.Status + "');";
                DataAccess.ExecuteQuery(sql);
            }
            catch (Exception exc)
            {
               // MessageBox.Show("This user id already exits.");
                MessageBox.Show("Error: " + exc.Message);
             
            }
        }
        
        
    }
}
