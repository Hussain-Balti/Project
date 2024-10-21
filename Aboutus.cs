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
    public partial class Aboutus : Form
    {
        public Aboutus()
        {
            InitializeComponent();
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
            ScorePage scorePage = new ScorePage();
            scorePage.Show(this);
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ContactPage cp = new ContactPage();
            cp.Show(this);
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
