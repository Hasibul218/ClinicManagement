using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicManagement.Data
{
   public class DataAccess
    {
        
        private static SqlConnection sqlcon;
        public static SqlConnection Sqlcon
        {
            get
            {
                try
                {
                    if (sqlcon == null)
                    {
                        sqlcon = new SqlConnection(@"Data Source=RIDU\RIDUSQL;Initial Catalog=ClinicManagement;Persist Security Info=True;User ID=SA;Password=3652");
                    }
                    else if (sqlcon.State != ConnectionState.Open)
                    {
                        sqlcon.Open();
                    }
                    return sqlcon;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        ////private SqlCommand sqlcom;
        //public SqlCommand Sqlcom { get; set; }
       // public static SqlDataAdapter Sqlda { get; set; }
        ////private DataSet ds;
        //public DataSet Ds { get; set; }
        ////private void QueryText(string query)
        ////{
        ////    this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        ////}
        public static DataSet GetDataSet(string query)
        {
            try
            {
                SqlCommand sqcom = new SqlCommand(query, Sqlcon);
                SqlDataAdapter sda = new SqlDataAdapter(sqcom);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable GetDataTable(string query)
            {
                try
                {
                    var ds = GetDataSet(query);
                    if (ds.Tables.Count > 0)
                    {
                        return ds.Tables[0];
                    }
                    return null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }

        public static int ExecuteQuery(string query)//INSERT, DELETE, UPDATE, and SET statements will process here
        {
            try
            {

                SqlCommand sqcom = new SqlCommand(query, Sqlcon);
                return sqcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }
    }
    }

