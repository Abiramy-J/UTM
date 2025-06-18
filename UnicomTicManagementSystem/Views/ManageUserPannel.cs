using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.Views
{
    public partial class ManageUserPannel : Form
    {
        public ManageUserPannel()
        {
            InitializeComponent();
        }

        private void ManageUserPannel_Load(object sender, EventArgs e)
        {

        }

        private void LoadFormIntoPanel(Form form)
        {
            pnlManageUser.Controls.Clear(); // Clear previously loaded form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlManageUser.Controls.Add(form);
            form.Show();
        }

        private void btnStudentManage_Click(object sender, EventArgs e)
        {
            ManageStudentForm studentForm = new ManageStudentForm();
            LoadFormIntoPanel(studentForm);
        }

        private void btnMClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStaffManage_Click(object sender, EventArgs e)
        {
            ManageStaffForm manageStaffForm = new ManageStaffForm();
            LoadFormIntoPanel(manageStaffForm);
        }

        private void btnLecturerManage_Click(object sender, EventArgs e)
        {
            ManageLecturerForm manageLecturerForm = new ManageLecturerForm();
            LoadFormIntoPanel (manageLecturerForm); 
        }
    }
}