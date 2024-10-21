using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Project
{
    internal class SCORE
    {
        MY_DB mydb = new MY_DB();
        
        //create a function to insert score
        public bool insertScore(int studentId,int courseId,double score,string description)
        {
            SqlCommand cmd = new SqlCommand("Insert into Score (studentId,courseId,score,description) values (@sid,@cid,@sc,@de)",mydb.getConnection());
            //@sid,@cid,@sc,@de
            cmd.Parameters.Add("sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("cid", SqlDbType.Int).Value = courseId;
            cmd.Parameters.Add("sc", SqlDbType.Float).Value = score;
            cmd.Parameters.Add("de", SqlDbType.Text).Value = description;

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

        //create a function to check if a score is already asigned to this student in this course.
        public bool studentScoreExists(int studentId,int courseId)
        {
            SqlCommand cmd = new SqlCommand("select * from Score where studentId=@sid and courseId=@cid",mydb.getConnection());
            cmd.Parameters.Add("sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("cid", SqlDbType.Int).Value = courseId;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count ==0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //create a function to get student score
        public DataTable getStudentsScore()
        {
            string query = "select Score.studentId,Student.first_name,Student.last_name,Score.courseId,Course.Title,Score.score from Student inner join Score on Student.Id = Score.studentId inner join Course on Score.courseId=course.Id";
            SqlCommand cmd = new SqlCommand(query,mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //function to remove score by student and course id
        public bool deleteScore(int studentId,int courseId)
        {
            SqlCommand cmd = new SqlCommand("delete from Score Where studentId=@sid and courseId=@cid", mydb.getConnection());

            cmd.Parameters.Add("@sid", SqlDbType.Int).Value = studentId;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = courseId;

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

        //create a function to get average score by course
        public DataTable avgScoreByCourse()
        {
            string query = "Select Course.Title,avg(Score.score) as 'Average Score' from Course,Score where Course.Id= Score.courseId group by Course.Title";
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        //create a function to get score by courseId
        public DataTable scorebyCourseId(int courseId)
        {
            string query = "select Score.studentId,Student.first_name,Student.last_name,Score.courseId,Course.Title,Score.score from Student inner join Score on Student.id=Score.studentId inner join Course on Score.courseId=course.Id where Score.courseId="+courseId;
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        //create a function to get score by StudentId
        public DataTable scorebyStudentId(int studentId)
        {
            string query = "select Score.studentId,Student.first_name,Student.last_name,Score.courseId,Course.Title,Score.score from Student inner join Score on Student.id=Score.studentId inner join Course on Score.courseId=course.Id where Score.studentId=" + studentId;
            SqlCommand cmd = new SqlCommand(query, mydb.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
/*Add foreign key constraint for update delete in ssms query.
"alter table Score add constraint fk_student_id foreign key (studentId)
references Student(Id) on update cascade on delete cascade;"

"alter table Score add constraint fk_course_id foreign key (courseId) 
references Course(Id) on update cascade on delete cascade";
*/