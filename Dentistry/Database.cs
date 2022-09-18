using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentistry
{
    class Database
    {
        //connection to database
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-UD8EJ3F;Initial Catalog=Dentistry_management_system;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        // select 
        public DataTable readData(string stmt, string message)
        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                //load data from database to tbl 
                tbl.Load(cmd.ExecuteReader());

                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return tbl;
        }

        // insert update delete 
        public bool exceuteData(string stmt, string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

    }
}

