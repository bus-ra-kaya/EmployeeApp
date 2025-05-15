using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            salary1.Visible = true;
            addEmployee2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dashboard1.Visible = false;
            salary1.Visible = false;
            addEmployee2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void signoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            salary1.Visible = false;
            addEmployee2.Visible = false;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}