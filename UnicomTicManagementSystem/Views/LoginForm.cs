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
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            User user = UserController.Login(username, password);
            ;

            if (user == null)
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                return;
            }

            // ✅ Set session!
            AppSession.UserId = user.UserId;
            AppSession.Role = user.Role;
            AppSession.Username= user.Username;

            MessageBox.Show($"Welcome {user.Role}!");
            this.Hide();

            // Open the dashboard (you can still pass role if needed)
            var dashboard = new AdminDashboardForm(user.Role); // or use AppSession.Role directly inside
            dashboard.Show();
        }






        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
