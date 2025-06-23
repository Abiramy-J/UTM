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
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTicManagementSystem.Views
{
    public partial class ChangePassword : Form
    {
        private string username; // Store the username of the logged-in user
        public ChangePassword()
        {
            InitializeComponent();
            username = AppSession.Username;  // Get logged-in user from session
            txtU.Text = username;           // Show username in textbox
            txtU.ReadOnly = true;           // Lock username so no edits allowed
            lblValidation.Visible = false;  // Hide validation label initially
        }


        private void lblP_Click(object sender, EventArgs e)
        {

        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private async void btnCP_Click(object sender, EventArgs e)
        {
            //string username = txtU.Text.Trim();
            string oldPassword = txtCP.Text;
            string newPassword = txtNP.Text;
            string confirmPassword = txtP.Text;

            if (string.IsNullOrEmpty(oldPassword) ||
                string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                await ShowValidationMessage("⚠️ All fields are required!");
                return;
            }


            if (newPassword.Length < 6 || newPassword.Length > 12)
            {
                await ShowValidationMessage("❗ Password must be 6–12 characters, with letters and numbers.");
                return;
            }
            if (newPassword == oldPassword)
            {
                await ShowValidationMessage("❌ Your new password and old passwords cannot be same!");
                return;
            }

            if (newPassword != confirmPassword)
            {
                await ShowValidationMessage("❌ Passwords do not match!");
                return;
            }

            bool isSuccess = UserController.ChangePassword(username, oldPassword, newPassword);
            if (isSuccess)
                await ShowSuccessMessage("✅ Password changed successfully!");
            else
                await ShowValidationMessage("❌ Incorrect username or current password!");
        }



        //  Show error (red label)
        private async Task ShowValidationMessage(string message)
        {
            lblValidation.Text = message;
            //lblValidation.ForeColor = System.Drawing.Color.Red;
            lblValidation.Visible = true;

            await Task.Delay(3000); // wait 3 seconds

            lblValidation.Visible = false;
        }

        // Show success (green label)
        private async Task ShowSuccessMessage(string message)
        {
            lblValidation.Text = message;
            lblValidation.ForeColor = System.Drawing.Color.Green;
            lblValidation.Visible = true;

            await Task.Delay(3000);

            lblValidation.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
    

