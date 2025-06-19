using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class AdminDashboardForm : Form
    {
        private string userRole; // to store the role passed from login
        public AdminDashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;

            SetupRoleBasedUI();// this method will control which buttons to show

        }

        private void btnCreateUers_Click(object sender, EventArgs e)
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

        private void btnManageExam_Click(object sender, EventArgs e)
        {
            var ExamForm = new ExamForm(userRole);
            ExamForm.Show();
        }

        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            var markForm = new MarkForm(AppSession.Role); // 👈 pass role from dashboard
            markForm.Show();

        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            var RoomManagementForm = new RoomManagementForm();
            RoomManagementForm.Show();
        }

        private void btnManageTimetable_Click(object sender, EventArgs e)
        {
            var TimetableForm = new TimetableForm(userRole);
            TimetableForm.Show();
        }
        private void SetupRoleBasedUI()
        {
            // 🌑 First: Hide all buttons
            btnCreateUsers.Visible = false;
            btnManageUser.Visible = false;
            btnManageCourseAndSubject.Visible = false;
            btnManageRooms.Visible = false;
            btnManageExam.Visible = false;
            btnManageMarks.Visible = false;
            btnManageTimetable.Visible = false;

            // 🌞 Then show + rename based on role
            if (userRole == "Admin")
            {
                btnCreateUsers.Visible = true;
                btnManageUser.Visible = true;
                btnManageCourseAndSubject.Visible = true;
                btnManageRooms.Visible = true;

                btnManageExam.Visible = true;
                btnManageExam.Text = "Manage Exams";

                btnManageMarks.Visible = true;
                btnManageMarks.Text = "Manage Marks";

                btnManageTimetable.Visible = true;
                btnManageTimetable.Text = "Manage Timetable";
            }
            else if (userRole == "Staff")
            {
                btnManageExam.Visible = true;
                btnManageExam.Text = "Manage Exams";

                btnManageMarks.Visible = true;
                btnManageMarks.Text = "Manage Marks";

                btnManageTimetable.Visible = true;
                btnManageTimetable.Text = "View Timetable";
            }
            else if (userRole == "Lecturer")
            {
                btnManageExam.Visible = true;
                btnManageExam.Text = "View Exams";

                btnManageMarks.Visible = true;
                btnManageMarks.Text = "Manage Marks";

                btnManageTimetable.Visible = true;
                btnManageTimetable.Text = "View Timetable";
            }
            else if (userRole == "Student")
            {
                btnManageExam.Visible = true;
                btnManageExam.Text = "View Exams";

                btnManageMarks.Visible = true;
                btnManageMarks.Text = "View Marks";

                btnManageTimetable.Visible = true;
                btnManageTimetable.Text = "My Timetable";
            }
        }

    }
}