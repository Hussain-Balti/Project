using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class PrintStudentForm : Form
    {
        public PrintStudentForm()
        {
            InitializeComponent();
        }
        STUDENT student = new STUDENT();
        private void PrintStudentForm_Load(object sender, EventArgs e)
        {
            fillGrid(new SqlCommand("select * from Student"));

            if(radioButtonNo.Checked)
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

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
        }

        private void radioButtonNo_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void radioButtonYes_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }

        private void buttonGO_Click(object sender, EventArgs e)
        {
            //display data on datagridview depending on what user have selected
            string query;
            SqlCommand command;

            if (radioButtonYes.Checked)
            {
                string date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd"); // Format date properly for SQL
                string date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                // Construct the query using parameters to prevent SQL injection
                query = "SELECT * FROM Student WHERE birthdate BETWEEN @Date1 AND @Date2";
                if (radioButtonYes.Checked)
                {
                    if (radioButtonMale.Checked)
                    {
                        query += " AND phone = 'Male'";
                    }
                    else if (radioButtonFemale.Checked)
                    {
                        query += " AND phone = 'Female'";
                    }

                    // Execute the query using SqlCommand and pass parameters
                    command = new SqlCommand(query);
                    command.Parameters.AddWithValue("@Date1", date1);
                    command.Parameters.AddWithValue("@Date2", date2);

                    // Call fillGrid method to populate DataGridView
                    fillGrid(command);
                }
            }
            else
            {
                    if (radioButtonMale.Checked)
                    {
                        query = "SELECT * FROM Student where phone='Male'";
                    }
                    else if (radioButtonFemale.Checked)
                    {
                        query = "SELECT * FROM Student where phone='Female'";
                    }
                    else
                    {
                        query = "SELECT * FROM Student";
                    }

                    // Execute the query using SqlCommand and pass parameters
                    command = new SqlCommand(query);

                    // Call fillGrid method to populate DataGridView
                    fillGrid(command);
            }
        }
        //print data from datagridview to text file
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //our file path
            //the file name = students_list.text
            //location = in the desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\students_list.txt";

            using (var writer = new StreamWriter(path))
            {
                //check if file exist
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                DateTime bdate;

                for(int i=0;i< dataGridView1.Rows.Count;i++)
                {
                    for(int j=0;j<dataGridView1.Columns.Count-1;j++)
                    {
                        if (j == 3)
                        {
                            bdate = Convert.ToDateTime(dataGridView1.Rows[i].Cells[j].Value.ToString());
                            writer.Write("\t" + bdate.ToString("yyyy-MM--dd") + "\t" + "|");
                        }
                        //last columns
                        else if(j== dataGridView1.Columns.Count - 2)
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString());
                        }
                        else
                        {
                            writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                        }
                    }
                    //new line
                    writer.WriteLine("");
                    writer.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                }
                
                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
