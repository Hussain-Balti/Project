using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class ManageCourseForm : Form
    {
        COURSE course = new COURSE();
        int pos;
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            /*comboBoxCourse.DataSource = course.getAllCourse();
            comboBoxCourse.DisplayMember = "Title";
            comboBoxCourse.ValueMember = "Id";
            comboBoxCourse.SelectedItem = null;*/
            reloadListBoxData();

        }

        //create a function to load the listbox with courses
        public void reloadListBoxData()
        {
            listBoxCourse.DataSource = course.getAllCourse();
            listBoxCourse.ValueMember = "Id";
            listBoxCourse.DisplayMember = "Title";
            listBoxCourse.SelectedItem = null;

            //display the total course
            labelTotalCourse.Text = "Total Courses: "+course.totalCourses();
        }
        //create a function to display course on data epending on the index
        void showData(int index)
        {
            DataRow dr = course.getAllCourse().Rows[index];
            listBoxCourse.SelectedIndex = index;
            textBoxID.Text = dr.ItemArray[0].ToString();
            textBoxTitle.Text = dr.ItemArray[1].ToString();
            numericUpDownHours.Value = int.Parse(dr.ItemArray[2].ToString());
            textBoxDescription.Text = dr.ItemArray[3].ToString();
        }
        private void listBoxCourse_Click(object sender, EventArgs e)
        {
            //display the selected course data
            pos = listBoxCourse.SelectedIndex;
            showData(pos);
        }

        private void listBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //display the selected course data
                pos = listBoxCourse.SelectedIndex;
                showData(pos);
                
            }
            catch
            {

            }
        }
        //First
        private void buttonFirst_Click(object sender, EventArgs e)
        {
            pos = 0;
            showData(pos);
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (pos < course.getAllCourse().Rows.Count - 1)
            {
                pos = pos + 1;
                showData(pos);
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                showData(pos);
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            pos = course.getAllCourse().Rows.Count - 1;
            showData(pos);
        }

        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            string courseLabel = textBoxTitle.Text;
            int hours = (int)numericUpDownHours.Value;
            string description = textBoxDescription.Text;

            COURSE course = new COURSE();
            if (courseLabel.Trim() == "")
            {
                MessageBox.Show("Add a Course Name", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (course.checkCourseName(courseLabel))
            {
                if (course.insertCourse(courseLabel, hours, description))
                {
                    MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    reloadListBoxData();
                }
                else
                {
                    MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("This Course name already exist", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pos = 0;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the selected student
                int courseId = Convert.ToInt32(textBoxID.Text);
                //Show the confirmation message before deleting the student
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course Remove Successfully", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reloadListBoxData();
                        //clear fields
                        textBoxID.Text = "";
                        numericUpDownHours.Value = 2;
                        textBoxTitle.Text = "Title";
                        textBoxDescription.Text = "Description";
                        
                    }
                    else
                    {
                        MessageBox.Show("Course Id Not Found!", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a numberic Course ID", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            pos = 0;
        }

        private void buttonEditCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //update selected course
                string name = textBoxTitle.Text;
                int hrs = (int)numericUpDownHours.Value;
                string description = textBoxDescription.Text;
                int id = Convert.ToInt32(textBoxID.Text);

                if (name.Trim() != "")
                {
                    if(!course.checkCourseName(name))
                    {
                        MessageBox.Show("These Course Name already exist.","Edit Course",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if(course.updateCourse(id,name, hrs, description))
                    {
                        MessageBox.Show("Course Update","Edit Course",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        reloadListBoxData();
                    }
                    else
                    {
                        MessageBox.Show("Course not update", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Enter the co", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("No Course Selected", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
         {
             try
             {
                 //display the selected course data
                 int id = Convert.ToInt32(comboBoxCourse.SelectedValue);
                 DataTable table = new DataTable();
                 table = course.getCourseById(id);
                 textBoxTitle.Text = table.Rows[0][1].ToString();
                 numericUpDownHours.Value = Int32.Parse(table.Rows[0][2].ToString());
                 textBoxDescription.Text = table.Rows[0][3].ToString();
             }
             catch { }
         }*/
    }
}
