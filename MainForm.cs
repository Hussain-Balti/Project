using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudentForm addStdf = new AddStudentForm(); 
            addStdf.Show(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentListForm stdListf = new StudentListForm();
            stdListf.Show(this);
        }

        private void editRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm upDelStdF = new UpdateDeleteStudentForm();
            upDelStdF.Show(this);
        }

        private void staticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm stcF = new StatisticForm();  
            stcF.Show(this);
        }

        private void manageStudentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentsForm mngStdF = new ManageStudentsForm();
            mngStdF.Show(this);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintStudentForm prStdF = new PrintStudentForm();
            prStdF.Show(this);
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm aCrsF = new AddCourseForm();
            aCrsF.Show(this);
        }

        private void manageCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm mngCrsF = new ManageCourseForm();
            mngCrsF.Show(this);
        }

        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RemoveCourseForm rmvCrseF = new RemoveCourseForm();
            rmvCrseF.Show(this);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintCourseForm prCrsF = new PrintCourseForm();
            prCrsF.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm prCrsF = new AddScoreForm();
            prCrsF.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm prCrsF = new RemoveScoreForm();
            prCrsF.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScoreForm manageScoreForm = new ManageScoreForm();
            manageScoreForm.Show(this);
        }

        private void averageScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvgScoreByCourseForm avgScr = new AvgScoreByCourseForm();
            avgScr.Show(this);
        }

        private void printToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PrintScoreForm printScoreForm = new PrintScoreForm();
            printScoreForm.Show(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void raafToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sTUDENTToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
