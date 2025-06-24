using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public bool IsViewMode { get; set; } = false;// This property is used to determine if the form is in view mode or edit mode


        // Default constructor → used when adding a new student
        public AddStudentForm()
        {
            InitializeComponent();
            lblPhoneError.Visible = false;
            //LoadFormDefaults();

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
        public AddStudentForm(Student studentToView, bool isViewMode)
        {
            InitializeComponent();

            IsViewMode = isViewMode;
            editingStudent = studentToView;

            LoadFormDefaults();      // Load combos first

            if (IsViewMode)
            {
                LoadStudentData(editingStudent);  // Load data for readonly view
            }
            else
            {
                isEditMode = true;
                LoadFormDefaults();         // Load defaults for editing
                LoadStudentDataIntoForm();         // For editing
            }
        }

        private void LoadFormDefaults()
        {
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
            cmbCourse.DisplayMember = "Text";   //  CourseName
            cmbCourse.ValueMember = "Value";    //  CourseID

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


            // Fill other fields
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
            //if there is No Course Found Redirecting you to Manage Courses & subject  to add course and subject       
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
                LoadFormDefaults(); // Reload the form defaults after managing courses


            }
            if (!isEditMode)
            {
                txtUsername.Text = StudentController.GenerateUsername();
                txtPw.Text = StudentController.GeneratePassword();
                txtUsername.ReadOnly = true;
                txtPw.ReadOnly = true;
            }
            if (IsViewMode)
            {
                
                txtFullname.ReadOnly = true;
                txtAddress.ReadOnly = true;
                txtMail.ReadOnly = true;
                txtPhoneNo.ReadOnly = true;
                cmbGender.Enabled = false;
                cmbCourse.Enabled = false;
                dtpDOB.Enabled = false;
                btnSave.Visible = false;

                txtUsername.ReadOnly = true;
                txtPw.ReadOnly = true;
                txtPw.UseSystemPasswordChar = true;
                LoadStudentData(editingStudent);//pass the student to load values!
            }
        }


        public void LoadStudentData(Student student)
        {
            if (student == null) return;

            txtFullname.Text = student.Name;
            txtAddress.Text = student.Address;
            txtMail.Text = student.Email;
            txtPhoneNo.Text = student.Phone;
            dtpDOB.Value = student.DOB;

            cmbGender.SelectedIndex = cmbGender.FindStringExact(student.Gender);
            cmbCourse.SelectedValue = student.CourseID;

            txtUsername.Text = student.Username;
            txtPw.Text = student.Password;  // THIS line is crucial
            txtPw.UseSystemPasswordChar = true;
            txtPw.ReadOnly = true;
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
            bool isValid = true;
           
            // --- Fullname ---
            if (string.IsNullOrWhiteSpace(txtFullname.Text))
            {
                lblFullnameError.Text = "Full name is required.";
                lblFullnameError.Visible = true;
                isValid = false;
            }
            else
            {
                lblFullnameError.Visible = false;
            }

            //  Phone number validation (must be 10 digits and start with 07 or 021)
            ValidatePhone();
            if (lblPhoneError.Visible)
            {
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                lblAddressError.Text = "Address is required.";
                lblAddressError.Visible = true;
                isValid = false;
            }
            else
            {
                lblAddressError.Visible = false;
            }

            // --- Email ---
            if (string.IsNullOrWhiteSpace(txtMail.Text))
            {
                lblEmailError.Text = "Email is required.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else if (!Regex.IsMatch(txtMail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lblEmailError.Text = "Invalid email address format.";
                lblEmailError.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmailError.Visible = false;
            }

            // --- Phone Number ---
            ValidatePhone();
            if (lblPhoneError.Visible)
            {
                isValid = false;
            }

            // --- Gender ---
            if (cmbGender.SelectedIndex == 0 || string.IsNullOrWhiteSpace(cmbGender.Text))
            {
                lb1GenderError.Text = "Please select a gender.";
                lb1GenderError.Visible = true;
                isValid = false;
            }
            else
            {
                lb1GenderError.Visible = false;
            }

            // --- DOB ---
            int age = DateTime.Today.Year - dtpDOB.Value.Year;
            if (dtpDOB.Value > DateTime.Today.AddYears(-age)) age--;
            if (age < 17)
            {
                lblDOBError.Text = "Student must be at least 17 years old.";
                lblDOBError.Visible = true;
                isValid = false;
            }
            else
            {
                lblDOBError.Visible = false;
            }

            // --- Course ---
            if (cmbCourse.SelectedValue == null || cmbCourse.SelectedValue.ToString() == "0")
            {
                lblCourseError.Text = "Please select a valid course.";
                lblCourseError.Visible = true;
                isValid = false;
            }
            else
            {
                lblCourseError.Visible = false;
            }

            // --- Final Check ---
            if (!isValid)
            {
                return; // Don't proceed if there's any validation error
            }

            // 🎉 All validations passed → Save the data!
            MessageBox.Show("Student details saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        




        //  Create student object
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

                // Save or Update logic
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

        private void lblPhoneError_TextChanged(object sender, EventArgs e)
        {
            ValidatePhone();
        }
        private void ValidatePhone()
        {
            if (!Regex.IsMatch(txtPhoneNo.Text.Trim(), @"^(07|021)\d{8}$"))
            {
                lblPhoneError.Text = "Phone number must start with 07 or 021 and be 10 digits";
                lblPhoneError.Visible = true;
                return;
            }

            lblPhoneError.Visible = false;
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
            ValidatePhone();
        }
    }


}


  
