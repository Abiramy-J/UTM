using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class ManageCourse_SubjectForm : Form
    {
        public ManageCourse_SubjectForm()
        {
            InitializeComponent();
            // Setup for Courses DataGridView
            dgvCourses.Columns.Add("CourseID", "Course ID");
            dgvCourses.Columns.Add("CourseName", "Course Name");

            // NOW SETUP for Subjects DataGridView
            dgvSubject.Columns.Add("SubjectID", "Subject ID");
            dgvSubject.Columns.Add("SubjectName", "Subject Name");
            dgvSubject.Columns.Add("CourseName", "Course Name");
        }
        private void LoadCourseData()
        {
            dgvCourses.Rows.Clear(); // Clear existing rows

            // Get all courses from the database
            var courses = CourseController.GetAllCourses();

            // Add each course into DataGridView
            foreach (var c in courses)
            {
                dgvCourses.Rows.Add(c.CourseID, c.CourseName);
            }
        }

        private void ManageCourse_SubjectForm_Load(object sender, EventArgs e)
        {
            LoadSubjectData();
            LoadCourseData();
            LoadCoursesIntoDropdown();
            ClearSubjectForm();
            ClearCourseForm(); // assuming you already have this for course
        }

        private void btnCAdd_Click(object sender, EventArgs e)
        {
            lblCourseError.Visible = false;
            lblCourseError.Text = "";
            // Validate course name
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter course name.");
                return;
            }
            string courseName = txtCourseName.Text.Trim();

            if (CourseController.IsCourseExists(courseName))
            {
                lblCourseError.Text = "Course already exists.";
                lblCourseError.Visible = true;
                return;
            }

            // Create a course object
            var course = new Course
            {
                CourseID = txtCourseID.Text,
                CourseName = txtCourseName.Text.Trim()
            };

            // Call controller to add
            bool added = CourseController.AddCourse(course);

            if (added)
            {
                MessageBox.Show("Course added successfully!");
                LoadCourseData(); // Refresh DGV
                LoadCoursesIntoDropdown();   // Refresh dropdown for subjects
                ClearCourseForm(); // Reset form
            }
            else
            {
                MessageBox.Show("Failed to add course.");
            }
        }


        private string selectedCourseID = null; // Stores currently selected course for update/delete

        private void btnCUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == null)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course name cannot be empty.");
                return;
            }

            var course = new Course
            {
                CourseID = selectedCourseID,
                CourseName = txtCourseName.Text
            };

            bool updated = CourseController.UpdateCourse(course);
            if (updated)
            {
                MessageBox.Show("Course updated.");
                LoadCourseData();
                LoadCoursesIntoDropdown();   //  Refresh dropdown for subjects
                ClearCourseForm();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }
        }




        private void btnCDelete_Click(object sender, EventArgs e)
        {
            if (selectedCourseID == null)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            var confirm = MessageBox.Show("Delete this course?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = CourseController.DeleteCourse(selectedCourseID);
                if (deleted)
                {
                    MessageBox.Show("Course deleted.");
                    LoadCourseData();
                    LoadCoursesIntoDropdown();   //  Refresh dropdown for subjects
                    ClearCourseForm();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }

        }

       
        private void ClearCourseForm()
        {
            txtCourseID.Text = CourseController.GenerateCourseID(); // Get new ID
            txtCourseName.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to close?", "Exit", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Hide();
            }
        }
        private void LoadSubjectData()
        {
            dgvSubject.Rows.Clear(); //  Correct DGV to clear

            // Get all subjects from the database
            var subject = SubjectController.GetAllSubjects();

            // Add each subject to dgvSubject (NOT dgvCourses!)
            foreach (var s in subject)
            {
                dgvSubject.Rows.Add(s.SubjectID, s.SubjectName, s.CourseName);
            }
        }

        private void ClearSubjectForm()
        {
            txtSubjectID.Text = SubjectController.GenerateSubjectID(); // Auto-ID
            txtSubjectName.Clear();
            cmbCourses.SelectedIndex = -1;
            selectedSubjectID = null;
        }

        private string selectedSubjectID = null; // Stores current subject selected

        private void btnSAdd_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter subject name and select a course.");
                return;
            }
            string subjectName = txtSubjectName.Text.Trim();

            /*if (SubjectController.IsSubjectExists(subjectName))
            {
                lblSubjectError.Text = "Subject already exists.";
                lblSubjectError.Visible = true;
                return;
            }

            // 3. All good – hide error, prepare model and save
            lblSubjectError.Visible = false;

            */

            var subject = new Subject
            {
                SubjectID = txtSubjectID.Text,
                SubjectName = txtSubjectName.Text,
                CourseID = ((ComboBoxItem)cmbCourses.SelectedItem).Value
            };

            bool added = SubjectController.AddSubject(subject);
            if (added)
            {
                MessageBox.Show("Subject added!");
                LoadSubjectData();
                ClearSubjectForm();
            }
            else
            {
                MessageBox.Show("Failed to add subject.");
            }
        }

        private void btnSUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == null)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourses.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter subject name and select a course.");
                return;
            }

            var subject = new Subject
            {
                SubjectID = selectedSubjectID,
                SubjectName = txtSubjectName.Text,
                CourseID = ((ComboBoxItem)cmbCourses.SelectedItem).Value
            };

            bool updated = SubjectController.UpdateSubject(subject);
            if (updated)
            {
                MessageBox.Show("Subject updated!");
                LoadSubjectData();
                ClearSubjectForm();
            }
            else
            {
                MessageBox.Show("Update failed.");
            }

        }

        private void btnSDelete_Click(object sender, EventArgs e)
        {
            if (selectedSubjectID == null)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = SubjectController.DeleteSubject(selectedSubjectID);
                if (deleted)
                {
                    MessageBox.Show("Deleted!");
                    LoadSubjectData();
                    ClearSubjectForm();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
        }

        
        private void LoadCoursesIntoDropdown()
        {
            cmbCourses.Items.Clear();
            var courses = CourseController.GetAllCourses();
            foreach (var course in courses)
            {
                cmbCourses.Items.Add(new ComboBoxItem(course.CourseName, course.CourseID));
            }
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubject.Rows[e.RowIndex];
                selectedSubjectID = row.Cells[0].Value.ToString();
                txtSubjectID.Text = selectedSubjectID;
                txtSubjectName.Text = row.Cells[1].Value.ToString();

                // Match CourseName to Course ComboBox (by text)
                cmbCourses.SelectedIndex = cmbCourses.FindStringExact(row.Cells[2].Value.ToString());
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];
                selectedCourseID = row.Cells[0].Value.ToString(); // Save selected ID
                txtCourseID.Text = selectedCourseID;
                txtCourseName.Text = row.Cells[1].Value.ToString();
            }
        }
    }

}
