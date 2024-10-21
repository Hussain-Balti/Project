using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Project
{
    public partial class ManageScoreForm : Form
    {
        public ManageScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        COURSE course= new COURSE();
        STUDENT student = new STUDENT();
        string data = "Score";
        private void ManageScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comboBox with courses
            comboBoxSelectCourse.DataSource = course.getAllCourse();
            comboBoxSelectCourse.DisplayMember = "Title";
            comboBoxSelectCourse.ValueMember = "Id";

            //populate the datagridview with student score
            dataGridView1.DataSource = score.getStudentsScore();
        }

        //display the student data on datagridview
        private void buttonShowStudent_Click(object sender, EventArgs e)
        {
            data = "Student";
            SqlCommand cmd = new SqlCommand("select id,first_name,last_name,birthdate from Student");
            dataGridView1.DataSource = student.getStudents(cmd);
        }

        //display the score data on datagridview
        private void buttonShowScores_Click(object sender, EventArgs e)
        {
            data = "Score";
            dataGridView1.DataSource = score.getStudentsScore();
        }

        //get data from datagridview
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            getDataFromDatagridview();
        }

        //create a function to get data from datagridview
        public void getDataFromDatagridview()
        {
            //if the user select to show student data then we will show only student id
            if(data == "Student")
            {
                textBoxStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            }
            //else student id + comboBox value
            else if (data == "Score")
            {
                textBoxStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboBoxSelectCourse.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value;
            }
            
        }

        //button to add new score
        private void buttonAddScore_Click(object sender, EventArgs e)
        {
            //Add new Score
            try
            {
                int studentId = Convert.ToInt32(textBoxStudentId.Text);
                int courseId = Convert.ToInt32(comboBoxSelectCourse.SelectedValue);
                double scoreVal = Convert.ToDouble(textBoxScore.Text);
                string description = textBoxDescription.Text;

                //ccheck if a score is already asigned to this student in this course.
                if (!score.studentScoreExists(studentId, courseId))
                {
                    if (score.insertScore(studentId, courseId, scoreVal, description))
                    {
                        MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("The Score for this Course with this Id is already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter id to add score", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //button to remove score 
        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            //remove the selected score
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Do you went to delete this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentId, courseId))
                {
                    MessageBox.Show("Score delete", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Score not delete!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        //show the new form with average score by course
        private void buttonAverageScore_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScr = new AvgScoreByCourseForm();
            avgScr.Show(this);
        }
    }
}
