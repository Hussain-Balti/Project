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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }
        Color panTotalColor;
        Color panMaleColor;
        Color panFemaleColor;
        private void labelTotal_Click(object sender, EventArgs e)
        {

        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            //get the panel color
            panTotalColor = panelTotal.BackColor;
            panMaleColor = panelMale.BackColor;
            panFemaleColor = panelFemale.BackColor;

            //display the value
            STUDENT student = new STUDENT();
            double totalStudents = Convert.ToDouble(student.totalStudent());
            double totalMaleStudent = Convert.ToDouble(student.totalMaleStudent());
            double totalFemaleStudent = Convert.ToDouble(student.totalFemaleStudent());

            //percentage
            double malePercentage = totalMaleStudent * 100/totalStudents;
            double femalePercentage = totalFemaleStudent * 100 / totalStudents;

            labelTotal.Text = "Total Student: " + totalStudents.ToString();
            labelMale.Text = "Male "+malePercentage.ToString("0.00") + "%";
            labelFemale.Text = "Female"+femalePercentage.ToString("0.00") + "%";
        }

        private void labelTotal_MouseEnter(object sender, EventArgs e)
        {
            panelTotal.BackColor = Color.White;
            labelTotal.ForeColor = panTotalColor;
        }

        private void labelTotal_MouseLeave(object sender, EventArgs e)
        {
            panelTotal.BackColor = panTotalColor;
            labelTotal.ForeColor = Color.White;
        }

        private void labelMale_MouseEnter(object sender, EventArgs e)
        {
            panelMale.BackColor = Color.White;
            labelMale.ForeColor = panMaleColor;
        }

        private void labelMale_MouseLeave(object sender, EventArgs e)
        {
            panelMale.BackColor = panMaleColor;
            labelMale.ForeColor = Color.White;
        }

        private void labelFemale_MouseEnter(object sender, EventArgs e)
        {
            panelFemale.BackColor = Color.White;
            labelFemale.ForeColor = panFemaleColor;
        }

        private void labelFemale_MouseLeave(object sender, EventArgs e)
        {
            panelFemale.BackColor = panFemaleColor;
            labelFemale.ForeColor = Color.White;
        }
    }
}
