using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    internal class STUDENT
    {
        MY_DB db = new MY_DB();

        public bool insertStudent(string fname,string lname,DateTime bdate, string phone,string gender,string address,MemoryStream picture)
        {
            
            SqlCommand cmd = new SqlCommand("INSERT INTO Student (first_name, last_name, birthdate, gender, phone, address, picture) VALUES (@fn, @ln, @bdt, @gdr, @phn, @adrs, @pic)", db.getConnection());


            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bdt", SqlDbType.Date).Value =bdate;
            cmd.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            
            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closedConnection();
                return true;
            }
            else
            {
                db.closedConnection();
                return false;
            }
            
        }

        //create a function to return a table of student data
        public DataTable getStudents(SqlCommand cmd)
        {
            cmd.Connection = db.getConnection();    
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            return dt;
        }

        //create a function to update student imformation
        public bool updateStudent(int id,string fname, string lname, DateTime bdate, string phone, string gender, string address, MemoryStream picture)
        {
            SqlCommand cmd = new SqlCommand("update Student set first_name = @fn, last_name=@ln, birthdate=@bdt, gender=@gdr, phone=@phn, address=@adrs, picture=@pic Where id=@ID", db.getConnection());

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fn", SqlDbType.VarChar).Value = fname;
            cmd.Parameters.Add("@ln", SqlDbType.VarChar).Value = lname;
            cmd.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            cmd.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            cmd.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            cmd.Parameters.Add("@adrs", SqlDbType.VarChar).Value = address;
            cmd.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closedConnection();
                return true;
            }
            else
            {
                db.closedConnection();
                return false;
            }
        }


        //create a function to delete the selected student
        public bool deleteStudent(int id)
        {
            SqlCommand cmd = new SqlCommand("delete from Student Where id=@studentID", db.getConnection());

            cmd.Parameters.Add("@studentID", SqlDbType.Int).Value = id;

            db.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                db.closedConnection();
                return true;
            }
            else
            {
                db.closedConnection();
                return false;
            }
        }

        //create a function to execute the count queries
        public string exeCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query,db.getConnection());

            db.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            db.closedConnection();
            return count;
        }

        //get the total student
        public string totalStudent()
        {
            return exeCount("select COUNT(*) from Student");
        }
        public string totalMaleStudent()
        {
            return exeCount("select COUNT(*) from Student where phone='Male'");
        }

        public string totalFemaleStudent()
        {
            return exeCount("select COUNT(*) from Student where phone='Female'");
        }
    }
}
