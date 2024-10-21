using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUploadImage_Click(object sender, EventArgs e)
        {
            //browse image from computer
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            //add new student
            STUDENT student = new STUDENT();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            DateTime bdate = dateTimePicker1.Value;
            string phone =  textBoxPhone.Text;
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

            if((this_year - born_year < 10) || (this_year - born_year > 100))
            {
                MessageBox.Show("The student age must be between 10 to 100 Year.","Invalid birth date",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if (verify())
            {
                pictureBoxStudentImage.Image.Save(pic,pictureBoxStudentImage.Image.RawFormat);
                if(student.insertStudent(fname,lname,bdate,gender,phone,address,pic))
                {
                    MessageBox.Show("New Student Added","Add Student",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /*
         Trim() is used to remove any leading or trailing white spaces from 
          the text entered into text boxes before checking if they are empty.
         */
        //create a function to verify data
        bool verify()
        {
            /*
            This code is checking if certain fields are filled in a form 
            correctly. It's verifying whether the first name, last name, 
            phone number, address, and an image of a student are all provided. If any of these fields are empty (or if the image is not provided), it returns "false" to indicate that the form is incomplete. Otherwise, it returns "true" to indicate that the form is complete.
             */

            if ((textBoxFname.Text.Trim()== "") ||
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
