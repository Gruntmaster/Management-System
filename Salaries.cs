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

        int Key = 0; // Variable to store the selected employee ID
        string period = ""; // Variable to store the selected period
        private void GetSalaries()
        {
            string query = "SELECT * from EmployeeTbl WHERE EmpId = {0}";
            query = string.Format(query, employeeNameCb.SelectedValue.ToString());
            foreach (DataRow dataRow in connectionFunc.GetData(query).Rows)
            {
                Key = Convert.ToInt32(dataRow["EmpSal"].ToString());
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

        private void btnAddToSalary_Click(object sender, EventArgs e)
        {
            try
            {
                if(employeeNameCb.SelectedIndex == -1 || periodTp.Text == "" || daysAttendedTb.Text == "")
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    period = periodTp.Value.Date.Month.ToString() + "-" + periodTp.Value.Date.Year.ToString();
                    int amount = Key * Convert.ToInt32(daysAttendedTb.Text);
                    int daysAttended = Convert.ToInt32(daysAttendedTb.Text);

                    string query = "INSERT INTO SalaryTbl VALUES ({0},{1},{2},'{3}',{4},'{5}')";
                    query = string.Format(query, employeeNameCb.SelectedValue.ToString(), 
                        daysAttended, period, amount, DateTime.Today.Date);
                    connectionFunc.SetData(query);
                    ShowSalaries();
                    MessageBox.Show("Salary Paid!");
                    daysAttendedTb.Text = ""; // Clear the input field after adding
                }               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
