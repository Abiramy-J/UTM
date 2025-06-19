using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class AddStaffForm : Form
    {
        private bool isEditMode = false;
        private Staff editingStaff;

        public AddStaffForm()
        {
            InitializeComponent();

        }
        public AddStaffForm(Staff staffToEdit) // Edit Mode
        {
            InitializeComponent();
            isEditMode = true;
            editingStaff = staffToEdit;
            LoadStaffDataIntoForm();

        }
        private void LoadFormDefaults()
        {
            txtUsername.Text = StaffController.GenerateUsername();
            txtPassword.Text = StaffController.GeneratePassword();
           // txtPassword.UseSystemPasswordChar = true; // Optional: hides password like ●●●
        }

        private void LoadStaffDataIntoForm()
        {
            if (editingStaff == null) return;

            txtName.Text = editingStaff.Name;
            txtAddress.Text = editingStaff.Address;
            txtEmail.Text = editingStaff.Email;
            txtPhone.Text = editingStaff.Phone;
            txtUsername.Text = editingStaff.username;
            txtPassword.Text = "Hidden";

            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill in all staff details.");
                return;
            }

            // Phone number validation (10–15 digits only)
            if (!Regex.IsMatch(txtPhone.Text, @"^(07|021)\d{8}$"))
            {
                MessageBox.Show("Phone number must start with 07 or 021 and be 10 digits.");
                return;
            }


            // Email format validation
            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }

            // Model
            var staff = new Staff
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            if (isEditMode)
            {
                staff.StaffID = editingStaff.StaffID;
                bool updated = StaffController.UpdateStaff(staff);
                if (updated)
                {
                    MessageBox.Show("✅ Staff updated!");
                    this.Close();
                }
                else MessageBox.Show("❌ Update failed.");
            }
            else
            {
                bool added = StaffController.AddStaff(staff, txtUsername.Text, txtPassword.Text);
                if (added)
                {
                    MessageBox.Show("✅ Staff added!");
                    ClearForm();
                }
                else MessageBox.Show("❌ Add failed.");
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            LoadFormDefaults();
            txtUsername.Text = StudentController.GenerateUsername();
            txtPassword.Text = StudentController.GeneratePassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStaffForm_Load(object sender, EventArgs e)
        {
            if (!isEditMode)
                LoadFormDefaults();
        }
    }

}
