using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    
    public partial class ManageStudentsForm : Form
    {
        MY_DB db1 = new MY_DB();
        public ManageStudentsForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void ManageStudentsForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with student data
            fillGrid(new SqlCommand("select * from Student"));
        }
        //create a function to populate the datagridview

        public void fillGrid(SqlCommand command)
        {
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = student.getStudents(command);
            //column 7 is image columns
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

            //add total student
            labelTotalStudents.Text = "Total Students: "+dataGridView1.Rows.Count;
        }

        
        private void ManageStudentsForm_Click(object sender, EventArgs e)
        {
            
        }
        //display student data on datagridview click
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                radioButtonFemale.Checked = true;
            }
            else
            {
                radioButtonMale.Checked = true;
            }

            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBoxStudentImage.Image = Image.FromStream(picture);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFname.Text = "";
            textBoxLname.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            radioButtonMale.Checked = true;
            dateTimePicker1.Value = DateTime.Now;
            pictureBoxStudentImage.Image = null;
        }
        //search and display student in datagridview 
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            // Check if the search text box is empty
            if (!string.IsNullOrEmpty(textBoxSearch.Text))
            {
                // Construct the query to search for the entered text in first_name, last_name, and address columns
                string query = "SELECT * FROM Student WHERE CONCAT(first_name, ' ', last_name, ' ', address) LIKE '%' + @SearchText + '%'";

                // Create a SqlCommand object with the query
                SqlCommand command = new SqlCommand(query);

                // Add parameter for the search text
                command.Parameters.AddWithValue("@SearchText", textBoxSearch.Text);

                // Call the fillGrid method to populate the DataGridView
                fillGrid(command);
            }
            else
            {
                // Inform the user to enter a search term
                MessageBox.Show("Please enter a search term.");
            }
            //video number 5 15-20 min
        }
        //browse and display image from your computer to picturebox
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Select Image(*.jpg; *.png;*.gif)|*.jpg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        //save the image to your computer
        private void buttonDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            //set the file name
            svf.FileName = "Student_" + textBoxID.Text;
            //check if the picture box is empty
            if(pictureBoxStudentImage.Image==null)
            {
                MessageBox.Show("No Image found!");
            }
            else if(svf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxStudentImage.Image.Save(svf.FileName+("."+ImageFormat.Jpeg.ToString()));
            }
        }
        //add new student
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            STUDENT student = new STUDENT();
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
                if (student.insertStudent(fname, lname, bdate, gender, phone, address, pic))
                {
                    MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillGrid(new SqlCommand("select * from Student"));
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
        //Edit the selected student
        private void buttonEdit_Click(object sender, EventArgs e)
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
                        fillGrid(new SqlCommand("select * from Student"));
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
        //remove the selected student
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
                        fillGrid(new SqlCommand("select * from Student"));
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
    }
}
