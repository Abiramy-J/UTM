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
        public ExamForm()
        {
            InitializeComponent();
            LoadSubjectsIntoComboBox();
            LoadExamList();
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

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedExamId = Convert.ToInt32(dgvExam.Rows[e.RowIndex].Cells["ExamID"].Value);
                txtExamName.Text = dgvExam.Rows[e.RowIndex].Cells["ExamName"].Value.ToString();
                cmbSubject.Text = dgvExam.Rows[e.RowIndex].Cells["SubjectName"].Value.ToString();
                dtpExamDate.Value = Convert.ToDateTime(dgvExam.Rows[e.RowIndex].Cells["ExamDate"].Value);
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
                txtExamName.Clear();
                cmbSubject.SelectedIndex = -1;
                LoadExamList();
            }
            else
            {
                MessageBox.Show("❌ Failed to add exam.");
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
                LoadExamList();
            }
            else
            {
                MessageBox.Show("❌ Failed to update exam.");
            }
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

    

    
    