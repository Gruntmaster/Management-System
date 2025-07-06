using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_System
{
    public partial class Salaries : Form
    {
        Functions connectionFunc;
        string stringConnection = "Data Source=localhost\\SqlExpress;Initial " +
            "Catalog=ManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Salaries()
        {
            InitializeComponent();
            connectionFunc = new Functions();
            ShowSalaries();
            GetEmployees();
        }
        private void GetEmployees()
        {
            string query = "SELECT * FROM EmployeeTbl";
            employeeNameCb.DisplayMember = "EmpName";
            employeeNameCb.ValueMember = "EmpId";
            employeeNameCb.DataSource = connectionFunc.GetData(query);
        }

        int daysSalary = 0; // Variable to store the selected employee ID
        string period = ""; // Variable to store the selected period
        private void GetSalaries()
        {
            string query = "SELECT * from EmployeeTbl WHERE EmpId = {0}";
            query = string.Format(query, employeeNameCb.SelectedValue.ToString());
            foreach (DataRow dataRow in connectionFunc.GetData(query).Rows)
            {
                daysSalary = Convert.ToInt32(dataRow["EmpSal"].ToString());
            }

            if (daysAttendedTb.Text == "")
            {
                salaryTb.Text = "Rs " + (daysAttended * daysSalary); // Calculate salary based on days attended and employee's salary
            }
            else if (Convert.ToInt32(daysAttendedTb.Text) > 31)
            {
                MessageBox.Show("Days attended cannot be more than 31 days in a month.");
            }
            else
            {
                daysAttended = Convert.ToInt32(daysAttendedTb.Text);
                salaryTb.Text = "Rs " + (daysAttended * daysSalary); // Calculate salary based on days attended and employee's salary
            }
        }
        private void ShowSalaries()
        {
            try
            {
                string query = "SELECT * FROM SalaryTbl";
                dataGridViewSalary.DataSource = connectionFunc.GetData(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridViewSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void employeeNameCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetSalaries();
        }

        int daysAttended = 1; // Variable to store the number of days attended
        private void btnAddToSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if (employeeNameCb.SelectedIndex == -1 || periodTp.Text == "" || daysAttendedTb.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    period = periodTp.Value.Date.Month.ToString() + "-" + periodTp.Value.Date.Year.ToString();
                    int amount = daysSalary * Convert.ToInt32(daysAttendedTb.Text);
                    int daysAttended = Convert.ToInt32(daysAttendedTb.Text);

                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "INSERT INTO SalaryTbl (Employee, Attendance, Period, Amount, PayDate) " +
                                       "VALUES (@Employee, @Attendance, @Period, @Amount, @PayDate)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Employee", employeeNameCb.SelectedValue);
                            command.Parameters.AddWithValue("@Attendance", daysAttended);
                            command.Parameters.AddWithValue("@Period", period);
                            command.Parameters.AddWithValue("@Amount", amount);
                            command.Parameters.AddWithValue("@PayDate", DateTime.Today.Date);

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        ShowSalaries();
                        MessageBox.Show("Salary Paid!");
                        daysAttendedTb.Text = ""; // Clear the input field after adding
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
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

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salaries empForm = new Salaries();
            empForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
