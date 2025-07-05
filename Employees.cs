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
    public partial class Employees : Form
    {
        Functions connectionFunc;
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

                    string query = "INSERT INTO EmployeeTbl VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')";
                    query = string.Format(query, employeeName, gender,
                        departmentName, dateOfBirth, joinDate, salary); // Fixing the string formatting
                    connectionFunc.SetData(query);
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
                    string query = "DELETE FROM EmployeeTbl WHERE EmpId = {0}";
                    query = string.Format(query, Key); // Fixing the string formatting
                    connectionFunc.SetData(query);
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

                    string query = "UPDATE EmployeeTbl set VALUES EmpName = '{0}',EmpGen = '{1}'," +
                        "EmpDep = '{2}',EmpDOB = '{3}',EmpJDate = '{4}',EmpSal = '{5}' WHERE EmpId = {6}";
                    query = string.Format(query, employeeName, gender,
                        departmentName, dateOfBirth, joinDate, salary, Key); // Fixing the string formatting
                    connectionFunc.SetData(query);
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
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
