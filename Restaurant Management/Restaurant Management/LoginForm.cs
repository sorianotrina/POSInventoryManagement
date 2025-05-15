using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "password")
            {
                // Open the next form (e.g., MainForm)
                MessageDialog2.Show("You're successfully logged in.");
                mainForm mainForm = new mainForm();
                mainForm.Show();

                // Optionally hide the login form
                this.Hide();
            }
            else
            {
                // Show an error message if login fails
                MessageDialog1.Show("Invalid username or password.");
            }
        }
    }
}
