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
    public partial class ExamForm : Form
    {
        private int selectedExamId = 0;
        
        private string userRole;

        public ExamForm(string role)
        {
            InitializeComponent();
            userRole = role;
            LoadSubjectsIntoComboBox();
            LoadExamList();
            SetupRoleBasedAccess();
        }
        private void SetupRoleBasedAccess()
        {
            // Hide all form controls initially
            lbExamName.Visible = false;
            label1.Visible = false;
            label2.Visible = false;

            txtExamName.Visible = false;
            cmbSubject.Visible = false;
            dtpExamDate.Visible = false;

            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnDelete.Visible = false;

            // Always visible controls
            dgvExam.Visible = true;
            btnBack.Visible = true;

            // Show/hide based on role
            if (userRole == "Admin" || userRole == "Staff")
            {
                lbExamName.Visible = true;
                label1.Visible = true;
                label2.Visible = true;

                txtExamName.Visible = true;
                cmbSubject.Visible = true;
                dtpExamDate.Visible = true;

                btnAdd.Visible = true;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
            }
            else if (userRole == "Lecturer")
            {
                // View-only access: show labels, no editing
                lbExamName.Visible = false;
                label1.Visible = false;
                label2.Visible = false;

                txtExamName.Visible = false; // can't edit
                cmbSubject.Visible = false;
                dtpExamDate.Visible = false;

                // No add/delete/update
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
            else if (userRole == "Student")
            {
                // Student sees only the exam list
                dgvExam.Visible = true;
                btnBack.Visible = true;

                // Hide everything else
                lbExamName.Visible = false;
                label1.Visible = false;
                label2.Visible = false;

                txtExamName.Visible = false;
                cmbSubject.Visible = false;
                dtpExamDate.Visible = false;

                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }


        private void LoadSubjectsIntoComboBox()
        {
            cmbSubject.Items.Clear();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            string query = "SELECT SubjectID, SubjectName FROM Subjects";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmbSubject.Items.Add(new ComboBoxItem(
                    rdr["SubjectName"].ToString(),
                    rdr["SubjectID"].ToString()
                ));
            }
        }

        private void LoadExamList()
        {
            dgvExam.Rows.Clear();
            dgvExam.Columns.Clear();
            dgvExam.AllowUserToAddRows = false;

            dgvExam.Columns.Add("ExamID", "Exam ID");
            dgvExam.Columns.Add("SubjectName", "Subject");
            dgvExam.Columns.Add("ExamName", "Exam Name");
            dgvExam.Columns.Add("ExamDate", "Exam Date");

            using var conn = DbConfig.GetConnection();
            conn.Open();
            string query = @"
                SELECT e.ExamID, s.SubjectName, e.ExamName, e.ExamDate
                FROM Exams e
                JOIN Subjects s ON e.SubjectID = s.SubjectID
            ";
            using var cmd = new SQLiteCommand(query, conn);
            using var rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dgvExam.Rows.Add(
                    rdr["ExamID"],
                    rdr["SubjectName"],
                    rdr["ExamName"],
                    Convert.ToDateTime(rdr["ExamDate"]).ToShortDateString()
                );
            }
        }

        private void dgvExam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvExam.Rows.Count)
            {
                var row = dgvExam.Rows[e.RowIndex];

                // Check if row has data
                if (row.Cells["ExamID"].Value == null) return;

                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExamName.Text = row.Cells["ExamName"].Value?.ToString();
                cmbSubject.Text = row.Cells["SubjectName"].Value?.ToString();
                dtpExamDate.Value = Convert.ToDateTime(row.Cells["ExamDate"].Value);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtExamName.Text))
            {
                MessageBox.Show("Please enter exam name and select a subject.");
                return;
            }

            var subjectId = ((ComboBoxItem)cmbSubject.SelectedItem).Value;

            if (selectedExamId == 0)
            {
                // Normal Add
                Exam newExam = new Exam
                {
                    SubjectID = subjectId,
                    ExamName = txtExamName.Text,
                    ExamDate = dtpExamDate.Value
                };

                bool success = ExamController.CreateExam(newExam);
                if (success)
                {
                    MessageBox.Show("✅ Exam added successfully!");
                    ResetForm();
                    LoadExamList();
                }
                else
                {
                    MessageBox.Show("❌ Failed to add exam.");
                }
            }
            else
            {
                // Act like Update
                var updatedExam = new Exam
                {
                    ExamID = selectedExamId,
                    SubjectID = subjectId,
                    ExamName = txtExamName.Text,
                    ExamDate = dtpExamDate.Value
                };

                bool success = ExamController.UpdateExam(updatedExam);
                if (success)
                {
                    MessageBox.Show("✏️ Exam updated instead of added!");
                    ResetForm();
                    LoadExamList();
                }
                else
                {
                    MessageBox.Show("❌ Failed to update exam.");
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedExamId == 0)
            {
                MessageBox.Show("Select an exam to update.");
                return;
            }

            var subjectId = ((ComboBoxItem)cmbSubject.SelectedItem).Value;

            Exam updatedExam = new Exam
            {
                ExamID = selectedExamId,
                SubjectID = subjectId,
                ExamName = txtExamName.Text,
                ExamDate = dtpExamDate.Value
            };

            bool success = ExamController.UpdateExam(updatedExam);
            if (success)
            {
                MessageBox.Show("✅ Exam updated successfully!");
                ResetForm(); // ← Reset the form after update
                LoadExamList();
            }
            else
            {
                MessageBox.Show("❌ Failed to update exam.");
            }
        }
        private void ResetForm()
        {
            txtExamName.Clear();
            cmbSubject.SelectedIndex = -1;
            dtpExamDate.Value = DateTime.Today;
            selectedExamId = 0;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == 0)
            {
                MessageBox.Show("Select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = ExamController.DeleteExam(selectedExamId);
                if (deleted)
                {
                    MessageBox.Show("✅ Exam deleted successfully!");
                    ResetForm(); // ← clear the form after deletion
                    LoadExamList();
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete exam.");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    

    
    