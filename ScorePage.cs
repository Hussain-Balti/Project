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
    public partial class ScorePage : Form
    {
        public ScorePage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddScoreForm prCrsF = new AddScoreForm();
            prCrsF.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveScoreForm prCrsF = new RemoveScoreForm();
            prCrsF.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScr = new AvgScoreByCourseForm();
            avgScr.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScoreForm = new PrintScoreForm();
            printScoreForm.Show(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MainForm1 mainForm = new MainForm1();
            mainForm.Show(this);
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            StudentPage studentPage = new StudentPage();
            studentPage.Show(this);
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            CoursePage coursePage = new CoursePage();
            coursePage.Show(this);
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_BackColorChanged(object sender, EventArgs e)
        {

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

        private void ScorePage_Load(object sender, EventArgs e)
        {

        }
    }
}
