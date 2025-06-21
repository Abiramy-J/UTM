using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
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
            LoadFormDefaults();//FIRST load gender & course items
            LoadStudentDataIntoForm();//THEN apply selected items
        }

        private void LoadFormDefaults()
        {
            // Gender ComboBox
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });

            // Course ComboBox – new clean way
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
            using var rdr = cmd.ExecuteReader();

            var courseList = new List<ComboBoxItem>();
            while (rdr.Read())
            {
                courseList.Add(new ComboBoxItem(
                    rdr["CourseName"].ToString(),
                    rdr["CourseID"].ToString()));
            }

            cmbCourse.DataSource = courseList;
            cmbCourse.DisplayMember = "Text";   // 👈 CourseName
            cmbCourse.ValueMember = "Value";    // 👈 CourseID

            if (courseList.Count == 0)
            {
                MessageBox.Show("⚠️ No courses found in database. Please create at least one.");
            }
        }



        private void LoadStudentDataIntoForm()
        {
            if (editingStudent == null) return;

            // Gender
            cmbGender.Items.Clear();
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });
            cmbGender.SelectedItem = editingStudent.Gender;

            // 🎯 ComboBox is already bound with Course list, so just:
            cmbCourse.SelectedValue = editingStudent.CourseID;

            // Textboxes
            txtFullname.Text = editingStudent.Name;
            txtAddress.Text = editingStudent.Address;
            txtMail.Text = editingStudent.Email;
            txtPhoneNo.Text = editingStudent.Phone;
            dtpDOB.Value = editingStudent.DOB;

            txtUsername.Text = editingStudent.Username;
            txtUsername.ReadOnly = true;

            txtPw.Text = editingStudent.Password;
            txtPw.ReadOnly = true;
            txtPw.UseSystemPasswordChar = false;
        }



        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            LoadFormDefaults();

            if (!HasAnyCourses())
            {
                MessageBox.Show("No courses found! Redirecting you to Manage Courses to add some.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open ManageCourseForm
                var manageCourseForm = new ManageCourse_SubjectForm();

                manageCourseForm.ShowDialog();

                if (!HasAnyCourses())
                {
                    MessageBox.Show("No courses available. Please create one First.");
                    this.Hide();
                    var manageCourseForm1 = new ManageCourse_SubjectForm();

                    manageCourseForm.ShowDialog();


                }
                LoadFormDefaults(); // Reload courses after adding

            }
            if (!isEditMode)
            {
                txtUsername.Text = StudentController.GenerateUsername();
                txtPw.Text = StudentController.GeneratePassword();
                txtUsername.ReadOnly = true;
                txtPw.ReadOnly = true;
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
            // 🔎 Basic field validations
            if (string.IsNullOrWhiteSpace(txtFullname.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtPhoneNo.Text))
            {
                MessageBox.Show("Please fill in all the student details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 📞 Phone number validation (must be 10 digits and start with 07 or 021)
            if (!Regex.IsMatch(txtPhoneNo.Text, @"^(07|021)\d{8}$"))
            {
                MessageBox.Show("Phone number must start with 07 or 021 and be 10 digits.");
                return;
            }

            // 📧 Email format validation
            if (!Regex.IsMatch(txtMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }

            // ⛔ Gender validation
            if (!cmbGender.Items.Contains(cmbGender.Text))
            {
                MessageBox.Show("Please select a valid gender.");
                return;
            }


            //⛔ Course validation
            if (cmbCourse.SelectedItem == null || !(cmbCourse.SelectedItem is ComboBoxItem))
            {
                MessageBox.Show("Please select a valid course.");
                return;
            }



            // 🎓 Create student object
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

            // 🔄 Save or Update logic
            if (isEditMode)
            {
                student.StudentID = editingStudent.StudentID;

                bool updated = StudentController.UpdateStudents(student);
                if (updated)
                {
                    MessageBox.Show("✅ Student updated successfully!");
                    this.Close(); // Close the form after editing
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
                    ClearForm(); // Reset form after successful creation
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
            txtUsername.ReadOnly = true;
            txtPw.ReadOnly = true;
            txtPw.UseSystemPasswordChar = false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Add Student Form
        }
        
    }


}


  
