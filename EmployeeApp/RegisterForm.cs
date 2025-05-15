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
using System.Threading;

namespace EmployeeApp
{
    public partial class RegisterForm : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Büşü\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30;");

        public RegisterForm()
        {
            InitializeComponent();

            this.AcceptButton = R_signupButton;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void username_Click(object sender, EventArgs e)
        {

        }

        private void loginUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Form1 LoginForm = new Form1();
            LoginForm.Show();
            this.Hide();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void R_signupButton_Click(object sender, EventArgs e)
        {
            if (R_Username.Text == "" || R_Password.Text == "")
            {
                MessageBox.Show("Please fill in all the blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", R_Username.Text.Trim());
                            object result = checkUser.ExecuteScalar();
                            int count = (result != null) ? Convert.ToInt32(result) : 0;
                            if (count >=1 )
                            {

                                MessageBox.Show(R_Username.Text + " is already taken.", "Error Message" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                DateTime today = DateTime.Today;
                                string insertData = "INSERT INTO users" + "(username,password,registerDate)" + "VALUES (@username, @password, @dateReg)";

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", R_Username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@password", R_Password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@dateReg", today);

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Registered successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    Form1 loginForm = new Form1();
                                    loginForm.Show();
                                    this.Hide();
                                }
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

        private void loginShowPass_CheckedChanged(object sender, EventArgs e)
        {
            R_Password.PasswordChar = R_ShowPass.Checked ? '\0' : '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
