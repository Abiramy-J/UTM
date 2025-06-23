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

namespace UnicomTicManagementSystem.Views
{
    public partial class MarkForm : Form
    {

        private int selectedMarkId = 0;


        private string userRole;


        public MarkForm(string role)
        {
            InitializeComponent();
            userRole = role;
            cmbStudent.SelectedIndexChanged += cmbStudent_SelectedIndexChanged;

            LoadStudents();
            LoadExams();
            //LoadSubjects((int?)cmbStudent.SelectedValue);
            LoadMarks();

            SetupRoleBasedAccess();
        }
        private void SetupRoleBasedAccess()
        {
            // Hide everything by default
            lblStudent.Visible = false;
            lblExam.Visible = false;
            lblScore.Visible = false;
            lbMSubject.Visible = false;

            cmbStudent.Visible = false;
            cmbExam.Visible = false;
            cmbSubjects.Visible = false;
            txtScore.Visible = false;

            btnMAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            // Always visible
            dgvMarks.Visible = true;
            btnBack.Visible = true;

            // Role-specific logic
            if (userRole == "Admin" || userRole == "Staff")
            {
                // Full access
                lblStudent.Visible = true;
                lblExam.Visible = true;
                lblScore.Visible = true;
                lbMSubject.Visible = true;

                cmbStudent.Visible = true;
                cmbExam.Visible = true;
                cmbSubjects.Visible = true;
                txtScore.Visible = true;

                btnMAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else if (userRole == "Lecturer")
            {
                // Full access
                lblStudent.Visible = true;
                lblExam.Visible = true;
                lblScore.Visible = true;
                lbMSubject.Visible = true;

                cmbStudent.Visible = true;
                cmbExam.Visible = true;
                cmbSubjects.Visible = true;
                txtScore.Visible = true;

                btnMAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else if (userRole == "Student")
            {
                // View-only
                dgvMarks.Visible = true;
                btnBack.Visible = true;

                // ❌ No editing fields
                lblStudent.Visible = false;
                lblExam.Visible = false;
                lblScore.Visible = false;
                lbMSubject.Visible = false;

                cmbStudent.Visible = false;
                cmbExam.Visible = false;
                cmbSubjects.Visible = false;
                txtScore.Visible = false;

                btnMAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }



        private void LoadStudents()
        {
            cmbStudent.Items.Clear();
            cmbStudent.DisplayMember = "Text";
            cmbStudent.ValueMember = "Value";

            var students = StudentController.GetAllStudents();
            foreach (var student in students)
            {
                cmbStudent.Items.Add(new ComboBoxItem(student.Name, student.StudentID.ToString()));
            }
        }

        private void LoadExams()
        {
            cmbExam.Items.Clear();
            cmbExam.DisplayMember = "Text";
            cmbExam.ValueMember = "Value";

            var exams = ExamController.GetAllExams();
            foreach (var exam in exams)
            {
                cmbExam.Items.Add(new ComboBoxItem(exam.ExamName, exam.ExamID.ToString()));
            }
        }
        private void LoadSubjects(int? studentID)
        {
            if (studentID == null)
            {
                MessageBox.Show("Student ID is null 🤷‍♀️");
                return;
            }

            cmbSubjects.Items.Clear();

            // Now that we know it's not null, use .Value
            string courseID = MarkController.GetStudentCourseID(studentID.Value);
            var subjects = MarkController.GetSubjectsByCourseID(courseID);

            foreach (var subject in subjects)
            {
                cmbSubjects.Items.Add(new ComboBoxItem(subject.SubjectName, subject.SubjectID));
            }
        }




        private void LoadMarks()
        {
            dgvMarks.Rows.Clear();
            dgvMarks.Columns.Clear();

            dgvMarks.Columns.Add("MarkID", "Mark ID");
            dgvMarks.Columns.Add("StudentName", "Student");
            dgvMarks.Columns.Add("ExamName", "Exam");
            dgvMarks.Columns.Add("SubjectName", "Subject");
            dgvMarks.Columns.Add("Score", "Score");

            List<Mark> marks;

            if (userRole == "Student")
            {
                marks = MarkController.GetMarksForLoggedInStudent();  // only this student's marks
            }
            else
            {
                marks = MarkController.GetAllMarks();  //  all marks for admin/staff/lecturer
            }

            foreach (var mark in marks)
            {
                dgvMarks.Rows.Add(
                    mark.MarkID,
                    mark.StudentName,
                    mark.ExamName,
                    mark.SubjectName,
                    mark.Score
                );
            }
        }
        private void LoadLecturerSubjects()
        {
            cmbSubjects.Items.Clear();

            int lecturerID = AppSession.UserId; // ✅ assuming AppSession.UserId is int

            var subjects = SubjectController.GetSubjectsForLoggedInLecturer(lecturerID);

            foreach (var subject in subjects)
            {
                cmbSubjects.Items.Add(new ComboBoxItem(subject.SubjectName, subject.SubjectID));
            }
        }



        private void MarkForm_Load(object sender, EventArgs e)
        {
            if (AppSession.Role == "Lecturer")
            {
                LoadLecturerSubjects();
                LoadStudents();
                LoadExams();
            }
            else if (AppSession.Role == "Admin" || AppSession.Role == "Staff")
            {
                LoadStudents();
                LoadExams();
            }
        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {
            if (selectedMarkId != 0)
            {
                MessageBox.Show("⚠️ You're editing a mark. Click 'Update' or clear the form before adding a new one.");
                return;
            }
            if (cmbExam.Items.Count == 0)
            {
                lblNoExamWarning.Text = "⚠️ No exams available. Please create an exam first.";
                lblNoExamWarning.Visible = true;
                return;
            }
            else
            {
                lblNoExamWarning.Visible = false;
                lblNoExamWarning.Text = "";
            }
            if (cmbStudent.Items.Count == 0)
            {
                lblNoStudentWarning.Text = "⚠️ No exams available. Please create an exam first.";
                lblNoStudentWarning.Visible = true;
                return;
            }
            else
            {
                lblNoStudentWarning.Visible = false;
                lblNoStudentWarning.Text = "";
            }

            if (cmbStudent.SelectedIndex == -1 || cmbExam.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please select a student, exam, and enter score.");
                return;
            }
            if (cmbSubjects.Items.Count == 0) {
                lblNoSub.Text = "⚠️ No subjects available. Please add subjects first.";
                lblNoSub.Visible = true;
                return;
            }
            else
            {
                lblNoSub.Visible = false;
                lblNoSub.Text = "";
            }

            if (cmbSubjects.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }




            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be a number between 0 and 100.");
                return;
            }

            int studentId = int.Parse(((ComboBoxItem)cmbStudent.SelectedItem).Value);
            int examId = int.Parse(((ComboBoxItem)cmbExam.SelectedItem).Value);
            string subjectId = ((ComboBoxItem)cmbSubjects.SelectedItem).Value;
            if (MarkController.MarkExists(studentId, examId, subjectId))
            {
                MessageBox.Show("⚠️ This student already has a mark for this subject in this exam.");
                return;
            }


            var newMark = new Mark
            {
                StudentID = studentId,
                ExamID = examId,
                SubjectID = subjectId,
                Score = score
            };
            bool success = MarkController.AddMark(newMark);
            if (success)
            {
                MessageBox.Show("✅ Mark added successfully!");
                ResetForm();
                LoadMarks();
            }
            else
            {
                MessageBox.Show("❌ Failed to add mark.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == 0)
            {
                MessageBox.Show("Please select a mark to update.");
                return;
            }

            if (cmbStudent.SelectedIndex == -1 || cmbExam.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please select a student, exam, and enter score.");
                return;
            }

            if (!int.TryParse(txtScore.Text, out int score) || score < 0 || score > 100)
            {
                MessageBox.Show("Score must be a number between 0 and 100.");
                return;
            }

            int studentId = int.Parse(((ComboBoxItem)cmbStudent.SelectedItem).Value);
            int examId = int.Parse(((ComboBoxItem)cmbExam.SelectedItem).Value);
            string subjectId = ((ComboBoxItem)cmbSubjects.SelectedItem).Value;

            var updatedMark = new Mark
            {
                MarkID = selectedMarkId,
                StudentID = studentId,
                ExamID = examId,
                SubjectID = subjectId,
                Score = score
            };

            bool success = MarkController.UpdateMark(updatedMark);
            if (success)
            {
                MessageBox.Show("✅ Mark updated successfully!");
                ResetForm();
                LoadMarks();
            }
            else
            {
                MessageBox.Show("❌ Failed to update mark.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == 0)
            {
                MessageBox.Show("Please select a mark to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = MarkController.DeleteMark(selectedMarkId);
                if (deleted)
                {
                    MessageBox.Show("✅ Mark deleted successfully!");
                    ResetForm();
                    LoadMarks();
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete mark.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvMarks.Rows[e.RowIndex];
                selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
                cmbStudent.Text = row.Cells["StudentName"].Value.ToString();
                cmbExam.Text = row.Cells["ExamName"].Value.ToString();
                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
        }

        private void ResetForm()
        {
            cmbStudent.SelectedIndex = -1;
            cmbExam.SelectedIndex = -1;
            txtScore.Clear();
            selectedMarkId = 0;
            dgvMarks.ClearSelection(); // Optional: to unselect any row
        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedItem is ComboBoxItem selectedItem)
            {
                int studentId = int.Parse(selectedItem.Value);
                LoadSubjects(studentId);
            }
            else
            {
                cmbSubjects.Items.Clear();
            }
        }

        private void lblNoExamWarning_Click(object sender, EventArgs e)
        {

        }
    }
}
