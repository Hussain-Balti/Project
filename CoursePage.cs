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
    public partial class CoursePage : Form
    {
        public CoursePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddCourseForm aCrsF = new AddCourseForm();
            aCrsF.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rmvCrseF = new RemoveCourseForm();
            rmvCrseF.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageCourseForm mngCrsF = new ManageCourseForm();
            mngCrsF.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintCourseForm prCrsF = new PrintCourseForm();
            prCrsF.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show(this);
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void CoursePage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            StudentPage studentPage = new StudentPage();
            studentPage.Show(this);
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
    }
}
