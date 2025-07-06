using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Employees : Form
    {
        Functions connectionFunc;
        string stringConnection = "Data Source=localhost\\SqlExpress;Initial " +
            "Catalog=ManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Employees()
        {
            InitializeComponent();
            connectionFunc = new Functions();
            Employees_Load();
            GetDepartment();
        }
        private void Employees_Load()
        {
            string query = "SELECT * FROM EmployeeTbl";
            EmployeeList.DataSource = connectionFunc.GetData(query);
        }
        private void GetDepartment()
        {
            string query = "SELECT * FROM DepartmentTbl";
            EmployeeDepartmentCb.DisplayMember = "DepName";
            EmployeeDepartmentCb.ValueMember = "DepId";
            EmployeeDepartmentCb.DataSource = connectionFunc.GetData(query);
        }
        private void btnAddToEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameTb.Text == "" || EmployeeGenderCb.SelectedIndex == -1
                    || EmployeeDepartmentCb.SelectedIndex == -1 || EmployeeSalaryTb.Text == "")
                {
                    MessageBox.Show("All fields are required.");
                }
                else
                {
                    string employeeName = EmployeeNameTb.Text;
                    string gender = EmployeeGenderCb.SelectedItem.ToString();
                    string departmentName = EmployeeDepartmentCb.SelectedValue.ToString();
                    string dateOfBirth = EmployeeDateBirthTp.Value.ToString("yyyy-MM-dd");
                    string joinDate = EmployeeJoinDateTp.Value.ToString("yyyy-MM-dd");
                    int salary = Convert.ToInt32(EmployeeSalaryTb.Text);

                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpDep, EmpDOB, EmpJDate, EmpSal) " +
                            "VALUES (@EmpName, @EmpGen, @EmpDep, @EmpDOB, @EmpJDate, @EmpSal)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmpName", employeeName);
                            command.Parameters.AddWithValue("@EmpGen", gender);
                            command.Parameters.AddWithValue("@EmpDep", departmentName);
                            command.Parameters.AddWithValue("@EmpDOB", dateOfBirth);
                            command.Parameters.AddWithValue("@EmpJDate", joinDate);
                            command.Parameters.AddWithValue("@EmpSal", salary);

                            connection.Open();
                            command.ExecuteNonQuery(); // Execute the insert command
                            connection.Close(); // Close the connection after executing the command
                        }
                    }

                    Employees_Load();
                    MessageBox.Show("Employee Added Successfully");

                    // Clear the input fields after adding
                    EmployeeNameTb.Text = "";
                    EmployeeGenderCb.SelectedIndex = -1; 
                    EmployeeDepartmentCb.SelectedIndex = -1; 
                    EmployeeSalaryTb.Text = ""; 

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDeleteToEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Missing Data");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "DELETE FROM EmployeeTbl WHERE EmpId = @EmpId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmpId", Key);
                            connection.Open();
                            command.ExecuteNonQuery(); // Execute the delete command
                            connection.Close(); // Close the connection after executing the command
                        }
                    }


                    Employees_Load();
                    MessageBox.Show("Employee Deleted Successfully");

                    EmployeeNameTb.Text = ""; // Clear the input field after adding
                    EmployeeGenderCb.SelectedIndex = -1; // Clear the selection
                    EmployeeDepartmentCb.SelectedIndex = -1; // Clear the selection
                    EmployeeSalaryTb.Text = ""; // Clear the salary field

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void btnUpdateToEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmployeeNameTb.Text == "" || EmployeeGenderCb.SelectedIndex == -1
                    || EmployeeDepartmentCb.SelectedIndex == -1 || EmployeeSalaryTb.Text == "")
                {
                    MessageBox.Show("Department Name is required");
                }
                else
                {
                    string employeeName = EmployeeNameTb.Text;
                    string gender = EmployeeGenderCb.SelectedItem.ToString();
                    string departmentName = EmployeeDepartmentCb.SelectedValue.ToString();
                    string dateOfBirth = EmployeeDateBirthTp.Value.ToString("yyyy-MM-dd");
                    string joinDate = EmployeeJoinDateTp.Value.ToString("yyyy-MM-dd");
                    int salary = Convert.ToInt32(EmployeeSalaryTb.Text);

                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = @"UPDATE EmployeeTbl SET 
                        EmpName = @EmpName,
                        EmpGen = @EmpGen,
                        EmpDep = @EmpDep,
                        EmpDOB = @EmpDOB,
                        EmpJDate = @EmpJDate,
                        EmpSal = @EmpSal
                        WHERE EmpId = @EmpId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@EmpName", employeeName);
                            command.Parameters.AddWithValue("@EmpGen", gender);
                            command.Parameters.AddWithValue("@EmpDep", departmentName);
                            command.Parameters.AddWithValue("@EmpDOB", dateOfBirth);
                            command.Parameters.AddWithValue("@EmpJDate", joinDate);
                            command.Parameters.AddWithValue("@EmpSal", salary);
                            command.Parameters.AddWithValue("@EmpId", Key);

                            connection.Open();
                            command.ExecuteNonQuery(); // Execute the update command
                            connection.Close(); // Close the connection after executing the command
                        }
                    }

                    Employees_Load();
                    MessageBox.Show("Employee Added Successfully");
                    EmployeeNameTb.Text = ""; // Clear the input field after adding
                    EmployeeGenderCb.SelectedIndex = -1; // Clear the selection
                    EmployeeDepartmentCb.SelectedIndex = -1; // Clear the selection
                    EmployeeSalaryTb.Text = ""; // Clear the salary field

                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs index)
        {
            if (index.RowIndex >= 0) // Ensure a valid row index
            {
                DataGridViewRow row = EmployeeList.Rows[index.RowIndex];
                EmployeeNameTb.Text = row.Cells[1].Value.ToString(); // Assuming the second column is the department name
                EmployeeGenderCb.Text = row.Cells[2].Value.ToString();
                EmployeeDepartmentCb.SelectedValue = row.Cells[3].Value.ToString(); // Assuming the third column is the department ID
                EmployeeDateBirthTp.Value = Convert.ToDateTime(row.Cells[4].Value); // Assuming the fourth column is the date of birth
                EmployeeJoinDateTp.Value = Convert.ToDateTime(row.Cells[5].Value); // Assuming the fifth column is the join date
                EmployeeSalaryTb.Text = row.Cells[6].Value.ToString(); // Assuming the sixth column is the salary

                if (EmployeeNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value); // Assuming the first column is the department ID
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide(); // Hide the current form
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Employees empForm = new Employees();
            empForm.Show();
            this.Hide(); // Hide the current form
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Departments empForm = new Departments();
            empForm.Show();
            this.Hide(); // Hide the current form
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Salaries empForm = new Salaries();
            empForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
