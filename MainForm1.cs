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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            StudentPage stp  = new StudentPage();
            stp.Show(this);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
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

        private int imageNumber = 1;
        private void loadNextImage()
        {
            if(imageNumber == 10)
            {
                imageNumber = 1;
            }
            slidePic.ImageLocation = string.Format(@"Images\{0}.jpg",imageNumber);
            imageNumber++;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
