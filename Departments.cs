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
                    string query = "INSERT INTO DepartmentTbl VALUES ('{0}')";
                    query = string.Format(query, departmentName); // Fixing the string formatting
                    connectionFunc.SetData(query);
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
                    string query = "UPDATE DepartmentTbl set DepName = '{0}' WHERE DepId = {1}";
                    query = string.Format(query, departmentName, Key); // Fixing the string formatting
                    connectionFunc.SetData(query);
                    Departments_Load();
                    MessageBox.Show("Department Updated Successfully");
                    DepartNameTb.Text = ""; // Clear the input field after adding
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
                    string query = "DELETE FROM DepartmentTbl WHERE DepId = {0}";
                    query = string.Format(query, Key); // Fixing the string formatting
                    connectionFunc.SetData(query);
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
