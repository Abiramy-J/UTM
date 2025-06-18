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

            string role = UserController.Login(username, password);

            if (role == null)
            {
                MessageBox.Show("Invalid credentials. Please try again.");
                return;
            }

            MessageBox.Show($"Welcome {role}!");
            this.Hide();

            switch (role)
            {
                case "Admin":
                    new AdminDashboardForm().Show();
                    break;
                /* case "Student": new StudentDashboardForm().Show(); break;
                   case "Staff":   new StaffDashboardForm().Show(); break;
                   case "Lecturer":new LecturerDashboardForm().Show(); break; */
                default:
                    MessageBox.Show("Unknown role. Contact administrator.");
                    break;
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
