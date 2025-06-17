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
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class ManageStaffForm : Form
    {
        private int selectedStaffId = 0;

        public ManageStaffForm()
        {
            InitializeComponent();
            LoadStaffData();
        }
        private void LoadStaffData()
        {
            if (dgvStaff.Columns.Count == 0)
            {
                dgvStaff.Columns.Add("StaffID", "Staff ID");
                dgvStaff.Columns.Add("FullName", "Full Name");
                dgvStaff.Columns.Add("Address", "Address");
                dgvStaff.Columns.Add("Email", "Email");
                dgvStaff.Columns.Add("Phone", "Phone");
                dgvStaff.Columns.Add("Username", "Username");
            }

            dgvStaff.Rows.Clear();
            var conn = DbConfig.GetConnection();
            conn.Open();

            var q = @"SELECT s.StaffID, s.FullName, s.Address, s.Email, s.Phone, u.Username
                  FROM Staffs s
                  JOIN Users u ON s.UserID = u.UserID";

            using var cmd = new SQLiteCommand(q, conn);
            using var rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dgvStaff.Rows.Add(
                    rdr["StaffID"],
                    rdr["FullName"],
                    rdr["Address"],
                    rdr["Email"],
                    rdr["Phone"],
                    rdr["Username"]
                );
            }
        }
        private void btnStaffUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Please select a staff.");
                return;
            }

            var staff = StaffController.GetStaffById(selectedStaffId);
            if (staff == null)
            {
                MessageBox.Show("Staff not found.");
                return;
            }

            var form = new AddStaffForm(staff);
            form.ShowDialog();
            LoadStaffData();
            selectedStaffId = 0;
        }

        private void btnStaffDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaffId == 0)
            {
                MessageBox.Show("Select a staff to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bool deleted = StaffController.DeleteStaff(selectedStaffId);
                if (deleted)
                {
                    MessageBox.Show("Deleted!");
                    LoadStaffData();
                    selectedStaffId = 0;
                }
                else MessageBox.Show("Delete failed.");
            }
        }

        private void btnStaffBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedStaffId = Convert.ToInt32(dgvStaff.Rows[e.RowIndex].Cells[0].Value);
            }
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

