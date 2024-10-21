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
    public partial class StudentPage : Form
    {
        public StudentPage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainForm1 main = new MainForm1();
            main.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdf = new AddStudentForm();
            addStdf.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentListForm stdListf = new StudentListForm();
            stdListf.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StatisticForm stcF = new StatisticForm();
            stcF.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upDelStdF = new UpdateDeleteStudentForm();
            upDelStdF.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mngStdF = new ManageStudentsForm();
            mngStdF.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintStudentForm prStdF = new PrintStudentForm();
            prStdF.Show(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CoursePage coursePage = new CoursePage();
            coursePage.Show(this);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ScorePage scorePage = new ScorePage();
            scorePage.Show(this);
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Aboutus aboutus = new Aboutus();
            aboutus.Show(this);
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ContactPage contactPage = new ContactPage();
            contactPage.Show(this);
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentPage_Load(object sender, EventArgs e)
        {

        }
    }
}
