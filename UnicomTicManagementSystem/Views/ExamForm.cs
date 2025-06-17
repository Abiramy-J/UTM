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
        private int selectedExamId = 0;  // 🧠 Keep track of which exam is selected
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
        private void dgvExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtExamName.Text))
            {
                MessageBox.Show("Please enter exam name and select a subject.");
                return;
            }

            Exam newExam = new Exam
            {
                SubjectID = cmbSubject.SelectedValue.ToString(),
                ExamName = txtExamName.Text,
                ExamDate = dtpExamDate.Value
            };

            bool success = ExamController.CreateExam(newExam);
            if (success)
            {
                MessageBox.Show("✅ Exam added successfully!");
                txtExamName.Clear();
                LoadExamList();
            }
            else
            {
                MessageBox.Show("❌ Failed to add exam.");
            }
        }

        private void LoadExamList()
        {
            dgvExams.Rows.Clear();
            dgvExams.Columns.Clear();

            dgvExams.Columns.Add("ExamID", "Exam ID");
            dgvExams.Columns.Add("SubjectName", "Subject");
            dgvExams.Columns.Add("ExamName", "Exam Name");
            dgvExams.Columns.Add("ExamDate", "Exam Date");

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
                dgvExams.Rows.Add(
                    rdr["ExamID"],
                    rdr["SubjectName"],
                    rdr["ExamName"],
                    rdr["ExamDate"]
                );
            }
        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an exam to update.");
                return;
            }

            Exam updatedExam = new Exam
            {
                ExamID = selectedExamId, // from your DGV click
                SubjectID = cmbSubject.SelectedValue.ToString(),
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
            if (dgvExams.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select an exam to delete.");
                return;
            }

            int examId = Convert.ToInt32(dgvExams.SelectedRows[0].Cells["ExamID"].Value);
            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = ExamController.DeleteExam(examId);
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
