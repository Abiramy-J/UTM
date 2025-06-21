using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;
using static UnicomTicManagementSystem.Controllers.LecturereController;

namespace UnicomTicManagementSystem.Views
{
    public partial class AddLecturerForm : Form
    {
        private bool isEditMode = false;
        private Lecturer editingLecturer;

        public AddLecturerForm()
        {
            InitializeComponent();
        }
        public AddLecturerForm(Lecturer lecturerToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            editingLecturer = lecturerToEdit;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text) ||
            string.IsNullOrWhiteSpace(txtEmail.Text) ||
            string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!Regex.IsMatch(txtPhone.Text, @"^(07|021)\d{8}$"))
            {
                MessageBox.Show("Phone number must start with 07 or 021 and be 10 digits.");
                return;
            }

            if (!Regex.IsMatch(txtEmail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format.");
                return;
            }

            if (cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject or if u are not create one click BACK and please create them in Manage Course and subject.");
                return;
            }

            var lecturer = new Lecturer
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim(),
                SubjectID = cmbSubject.SelectedValue.ToString()

            };

            if (isEditMode)
            {
                lecturer.LecturerID = editingLecturer.LecturerID;
                bool updated = LecturerController.UpdateLecturer(lecturer);
                MessageBox.Show(updated ? "✅ Lecturer updated!" : "❌ Update failed.");
                if (updated) this.Close();
            }
            else
            {
                bool added = LecturerController.CreateLecturer(lecturer, txtUsername.Text, txtPassword.Text);
                MessageBox.Show(added ? "✅ Lecturer added!" : "❌ Add failed.");
                if (added) ClearForm();
            }
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            cmbSubject.SelectedIndex = -1;
            txtUsername.Text = LecturerController.GenerateUsername();
            txtPassword.Text = LecturerController.GeneratePassword();
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = false;
        }



        private void AddLecturerForm_Load(object sender, EventArgs e)
        {
            LoadSubjects(); // 🔥 This MUST come FIRST

            if (!HasAnySubjects())
            {
                MessageBox.Show("No subjects found. Please add subjects first!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ManageCourse_SubjectForm manageForm = new ManageCourse_SubjectForm();
                manageForm.ShowDialog();

                if (!HasAnySubjects())
                {
                    MessageBox.Show("Still no subjects. Closing form.");
                    this.Close();
                    return;
                }

                LoadSubjects(); // 🔁 Reload after adding subjects
            }

            if (isEditMode)
            {
                LoadLecturerData(); // ✅ Only AFTER subjects are loaded
            }
            else
            {
                txtUsername.Text = LecturerController.GenerateUsername();
                txtPassword.Text = LecturerController.GeneratePassword();
            }
        }

        private void LoadSubjects()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT SubjectID, SubjectName FROM Subjects";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();

            var subjectList = new List<ComboBoxItem>();
            while (rdr.Read())
            {
                string name = rdr["SubjectName"].ToString();
                string id = rdr["SubjectID"].ToString();

               

                subjectList.Add(new ComboBoxItem(name, id));
            }

            cmbSubject.DataSource = subjectList;
            cmbSubject.DisplayMember = "Text";
            cmbSubject.ValueMember = "Value";

            
        }



        private bool HasAnySubjects()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM Subjects";
            using var cmd = new SQLiteCommand(query, conn);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

        private void LoadLecturerData()
        {
            

            txtName.Text = editingLecturer.Name;
            txtAddress.Text = editingLecturer.Address;
            txtEmail.Text = editingLecturer.Email;
            txtPhone.Text = editingLecturer.Phone;

            cmbSubject.SelectedValue = editingLecturer.SubjectID; // <- Now works if ComboBox is loaded

            

            txtUsername.Text = editingLecturer.Username;
            txtPassword.Text = editingLecturer.Password;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and return to the previous screen
        }
    }
}

