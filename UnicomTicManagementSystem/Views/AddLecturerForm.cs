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
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;
using static UnicomTicManagementSystem.Controllers.LecturerController;

namespace UnicomTicManagementSystem.Views
{
    public partial class AddLecturerForm : Form
    {
        private bool isEditMode = false;
        private Lecturer editingLecturer;
        public bool IsViewMode { get; set; } = false;

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

        private void AddLecturerForm_Load(object sender, EventArgs e)
        {
            LoadSubjectsToChecklist();
            

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

                
            }

            if (isEditMode)
            {
                LoadLecturerData(); //  Only AFTER subjects are loaded
            }
            else
            {
                txtUsername.Text = LecturerController.GenerateUsername();
                txtPassword.Text = LecturerController.GeneratePassword();
            }
            if (IsViewMode)
            {
                if (!isEditMode)
                {
                    MessageBox.Show("Cannot view a lecturer without edit mode data.");
                    this.Close();
                    return;
                }
                LecturerData();//load again in view mode just to be safe
                //LockFields(); //your custom method that disables all controls

                // Already loaded above in edit mode, no need to reload
                txtName.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtPhone.ReadOnly = true;
                clbSubjects.Enabled = false;
                btnSave.Visible = false;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtPassword.UseSystemPasswordChar = true;
            }


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

        private void LecturerData()
        {
            if (editingLecturer == null) return;

            // 1️⃣ Load basic info
            txtName.Text = editingLecturer.Name;
            txtAddress.Text = editingLecturer.Address;
            txtEmail.Text = editingLecturer.Email;
            txtPhone.Text = editingLecturer.Phone;

            // 2️⃣ Load assigned subjects
            var subjectIds = LecturerController.GetLecturerSubjectIds(editingLecturer.LecturerID);
            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                if (clbSubjects.Items[i] is ComboBoxItem item)
                {
                    if (subjectIds.Contains(item.Value))
                    {
                        clbSubjects.SetItemChecked(i, true);
                    }
                }
            }

            // 3️⃣ Load login info
            txtUsername.Text = editingLecturer.Username;
            txtPassword.Text = editingLecturer.Password;

            // 4️⃣ Lock login fields (view or edit mode handles visibility)
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = true;
        }

        private void LoadSubjectsToChecklist()
        {
            clbSubjects.Items.Clear();

            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"SELECT s.SubjectID, s.SubjectName, c.CourseName
                 FROM Subjects s
                 JOIN Courses c ON s.CourseID = c.CourseID";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string subjectName = rdr["SubjectName"].ToString();
                string courseName = rdr["CourseName"].ToString();
                string displayText = $"{subjectName} ({courseName})";
                string subjectId = rdr["SubjectID"].ToString();

                var item = new ComboBoxItem(displayText, subjectId);
                clbSubjects.Items.Add(item);
            }

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
            bool isValid = true;
            if (!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text = "Invalid email address format.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmailError.Visible = false;


            }
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^(07|021)\d{8}$"))
            {
                lblPhoneError.Text = "Phone number must start with 07 or 021 and be 10 digits";
                lblPhoneError.Visible = true;
                isValid = false;
            }
            else
            {
                lblPhoneError.Visible = false;
            }
            if (!isValid)
                return;

            var selectedSubjects = new List<string>();
            foreach (var item in clbSubjects.CheckedItems)
            {
                if (item is ComboBoxItem subjectItem)
                {
                    selectedSubjects.Add(subjectItem.Value);
                }
            }

            if (selectedSubjects.Count == 0)
            {
                MessageBox.Show("Please select at least one subject for the lecturer.");
                return;
            }

            var lecturer = new Lecturer
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            bool success = false;

            if (isEditMode)
            {
                lecturer.LecturerID = editingLecturer.LecturerID;
                success = LecturerController.UpdateLecturer(lecturer, selectedSubjects);
                MessageBox.Show(success ? "✅ Lecturer updated!" : "❌ Update failed.");
                if (success) this.Close();
            }
            else
            {
                success = LecturerController.CreateLecturer(lecturer, txtUsername.Text, txtPassword.Text, selectedSubjects);
                MessageBox.Show(success ? "✅ Lecturer added!" : "❌ Add failed.");
                if (success) ClearForm();
            }
        }


        private void LoadLecturerData()
        {
            txtName.Text = editingLecturer.Name;
            txtAddress.Text = editingLecturer.Address;
            txtEmail.Text = editingLecturer.Email;
            txtPhone.Text = editingLecturer.Phone;

            var subjectIds = LecturerController.GetLecturerSubjectIds(editingLecturer.LecturerID);
            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                var item = clbSubjects.Items[i] as ComboBoxItem;
                if (item != null && subjectIds.Contains(item.Value))
                {
                    clbSubjects.SetItemChecked(i, true);
                }
            }

            txtUsername.Text = editingLecturer.Username;
            txtPassword.Text = editingLecturer.Password;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = false;
        }
        private void ClearForm()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            
            for (int i = 0; i < clbSubjects.Items.Count; i++)
            {
                clbSubjects.SetItemChecked(i, false);
            }
            txtUsername.Text = LecturerController.GenerateUsername();
            txtPassword.Text = LecturerController.GeneratePassword();
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtPassword.UseSystemPasswordChar = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form and return to the previous screen
        }

        private void clbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

