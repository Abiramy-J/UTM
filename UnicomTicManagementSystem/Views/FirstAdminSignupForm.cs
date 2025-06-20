using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class FirstAdminSignupForm : Form
    {
        public FirstAdminSignupForm()
        {
            InitializeComponent();
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (password.Length < 6 || password.Length > 12)
            {
                MessageBox.Show("Password must be 6 to 12 characters.");
                return;
            }

            if (!password.Any(char.IsDigit) || !password.Any(char.IsLetter))
            {
                MessageBox.Show("Password must contain both letters and numbers.");
                return;
            }

            bool success = UserController.CreateAdmin(username, password);

            if (success)
            {
                MessageBox.Show("Admin created successfully!");
                this.Hide();
                new LoginForm().Show();
            }
            else
            {
                MessageBox.Show("Username already exists or error occurred.");
            }
        }

        private void FirstAdminSignupForm_Load(object sender, EventArgs e)
        {

        }
    }

}
