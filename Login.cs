namespace Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text == "" || tbPassword.Text == "")
            {
                MessageBox.Show("Please enter both username and password.");
            }
            else if (tbUsername.Text == "Admin" && tbPassword.Text == "password")
            {
                MessageBox.Show("Login Successful");
                this.Hide();
                Employees mainForm = new Employees();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                tbUsername.Text = "";
                tbPassword.Text = "";
            }
        }

        private void resetLbl_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
