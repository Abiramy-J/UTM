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
using System.Xml.Linq;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class AddStudentForm : Form
    {
        private bool isEditMode = false;
        private Student editingStudent;
        // Default constructor → used when adding a new student
        public AddStudentForm()
        {
            InitializeComponent();
            
        }
        // Overloaded constructor → used for editing an existing student
        public AddStudentForm(Student studentToEdit)
        {
            InitializeComponent();
            
            isEditMode = true;
            editingStudent = studentToEdit;
            LoadStudentDataIntoForm();
        }

        private void LoadFormDefaults()
        {
            // Clear gender to prevent duplicates
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });

            // Clear courses before loading
            cmbCourse.Items.Clear();

            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbCourse.Items.Add(new ComboBoxItem(
                    rdr["CourseName"].ToString(),
                    rdr["CourseID"].ToString()));
            }
        }
        

        private void LoadStudentDataIntoForm()
        {
            if (editingStudent == null) return;

            txtFullname.Text = editingStudent.Name;
            txtAddress.Text = editingStudent.Address;
            txtMail.Text = editingStudent.Email;
            txtPhoneNo.Text = editingStudent.Phone;
            dtpDOB.Value = editingStudent.DOB;
            cmbGender.Text = editingStudent.Gender;

            foreach (ComboBoxItem item in cmbCourse.Items)
            {
                if (item.Value == editingStudent.CourseID)
                {
                    cmbCourse.SelectedItem = item;
                    break;
                }
            }

            txtUsername.Text = editingStudent.Username;
            txtPw.Text = "Hidden";
            txtUsername.ReadOnly = true;
            txtPw.ReadOnly = true;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            LoadFormDefaults();

            if (!HasAnyCourses())
            {
                MessageBox.Show("No courses found! Redirecting you to Manage Courses to add some.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open ManageCourseForm
                var manageCourseForm = new ManageCourse_SubjectForm();
                
                manageCourseForm.Show();

                // Close or hide this AddStudentForm
                this.Hide();
                return;
            }
            if (!isEditMode)
            {
                txtUsername.Text = StudentController.GenerateUsername();
                txtPw.Text = StudentController.GeneratePassword();
            }
        }
        private bool HasAnyCourses()
        {
            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = "SELECT COUNT(*) FROM Courses";
            using var cmd = new SQLiteCommand(query, conn);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            // Basic field validations
            if (string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please fill in all the student details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Phone number validation (10–15 digits only)
            if (!Regex.IsMatch(txtPhoneNo.Text, @"^(07|021)\d{8}$"))
            {
                MessageBox.Show("Phone number must start with 07 or 021 and be 10 digits.");
                return;
            }


            // Email format validation
            if (!Regex.IsMatch(txtMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }

            // Gender validation
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a gender.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Course validation
            if (cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a course.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Creating student object
            var student = new Student
            {
                Name = txtFullname.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Email = txtMail.Text.Trim(),
                Phone = txtPhoneNo.Text.Trim(),
                DOB = dtpDOB.Value,
                Gender = cmbGender.Text,
                CourseID = ((ComboBoxItem)cmbCourse.SelectedItem).Value

            };

            if (isEditMode)
            {
                student.StudentID = editingStudent.StudentID;
                bool updated = StudentController.UpdateStudents(student);
                if (updated)
                {
                    MessageBox.Show("✅ Student updated successfully!");
                    this.Close(); // Close after editing
                }
                else
                {
                    MessageBox.Show("❌ Failed to update student.");
                }
            }
            else
            {
                bool added = StudentController.CreateStudent(student, txtUsername.Text, txtPw.Text);
                if (added)
                {
                    MessageBox.Show("✅ Student added successfully!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("❌ Failed to add student.");
                }
            }
        }

        private void ClearForm()
        {
            txtFullname.Clear();
            txtAddress.Clear();
            txtMail.Clear();
            txtPhoneNo.Clear();
            cmbGender.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
            txtUsername.Text = StudentController.GenerateUsername();
            txtPw.Text = StudentController.GeneratePassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Add Student Form
        }
        
    }


}


  
