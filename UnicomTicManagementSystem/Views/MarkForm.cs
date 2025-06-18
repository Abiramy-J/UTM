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
    public partial class MarkForm : Form
    {
        private int selectedMarkID = 0;
        public MarkForm()
        {
            InitializeComponent();
            LoadStudents();
            LoadExams();
            LoadMarks();
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

        private void LoadMarks()
        {
            dgvMarks.Rows.Clear();
            dgvMarks.Columns.Clear();

            dgvMarks.Columns.Add("MarkID", "Mark ID");
            dgvMarks.Columns.Add("StudentName", "Student");
            dgvMarks.Columns.Add("ExamName", "Exam");
            dgvMarks.Columns.Add("Score", "Score");

            var marks = MarkController.GetAllMarks();
            foreach (var mark in marks)
            {
                dgvMarks.Rows.Add(
                    mark.MarkID,
                    mark.StudentName,
                    mark.ExamName,
                    mark.Score
                );
            }
        }

        private void MarkForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
