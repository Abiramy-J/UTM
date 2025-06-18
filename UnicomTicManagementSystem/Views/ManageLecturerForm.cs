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
using UnicomTicManagementSystem.Repositories;
using static UnicomTicManagementSystem.Controllers.LecturereController;

namespace UnicomTicManagementSystem.Views
{
    public partial class ManageLecturerForm : Form
    {
        private int selectedLecturerId = 0;
        public ManageLecturerForm()
        {
            InitializeComponent();
            LoadLecturerData();
        }
        private void LoadLecturerData()
        {
            if (dgvLecturers.Columns.Count == 0)
            {
                dgvLecturers.Columns.Add("LecturerID", "Lecturer ID");
                dgvLecturers.Columns.Add("Name", "Name");
                dgvLecturers.Columns.Add("Address", "Address");
                dgvLecturers.Columns.Add("Email", "Email");
                dgvLecturers.Columns.Add("Phone", "Phone");
                dgvLecturers.Columns.Add("Subject", "Subject");
                dgvLecturers.Columns.Add("Username", "Username");
            }

            dgvLecturers.Rows.Clear();
            using var conn = DbConfig.GetConnection();
            conn.Open();

            var q = @"SELECT l.LecturerID, l.Name, l.Address, l.Email, l.Phone, 
                         s.SubjectName, l.Username
                  FROM Lecturers l
                  JOIN Subjects s ON l.SubjectID = s.SubjectID";

            using var cmd = new SQLiteCommand(q, conn);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dgvLecturers.Rows.Add(
                    rdr["LecturerID"],
                    rdr["Name"],
                    rdr["Address"],
                    rdr["Email"],
                    rdr["Phone"],
                    rdr["SubjectName"],
                    rdr["Username"]
                );
            }
        }

        private void btnLeUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == 0)
            {
                MessageBox.Show("Please select a lecturer.");
                return;
            }

            var lecturer = LecturerController.GetLecturerById(selectedLecturerId);
            if (lecturer == null)
            {
                MessageBox.Show("Lecturer not found.");
                return;
            }

            var form = new AddLecturerForm(lecturer);
            form.ShowDialog();
            LoadLecturerData();
            selectedLecturerId = 0;
        }

        

        private void btnLeDelete_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == 0)
            {
                MessageBox.Show("Please select a lecturer to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this lecturer?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = LecturerController.DeleteLecturer(selectedLecturerId);
                if (deleted)
                {
                    MessageBox.Show("✅ Lecturer deleted successfully!");
                    LoadLecturerData();
                    selectedLecturerId = 0;
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete lecturer.");
                }
            }
        }
        private void btnLeBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedLecturerId = Convert.ToInt32(dgvLecturers.Rows[e.RowIndex].Cells[0].Value);
            }
        }
    }
}
