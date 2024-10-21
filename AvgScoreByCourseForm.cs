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
    public partial class AvgScoreByCourseForm : Form
    {
        public AvgScoreByCourseForm()
        {
            InitializeComponent();
        }

        private void AvgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with average score by course
            SCORE score = new SCORE();
            dataGridView1.DataSource = score.avgScoreByCourse();
        }
    }
}
