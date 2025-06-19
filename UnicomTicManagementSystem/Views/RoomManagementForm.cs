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
    public partial class RoomManagementForm : Form
    {
        private int selectedRoomID = 0;


        public RoomManagementForm()
        {
            InitializeComponent();
            LoadRoomTypes();
            LoadRoomList();
        }
        private void LoadRoomTypes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.AddRange(new string[] { "Lab", "Hall" });
        }

        private void LoadRoomList()
        {
            dgvRooms.Rows.Clear();
            dgvRooms.Columns.Clear();

            dgvRooms.Columns.Add("RoomID", "Room ID");
            dgvRooms.Columns.Add("RoomName", "Room Name");
            dgvRooms.Columns.Add("RoomType", "Room Type");

            var rooms = RoomManagementController.GetAllRooms();
            foreach (var room in rooms)
            {
                dgvRooms.Rows.Add(room.RoomID, room.RoomName, room.RoomType);
            }
        }

        private void btnRAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter room name and select room type.");
                return;
            }

            var room = new Room
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.Text
            };

            if (RoomManagementController.CreateRoom(room))
            {
                MessageBox.Show("✅ Room added successfully!");
                ClearForm();
                LoadRoomList();
            }
            else
            {
                MessageBox.Show("❌ Failed to add room.");
            }
        }

        private void btnRUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRoomID == 0)
            {
                MessageBox.Show("Please select a room to update.");
                return;
            }

            var room = new Room
            {
                RoomID = selectedRoomID,
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.Text
            };

            if (RoomManagementController.UpdateRoom(room))
            {
                MessageBox.Show("✅ Room updated successfully!");
                ClearForm();
                LoadRoomList();
                selectedRoomID = 0;
            }
            else
            {
                MessageBox.Show("❌ Failed to update room.");
            }
        }
  

        private void btnRDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomID == 0)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (RoomManagementController.DeleteRoom(selectedRoomID))
                {
                    MessageBox.Show("✅ Room deleted successfully!");
                    LoadRoomList();
                    ClearForm();
                    selectedRoomID = 0;
                }
                else
                {
                    MessageBox.Show("❌ Failed to delete room.");
                }
            }
        }

        private void btnRBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRoomID = Convert.ToInt32(dgvRooms.Rows[e.RowIndex].Cells[0].Value);
                txtRoomName.Text = dgvRooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbRoomType.Text = dgvRooms.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void ClearForm()
        {
            txtRoomName.Clear();
            cmbRoomType.SelectedIndex = -1;
        }

    }

}
