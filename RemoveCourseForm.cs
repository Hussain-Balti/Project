using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Project
{
    public partial class RemoveCourseForm : Form
    {
        COURSE course = new COURSE();
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        private void buttonRemoveCourse_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the selected student
                int courseId = Convert.ToInt32(textBoxCourseID.Text);
                //Show the confirmation message before deleting the student
                if (MessageBox.Show("Are You Sure You Want To Remove This Course", "Remove Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (course.deleteCourse(courseId))
                    {
                        MessageBox.Show("Course Remove Successfully", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Course Id Not Found!", "Remove Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a numberic Course ID", "InValid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
