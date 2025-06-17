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
using System.Xml.Linq;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class ManageStudentForm : Form
    {
        private int selectedStudentId = 0;
        // Add this in the InitializeComponent method after initializing dgvStudents

        public ManageStudentForm()
        {
            InitializeComponent();

            LoadStudentData();
        }

        // Load all student records from the database into the DataGridView
        private void LoadStudentData()
        {
            if (dgvStudents.Columns.Count == 0)
            {
                dgvStudents.Columns.Add("StudentID", "Student ID");
                dgvStudents.Columns.Add("Name", "Name");
                dgvStudents.Columns.Add("Address", "Address");
                dgvStudents.Columns.Add("Email", "Email");
                dgvStudents.Columns.Add("Phone", "Phone");
                dgvStudents.Columns.Add("DOB", "Date of Birth");
                dgvStudents.Columns.Add("Gender", "Gender");
                dgvStudents.Columns.Add("CourseName", "Course Name");
                dgvStudents.Columns.Add("Username", "Username");
            }
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


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            // Get student data by ID
            Student studentToEdit = StudentController.GetStudentById(selectedStudentId);
            if (studentToEdit == null)
            {
                MessageBox.Show("Student not found.");
                return;
            }

            // Open AddStudentForm in edit mode
            var editForm = new AddStudentForm(studentToEdit);
            editForm.ShowDialog();

            LoadStudentData(); // Refresh after editing
            selectedStudentId = 0;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId == 0)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = StudentController.DeleteStudents(selectedStudentId);
                if (deleted)
                {
                    MessageBox.Show("Student deleted successfully.");
                    LoadStudentData();
                    selectedStudentId = 0;
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }


        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                selectedStudentId = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void lbMStudentRecords_Click(object sender, EventArgs e)
        {

        }
    }

}

