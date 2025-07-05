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
            EmployeeDepartmentCb.DisplayMember = connectionFunc.GetData(query).Columns["DepName"].ToString();
            EmployeeDepartmentCb.ValueMember = connectionFunc.GetData(query).Columns["DepId"].ToString();
            EmployeeDepartmentCb.DataSource = connectionFunc.GetData(query);
        }
        private void btnAddToEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
