using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Data.SqlClient;

namespace Student_Project
{
    
    internal class MY_DB
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MKL3UNA\\SQLEXPRESS;Initial Catalog=Student_Portal_DB;Integrated Security=True;TrustServerCertificate=True");
        public SqlConnection getConnection()
        {
            return conn;
        }
        public void openConnection()
        {
            if(conn.State==System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closedConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
