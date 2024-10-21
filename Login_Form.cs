using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student_Project
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("D:\\vp\\Student_Project\\Student_Project\\images\\user.png");

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MY_DB db = new MY_DB();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Login_Tab WHERE Username = @usn AND Password = @pass", db.getConnection());

            cmd.Parameters.Add("@usn", SqlDbType.VarChar).Value = textBoxUsername.Text;
            cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = textBoxPassword.Text;

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            else
                {
                    MessageBox.Show("Invalid Username or Password","Login Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

        }
    }
}
