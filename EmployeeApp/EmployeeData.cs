using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeApp
{
    public class EmployeeData
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Phone { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public string Image { get; set; }
        public string Branch { get; set; }
        public string AddDate { get; set; }
        public string UpdateDate { get; set; }



        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Büşü\OneDrive\Belgeler\employee.mdf;Integrated Security=True;Connect Timeout=30;");

        public List<EmployeeData> employeeListData()
        {
            List<EmployeeData> listdata = new List<EmployeeData>();

            try {
                connect.Open();

                string selectData = "SELECT * FROM employees";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        EmployeeData edata = new EmployeeData();

                        edata.ID = (int)reader["id"];
                        edata.Name = reader["full_name"].ToString();
                        edata.Gender = reader["gender"].ToString();
                        edata.Phone = (int)reader["phone_number"];
                        edata.Position = reader["position"].ToString();
                        edata.Salary = reader["salary"] != DBNull.Value ? Convert.ToSingle(reader["salary"]) : 0;
                        edata.Image = reader["photo"].ToString();
                        edata.Branch = reader["branch"].ToString();
                        listdata.Add(edata);

                    }
                }

            }
            catch (Exception ex) {
                Console.WriteLine("Error" + ex);
            }
            finally {
                connect.Close();

            }
        
            return listdata;
        }
               
                
    }
}
