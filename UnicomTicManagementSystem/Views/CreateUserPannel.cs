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
    public partial class CreateUserPannel : Form
    {
        public CreateUserPannel()
        {
            InitializeComponent();
        }

        private void CreateUserPannel_Load(object sender, EventArgs e)
        {

        }
        private void LoadFormIntoPanel(Form form)
        {
            if (form.IsDisposed)//Prevents error if form is already "dead"
            {
                MessageBox.Show("The form cannot be loaded because it has been disposed.");
                return;
            }
            pnlCreateUser.Controls.Clear(); // Clear previously loaded form
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnlCreateUser.Controls.Add(form);
            form.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm studentForm = new AddStudentForm();
            LoadFormIntoPanel(studentForm);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddStaffForm staffForm = new AddStaffForm();
            LoadFormIntoPanel(staffForm);
        }

        private void buttonLecturer_Click(object sender, EventArgs e)
        {
            AddLecturerForm addLecturerForm = new AddLecturerForm();
            LoadFormIntoPanel(addLecturerForm);

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseCU_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the Create User Panel
        }

        private void pnlCreateUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
