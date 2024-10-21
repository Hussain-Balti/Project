using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.IO;

namespace Student_Project
{
    internal class COURSE
    {
        MY_DB mydb = new MY_DB();
        //create a function to insert course
        public bool insertCourse(string courseTitle,int creditHours,string description)
        {
            SqlCommand cmd = new SqlCommand("insert into Course(Title,Credit_hour,Description) Values (@title,@credit,@desc)", mydb.getConnection());
            cmd.Parameters.Add("@title", SqlDbType.VarChar).Value = courseTitle;
            cmd.Parameters.Add("@credit", SqlDbType.Int).Value = creditHours;
            cmd.Parameters.Add("@desc", SqlDbType.Text).Value = description;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closedConnection();
                return true;
            }
            else
            {
                mydb.closedConnection();
                return false;
            }
        }


        //create a function to check if the course name already exist in the table.
        //when we edit a course we need to exclude the current course from the name verification.
        //using course id default id=0
        public bool checkCourseName(string courseName, int courseId = 0)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE Title = @cName AND Id != @cid", mydb.getConnection());
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            cmd.Parameters.Add("@cName", SqlDbType.VarChar).Value = courseName;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                mydb.closedConnection();
                // This course name already exists.
                return false;
            }
            else
            {
                mydb.closedConnection();
                return true;
            }
        }


        //function to remove course using id
        public bool deleteCourse(int courseid)
        {
            SqlCommand cmd = new SqlCommand("delete from Course Where Id=@CourseID", mydb.getConnection());

            cmd.Parameters.Add("@CourseID", SqlDbType.Int).Value = courseid;

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closedConnection();
                return true;
            }
            else
            {
                mydb.closedConnection();
                return false;
            }
        }
        //create a function to get all course
        public DataTable getAllCourse()
        {
            SqlCommand cmd = new SqlCommand("select * from Course", mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table; 
        }

        //create a function to get a course by id all course
        public DataTable getCourseById(int courseId)
        {
            SqlCommand cmd = new SqlCommand("select * from Course where id=@cid", mydb.getConnection());
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function to execute the count queries
        public string exeCount(string query)
        {
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection());

            mydb.openConnection();
            string count = cmd.ExecuteScalar().ToString();
            mydb.closedConnection();
            return count;
        }

        //get the total courses
        public string totalCourses()
        {
            return exeCount("select COUNT(*) from Course");
        }

        //update course
        public bool updateCourse(int id, string title, int hrs, string description)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Course SET Title = @tit, Credit_hour = @ch, Description = @desc WHERE Id = @ID", mydb.getConnection());

            cmd.Parameters.Add("@ID", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@tit", SqlDbType.VarChar).Value = title;
            cmd.Parameters.Add("@ch", SqlDbType.Int).Value = hrs;
            cmd.Parameters.Add("@desc", SqlDbType.Text).Value = description; // Corrected parameter name

            mydb.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                mydb.closedConnection();
                return true;
            }
            else
            {
                mydb.closedConnection();
                return false;
            }
        }

    }
}
