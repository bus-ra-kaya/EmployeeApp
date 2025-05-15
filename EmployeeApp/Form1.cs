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
using System.Linq.Expressions;

namespace EmployeeApp
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Büşü\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30;");

        public Form1()

        {
            InitializeComponent();

            this.AcceptButton = loginButton;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            L_Password.PasswordChar = L_ShowPass.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (L_Username.Text == "" || L_Password.Text == "")
            {
                MessageBox.Show("Please fill in all the blank fields.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM users WHERE username = @username AND password = @password";

                        using(SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", L_Username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", L_Password.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Login successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                MainForm mForm = new MainForm();
                                mForm.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
                
            }
       
        }

       private void label5_Click(object sender, EventArgs e)
       {

       }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
            this.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
