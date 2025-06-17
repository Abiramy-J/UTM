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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var createUserForm = new CreateUserPannel();
            createUserForm.Show(); // or .ShowDialog() if you want it modal
        }

        private void btnManageCourseAndSubject_Click(object sender, EventArgs e)
        {
            var manageCourse_Subject = new ManageCourse_SubjectForm();
            manageCourse_Subject.Show(); // or .ShowDialog() if you want it modal
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            var manageUserPannel = new ManageUserPannel();
            manageUserPannel.Show();
        }
    }
}