﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class AdminDashboardForm : Form
    {
        private bool isLoggingOut = false;

        private string userRole; // to store the role passed from login
        public AdminDashboardForm(string role)
        {
            InitializeComponent();
            userRole = role;

            SetupRoleBasedUI();// this method will control which buttons to show

        }

        private void btnCreateUers_Click(object sender, EventArgs e)
        {
            /*var createUserForm = new CreateUserPannel();
            createUserForm.Show();
            this.Hide(); // close the dashboard form
            createUserForm.FormClosed += (s, e) => this.Show(); // bring it back later
            createUserForm.Show();
            */
            // Inside AdminDashboard
            var form = new CreateUserPannel();
            this.Hide(); // dashboard hides
            form.FormClosed += (s, e) => this.Show(); // bring it back later
            form.Show();

        }

        private void btnManageCourseAndSubject_Click(object sender, EventArgs e)
        {
            var manageCourse_Subject = new ManageCourse_SubjectForm();
            this.Hide();
            manageCourse_Subject.FormClosed += (s, e) => this.Show(); // bring it back later
            manageCourse_Subject.Show();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            var manageUserPannel = new ManageUserPannel();
            this.Hide();
            manageUserPannel.FormClosed += (s, e) => this.Show(); // bring it back later
            manageUserPannel.Show();
        }

        private void btnManageExam_Click(object sender, EventArgs e)
        {
            var ExamForm = new ExamForm(userRole);
            this.Hide();
            ExamForm.FormClosed += (s, e) => this.Show(); // bring it back later
            ExamForm.Show();

        }

        private void btnManageMarks_Click(object sender, EventArgs e)
        {
            var markForm = new MarkForm(AppSession.Role); // 👈 pass role from dashboard
            this.Hide();
            markForm.FormClosed += (s, e) => this.Show();
            markForm.Show();

        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            var RoomManagementForm = new RoomManagementForm();
            this.Hide();
            RoomManagementForm.FormClosed += (s, e) => this.Show();
            RoomManagementForm.Show();
        }

        private void btnManageTimetable_Click(object sender, EventArgs e)
        {
            var TimetableForm = new TimetableForm(userRole);
            this.Hide();
            TimetableForm.FormClosed += (s, e) => this.Show();
            TimetableForm.Show();
        }
        private void SetupRoleBasedUI()
        {
            //  First: Hide all buttons
            btnCreateUsers.Visible = false;
            btnManageUser.Visible = false;
            btnManageCourseAndSubject.Visible = false;
            btnManageRooms.Visible = false;
            btnManageExam.Visible = false;
            btnManageMarks.Visible = false;
            btnManageTimetable.Visible = false;

            //  Then show + rename based on role
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

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            AppSession.Clear();

            var result = MessageBox.Show(
                "Session ended. Do you wish to log in again?",
                "Logout Successful",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
            else
            {
                isLoggingOut = true;  
                Application.Exit();   // FormClosing
            }
        }

        private void AdminDashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLoggingOut) return; // Skip confirm if it's coming from logout

            var result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Cancel the close
            }

        }
    }
}