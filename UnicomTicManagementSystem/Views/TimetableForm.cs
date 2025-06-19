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
    public partial class TimetableForm : Form
    {
        private int selectedTimetableId = 0;
        private string userRole;

        public TimetableForm(string role)
        {
            InitializeComponent();
            userRole = role;
            LoadSubjects();
            LoadRooms();
            LoadTimeSlots();
            LoadTimetable();
            SetupRoleBasedAccess();
        }
        private void SetupRoleBasedAccess()
        {
            // 📌 Everyone can view timetable
            dgvTimetable.Visible = true;

            // 👑 Admin — full access
            if (userRole == "Admin")
            {
                cmbSubject.Visible = true;
                cmbRoomName.Visible = true;
                dtpTTDate.Visible = true;
                cmbTimeSlot.Visible = true;

                btnTAdd.Visible = true;
                btnTUpdate.Visible = true;
                btnTDelete.Visible = true;
            }
            else // 🧑‍🏫 Staff, 🧑‍🎓 Student, 👨‍🏫 Lecturer — view only
            {
                cmbSubject.Visible = false;
                cmbRoomName.Visible = false;
                dtpTTDate.Visible = false;
                cmbTimeSlot.Visible = false;

                btnTAdd.Visible = false;
                btnTUpdate.Visible = false;
                btnTDelete.Visible = false;

                MessageBox.Show("🔒 View-only access to timetable.");
            }
        }



        private void LoadSubjects()
        {
            cmbSubject.Items.Clear();
            var subjects = SubjectController.GetAllSubjects();
            foreach (var s in subjects)
            {
                cmbSubject.Items.Add(new ComboBoxItem(s.SubjectName, s.SubjectID));
            }
        }

        private void LoadRooms()
        {
            cmbRoomName.Items.Clear();
            var rooms = RoomManagementController.GetAllRooms();
            foreach (var r in rooms)
            {
                cmbRoomName.Items.Add(new ComboBoxItem($"{r.RoomName} ({r.RoomType})", r.RoomID.ToString()));
            }
        }

        private void LoadTimeSlots()
        {
            cmbTimeSlot.Items.Clear();
            cmbTimeSlot.Items.AddRange(new[] {
            "9:00 AM - 10:30 AM",
            "10:45 AM - 12:15 PM",
            "1:15 PM - 2:45 PM",
            "3:00 PM - 4:30 PM"
        });
        }

        private void LoadTimetable()
        {
            dgvTimetable.Rows.Clear();
            dgvTimetable.Columns.Clear();

            dgvTimetable.Columns.Add("ID", "ID");
            dgvTimetable.Columns.Add("Subject", "Subject");
            dgvTimetable.Columns.Add("Room", "Room");
            dgvTimetable.Columns.Add("Date", "Date");
            dgvTimetable.Columns.Add("TimeSlot", "Time Slot");

            var timetableList = TimetableController.GetAllTimetables();
            foreach (var t in timetableList)
            {
                dgvTimetable.Rows.Add(
                    t.TimetableID,
                    t.SubjectName,
                    t.RoomName,
                    t.Date.ToShortDateString(),
                    t.TimeSlot
                );
            }
        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedIndex == -1 || cmbRoomName.SelectedIndex == -1 || cmbTimeSlot.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var timetable = new Timetable
            {
                SubjectID = ((ComboBoxItem)cmbSubject.SelectedItem).Value,
                RoomID = int.Parse(((ComboBoxItem)cmbRoomName.SelectedItem).Value),
                Date = dtpTTDate.Value,
                TimeSlot = cmbTimeSlot.Text
            };

            if (TimetableController.AddTimetable(timetable))
            {
                MessageBox.Show("✅ Timetable added successfully!");
                LoadTimetable();
            }
            else
            {
                MessageBox.Show("❌ Failed to add timetable.");
            }
        }


        private void dgvTimetable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedTimetableId = Convert.ToInt32(dgvTimetable.Rows[e.RowIndex].Cells[0].Value);
                cmbSubject.Text = dgvTimetable.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbRoomName.Text = dgvTimetable.Rows[e.RowIndex].Cells[2].Value.ToString();
                dtpTTDate.Value = DateTime.Parse(dgvTimetable.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmbTimeSlot.Text = dgvTimetable.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void btnTUpdate_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == 0)
            {
                MessageBox.Show("Select a timetable entry to update.");
                return;
            }

            var timetable = new Timetable
            {
                TimetableID = selectedTimetableId,
                SubjectID = ((ComboBoxItem)cmbSubject.SelectedItem).Value,
                RoomID = int.Parse(((ComboBoxItem)cmbRoomName.SelectedItem).Value),
                Date = dtpTTDate.Value,
                TimeSlot = cmbTimeSlot.Text
            };

            if (TimetableController.UpdateTimetable(timetable))
            {
                MessageBox.Show("✅ Timetable updated successfully!");
                LoadTimetable();
                selectedTimetableId = 0;
            }
            else
            {
                MessageBox.Show("❌ Failed to update timetable.");
            }
        }
        

        private void btnTDelete_Click(object sender, EventArgs e)
        {
            if (selectedTimetableId == 0)
            {
                MessageBox.Show("Select a timetable entry to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this timetable entry?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (TimetableController.DeleteTimetable(selectedTimetableId))
                {
                    MessageBox.Show("✅ Timetable deleted successfully!");
                    LoadTimetable();
                    selectedTimetableId = 0;
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete timetable.");
                }
            }
        
        }

        private void btnTBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
