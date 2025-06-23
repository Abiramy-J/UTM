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
    public partial class CreateAdmin : Form
    {
        public CreateAdmin()
        {
            InitializeComponent();
        }

        private void btnCreateAdmin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtCPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Fill all fields, please.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (password.Length < 6 || password.Length > 12)
            {
                MessageBox.Show("Password must be 6 to 12 characters.");
                return;
            }

            // Optionally: Check password complexity here (letters and numbers)

            bool created = UserController.CreateAdmin(username, password);
            if (created)
            {
                MessageBox.Show("Admin created successfully!");
                ClearForm();
                LoadAdminsToGrid();
            }
            else
            {
                MessageBox.Show("Username already exists or error occurred.");
            }
        }

        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtCPassword.Clear();
        }

        private void LoadAdminsToGrid()
        {
            dgvAdmin.Rows.Clear();
            dgvAdmin.Columns.Clear();

            dgvAdmin.Columns.Add("UserId", "ID");
            dgvAdmin.Columns.Add("Username", "Username");
            dgvAdmin.Columns.Add("PasswordName", "Password"); // Optional, if you want to show passwords

            var admins = UserController.GetAllAdmins();
            foreach (var admin in admins)
            {
                dgvAdmin.Rows.Add(admin.UserId, admin.Username, admin.Password);
            }
        }


        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvAdmin.Rows[e.RowIndex];

                txtUsername.Text = row.Cells["UserName"].Value.ToString();
                txtPassword.Text = row.Cells["PasswordName"].Value.ToString();

            }
        }


        private void dgvAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CreateAdmin_Load(object sender, EventArgs e)
        {
            LoadAdminsToGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
