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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        SCORE score = new SCORE();

        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            //populate the datagridview with student score
            dataGridView1.DataSource = score.getStudentsScore();
        }

        private void buttonRemoveScore_Click(object sender, EventArgs e)
        {
            //remove the selected score
            int studentId = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            int courseId = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());

            if (MessageBox.Show("Do you went to delete this score", "Remove Score", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (score.deleteScore(studentId,courseId))
                {
                    MessageBox.Show("Score delete", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = score.getStudentsScore();
                }
                else
                {
                    MessageBox.Show("Score not delete!", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
