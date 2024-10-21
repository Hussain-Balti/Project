using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Student_Project
{
    public partial class PrintScoreForm : Form
    {
        public PrintScoreForm()
        {
            InitializeComponent();
        }
        COURSE course = new COURSE();
        STUDENT student = new STUDENT();
        SCORE score = new SCORE();

        private void PrintScoreForm_Load(object sender, EventArgs e)
        {
            //populate datagridview with student data.
            dataGridView1.DataSource = student.getStudents(new SqlCommand("select Id,first_name,last_name from Student"));

            //populate datagridview with all student score
            dataGridViewStudentScore.DataSource = score.getStudentsScore();

            //populate the comboBox 
            listBoxCourses.DataSource = course.getAllCourse();
            listBoxCourses.DisplayMember = "Title";
            listBoxCourses.ValueMember = "Id";
        }

        //when you select a course from listbox then all score assign to this course will display in the datagridview
        private void listBoxCourses_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.scorebyCourseId(int.Parse(listBoxCourses.SelectedValue.ToString()));
        }

        //display the selected student score
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.scorebyStudentId(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
        }

        //populate datagridview with all student score
        private void labelReset_Click(object sender, EventArgs e)
        {
            dataGridViewStudentScore.DataSource = score.getStudentsScore();
        }


        //print scores data from datagridview to text file
        private void buttonPrintScore_Click(object sender, EventArgs e)
        {
            //our file path
            //the file name = Score_list.text
            //location = in the desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Score_list.txt";

            using (var writer = new StreamWriter(path))
            {
                //check if file exist
                if (!File.Exists(path))
                {
                    File.Create(path);
                }


                for (int i = 0; i < dataGridViewStudentScore.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridViewStudentScore.Columns.Count ; j++)
                    {
                        writer.Write("\t" + dataGridViewStudentScore.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    //new line
                    writer.WriteLine("");
                    writer.WriteLine("----------------------------------------------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }
    }
}
