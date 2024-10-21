using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(ofd.FileName);
            }
        }


        bool verify()
        {
            /*
            This code is checking if certain fields are filled in a form 
            correctly. It's verifying whether the first name, last name, 
            phone number, address, and an image of a student are all provided. If any of these fields are empty (or if the image is not provided), it returns "false" to indicate that the form is incomplete. Otherwise, it returns "true" to indicate that the form is complete.
             */

            if ((textBoxFname.Text.Trim() == "") ||
                (textBoxLname.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (pictureBoxStudentImage.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                string fname = textBoxFname.Text;
                string lname = textBoxLname.Text;
                DateTime bdate = dateTimePicker1.Value;
                string phone = textBoxPhone.Text;
                string address = textBoxAddress.Text;
                string gender = "Male";
                if (radioButtonFemale.Checked)
                {
                    gender = "Female";
                }
                MemoryStream pic = new MemoryStream();

                //we need to check the age of the student 
                //the student age must be between 10 to 100
                int born_year = dateTimePicker1.Value.Year;
                int this_year = DateTime.Now.Year;

                if ((this_year - born_year < 10) || (this_year - born_year > 100))
                {
                    MessageBox.Show("The student age must be between 10 to 100 Year.", "Invalid birth date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (verify())
                {
                    pictureBoxStudentImage.Image.Save(pic, pictureBoxStudentImage.Image.RawFormat);
                    if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("Student Imformation Updated", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Empty Field", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id.", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the selected student
                int id = Convert.ToInt32(textBoxID.Text);
                //Show the confirmation message before deleting the student
                if (MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (student.deleteStudent(id))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //clear text
                        textBoxID.Text = "";
                        textBoxFname.Text = "";
                        textBoxLname.Text = "";
                        textBoxPhone.Text = "";
                        textBoxAddress.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBoxStudentImage.Image = null;

                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter a Valid Student Id", "InValid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //student search by id
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                SqlCommand cmd = new SqlCommand("select id,first_name,last_name,birthdate,gender,phone,address, picture from student where id=" + id);
                DataTable table = student.getStudents(cmd);

                if (table.Rows.Count > 0)
                {
                    textBoxFname.Text = table.Rows[0]["first_name"].ToString();
                    textBoxLname.Text = table.Rows[0]["last_name"].ToString();
                    textBoxPhone.Text = table.Rows[0]["phone"].ToString();
                    textBoxAddress.Text = table.Rows[0]["address"].ToString();
                    dateTimePicker1.Value = (DateTime)table.Rows[0]["birthdate"];

                    if (table.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButtonFemale.Checked = true;
                    }
                    else
                    {
                        radioButtonMale.Checked = true;
                    }

                    //image
                    byte[] pic = (byte[])table.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBoxStudentImage.Image = Image.FromStream(picture);

                }
            }
            catch
            {
                MessageBox.Show("Please Enter a valid Student Id", "InValid ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allow only number key press
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
