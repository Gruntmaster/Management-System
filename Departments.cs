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
    public partial class Departments : Form
    {
        Functions connectionFunc;
        string stringConnection = "Data Source=localhost\\SqlExpress;Initial " +
            "Catalog=ManagementSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Departments()
        {
            InitializeComponent();
            connectionFunc = new Functions();
            Departments_Load();
        }
        private void Departments_Load()
        {
            string query = "SELECT * FROM DepartmentTbl";
            DepList.DataSource = connectionFunc.GetData(query);
        }

        private void btnAddToDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department Name is required");
                }
                else
                {
                    string departmentName = DepartNameTb.Text;

                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "INSERT INTO DepartmentTbl (DepName) VALUES (@DepName)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DepName", departmentName);
                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                    }

                    Departments_Load();
                    MessageBox.Show("Department Added Successfully");
                    DepartNameTb.Text = ""; // Clear the input field after adding
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0; // Variable to store the selected department ID
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs index)
        {
            if (index.RowIndex >= 0) // Ensure a valid row index
            {
                DataGridViewRow row = DepList.Rows[index.RowIndex];
                DepartNameTb.Text = row.Cells[1].Value.ToString(); // Assuming the second column is the department name

                if (DepartNameTb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value); // Assuming the first column is the department ID
                }
            }
        }

        private void btnUpdateToDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department Name is required");
                }
                else
                {
                    string departmentName = DepartNameTb.Text;
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "UPDATE DepartmentTbl SET DepName = @DepName WHERE DepId = @DepId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DepName", departmentName);
                            command.Parameters.AddWithValue("@DepId", Key); // Use the Key variable to specify the department ID

                            connection.Open();
                            command.ExecuteNonQuery();
                        }
                        Departments_Load();
                        MessageBox.Show("Department Updated Successfully");
                        DepartNameTb.Text = ""; // Clear the input field after adding
                    }
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void btnDeleteToDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department Name is required");
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(stringConnection))
                    {
                        string query = "DELETE FROM DepartmentTbl WHERE DepId = @DepId";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@DepId", Key);
                            connection.Open();
                            command.ExecuteNonQuery(); // Execute the delete command
                            connection.Close(); // Close the connection after executing the command
                        }
                    }
                    Departments_Load();
                    MessageBox.Show("Department Deleted Successfully");
                    DepartNameTb.Text = ""; // Clear the input field after adding
                }
            }
            catch (Exception Ex)
            {

                MessageBox.Show(Ex.Message);
            }
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees empForm = new Employees();
            empForm.Show();
            this.Hide(); // Hide the current form
        }

        private void salaryLbl_Click(object sender, EventArgs e)
        {
            Salaries salaries = new Salaries();
            salaries.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide(); // Hide the current form
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Departments empForm = new Departments();
            empForm.Show();
            this.Hide(); // Hide the current form
        }
    }
}
