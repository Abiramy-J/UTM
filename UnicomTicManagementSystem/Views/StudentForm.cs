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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UnicomTicManagementSystem.Views
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        private int selectedStudentId = 0; // Stores the currently selected student ID for update/delete


        private void StudentForm_Load(object sender, EventArgs e)
        {
            // Auto - generate a random username and password
            txtUserName.Text = StudentController.GenerateUsername();
            txtPassword.Text = StudentController.GeneratePassword();

            // Add gender options to the gender combo box
            cmbGender.Items.AddRange(new[] { "Male", "Female", "Other" });

            // Load course options from the database and add to course combo box
            using var conn = DbConfig.GetConnection();
            conn.Open();
            var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbCourse.Items.Add(new ComboBoxItem(rdr["CourseName"].ToString(), Convert.ToInt32(rdr["CourseID"])));
            }

            // Load existing students into the data grid
            LoadStudentData();
        }

        // Load all student records from the database into the DataGridView
        private void LoadStudentData()
        {
            dgvStudents.Rows.Clear(); // Clear existing rows

            using var conn = DbConfig.GetConnection();
            conn.Open();

            // Query to fetch student details with joined course and username info
            string q = @"SELECT s.StudentID, s.Name, s.Address, s.Email, s.Phone, s.DOB, s.Gender,
                        c.CourseName, u.Username
                 FROM Students s
                 JOIN Courses c ON s.CourseID = c.CourseID
                 JOIN Users u ON s.UserID = u.UserID";

            using var cmd = new SQLiteCommand(q, conn);
            using var rdr = cmd.ExecuteReader();

            // Add each record as a row in the DataGridView
            while (rdr.Read())
            {
                dgvStudents.Rows.Add(
                    rdr["StudentID"],
                    rdr["Name"],
                    rdr["Address"],
                    rdr["Email"],
                    rdr["Phone"],
                    Convert.ToDateTime(rdr["DOB"]).ToString("yyyy-MM-dd"),
                    rdr["Gender"],
                    rdr["CourseName"],
                    rdr["Username"]
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Create a new student object with form inputs
            var s = new Student
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                DOB = dtpDOB.Value,
                Gender = cmbGender.Text,
                CourseID = ((ComboBoxItem)cmbCourse.SelectedItem).Value
            };

            // Call controller to insert student into database
            bool added = StudentController.CreateStudent(s, txtUsername.Text, txtPassword.Text);
            if (added)
            {
                MessageBox.Show("Student added!");
                LoadStudentData();  // Reload the data grid with new student
                ClearForm();        // Clear the form for next entry
            }
            else
            {
                MessageBox.Show("Failed to add.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Ensure a student is selected
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Select a student.");
                return;
            }

            // Confirm delete
            var confirm = MessageBox.Show("Delete this student?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = StudentController.DeleteStudents(selectedStudentId);
                if (deleted)
                {
                    MessageBox.Show("Deleted!");
                    LoadStudentData(); // Refresh student list
                    ClearForm();       // Clear form
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

    }
}
}
}
}
