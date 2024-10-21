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
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
        }
        STUDENT STUDENT = new STUDENT();
        private void StudentListForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with students data
            SqlCommand cmd = new SqlCommand("select * from Student");
            dataGridView1.ReadOnly = true;
            //to create image columns
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //row height
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = STUDENT.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            //zoom,fit,stretch etc
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //display the selected student in a new from to edit/remove.
            UpdateDeleteStudentForm updateDeleteStdF = new UpdateDeleteStudentForm();
            updateDeleteStdF.textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeleteStdF.textBoxFname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeleteStdF.textBoxLname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeleteStdF.dateTimePicker1.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;

            if (dataGridView1.CurrentRow.Cells[4].Value.ToString()=="Female")
            {
                updateDeleteStdF.radioButtonFemale.Checked = true;
            }
            updateDeleteStdF.textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeleteStdF.textBoxAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;
            pic = (byte[])dataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeleteStdF.pictureBoxStudentImage.Image = Image.FromStream(picture);
            updateDeleteStdF.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //refresh the dataGridView data
            SqlCommand cmd = new SqlCommand("select * from Student");
            dataGridView1.ReadOnly = true;
            //to create image columns
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            //row height
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = STUDENT.getStudents(cmd);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            //zoom,fit,stretch etc
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
