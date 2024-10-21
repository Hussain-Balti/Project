using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();
        STUDENT student = new STUDENT();
        COURSE course = new COURSE();
        private string description;

        //on form load
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            //populate the comboBox with courses name
            comboBoxSelectCourse.DataSource = course.getAllCourse();
            comboBoxSelectCourse.DisplayMember = "Title";
            comboBoxSelectCourse.ValueMember = "Id";

            //populate the datagridview with student data(id,first name,last name)
            SqlCommand cmd = new SqlCommand("select id,first_name,last_name from Student");
            dataGridView1.DataSource = student.getStudents(cmd);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            //get the student id of selected student
            textBoxStudentId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

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
                if(!score.studentScoreExists(studentId,courseId))
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
    }
}
