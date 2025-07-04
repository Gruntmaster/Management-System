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
                if(DepartNameTb.Text == "")
                {
                    MessageBox.Show("Department Name is required");
                }
                else
                {
                    string departmentName = DepartNameTb.Text;
                    string query = "INSERT INTO DepartmentTbl VALUES ('{0}')";
                    query = string.Format(DepartNameTb.Text, departmentName); // Fixing the string formatting
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
    }
}
