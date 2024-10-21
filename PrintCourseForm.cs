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
    public partial class PrintCourseForm : Form
    {
        public PrintCourseForm()
        {
            InitializeComponent();
        }
        COURSE course  = new COURSE();
        private void PrintCourseForm_Load(object sender, EventArgs e)
        {
            //populate datagridview with courses
            dataGridView1.DataSource = course.getAllCourse();
        }
        //print data from datagridview to text file
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //our file path
            //the file name = courses_list.text
            //location = in the desktop
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\courses_list.txt";

            using (var writer = new StreamWriter(path))
            {
                //check if file exist
                if (!File.Exists(path))
                {
                    File.Create(path);
                }


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count - 1; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    //new line
                    writer.WriteLine("");
                    writer.WriteLine("---------------------------------------------------------------------");
                }

                writer.Close();
                MessageBox.Show("Data Exported");
            }
        }
    }
}
