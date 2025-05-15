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
using System.IO;

namespace EmployeeApp
{
    public partial class AddEmployee : UserControl
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Büşü\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30;");
        public AddEmployee()
        {
            InitializeComponent();

            DisplayEmployeeData();

        }

        public void DisplayEmployeeData()
        {
            EmployeeData data = new EmployeeData();
            List<EmployeeData> listData = data.employeeListData();

            dataGridView1.DataSource = listData;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void newEmployeeAddBtn_Click(object sender, EventArgs e)
        {
            if(newEmployeeName.Text == "" 
                ||newEmployeeID.Text =="" 
                ||newEmployeePhone.Text =="" 
                ||newEmployeeGender.Text =="" 
                ||newEmployeePosition.Text =="" 
                ||newEmployeeBranch.Text == ""
                )
            { 
                MessageBox.Show("Please fill all blank fields.","Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                    try {
                        connect.Open();

                        string checkEmployeeID = "SELECT * FROM employees WHERE id= @id";
                        using (SqlCommand checkID = new SqlCommand(checkEmployeeID, connect))
                        {
                            checkID.Parameters.AddWithValue("@id", newEmployeeID.Text.Trim());
                            object result = checkID.ExecuteScalar();
                            int count =(result != null) ? Convert.ToInt32(result) : 0;
                            if (count >= 1) {
                                MessageBox.Show("User with this ID already exists.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string path = Path.Combine(@"C:\Users\Büşü\source\repos\EmployeeApp\EmployeeApp\Directory\" + newEmployeeID.Text.Trim() +".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(newEmployeePic.ImageLocation, path, true);

                                if (string.IsNullOrEmpty(newEmployeePic.ImageLocation))
                                {
                                    MessageBox.Show("Please add employee image.","Error Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }


                                DateTime today = DateTime.Now;
                                string addData = "INSERT INTO employees (id,full_name,gender,phone_number,position,branch,image,added_date) VALUES(@id,@full_name,@gender,@phone_number,@position,@branch,@image,@added_date)";

                                using (SqlCommand addEmployee = new SqlCommand(addData, connect))
                                {
                                    addEmployee.Parameters.AddWithValue("@id", newEmployeeID.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@full_name", newEmployeeName.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@gender", newEmployeeGender.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@phone_number", newEmployeePhone.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@position", newEmployeePosition.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@branch", newEmployeeBranch.Text.Trim());
                                    addEmployee.Parameters.AddWithValue("@image", path);
                                    addEmployee.Parameters.AddWithValue("@added_date", today);

                                    addEmployee.ExecuteNonQuery();

                                    DisplayEmployeeData();

                                    MessageBox.Show("Added successfully!","Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        
                    }
                    catch (Exception ex) {
                        MessageBox.Show("Error" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally {
                        connect.Close();
                    }

                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void newEmployeeImportBtn_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image files (*.jpg; *.png)|*.jpg;*.png";

                string imagePath = "";

                if (DialogResult.OK == dialog.ShowDialog())
                {

                    imagePath = dialog.FileName;
                    newEmployeePic.ImageLocation = imagePath;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
