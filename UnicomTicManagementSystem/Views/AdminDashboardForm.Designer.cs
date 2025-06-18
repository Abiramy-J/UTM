namespace UnicomTicManagementSystem.Views
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreateUsers = new Button();
            btnManageUser = new Button();
            btnManageCourseAndSubject = new Button();
            btnAddExam = new Button();
            btnAddMarks = new Button();
            btnAddTimetable = new Button();
            btnLogout = new Button();
            btnAttendance = new Button();
            SuspendLayout();
            // 
            // btnCreateUsers
            // 
            btnCreateUsers.Location = new Point(29, 63);
            btnCreateUsers.Name = "btnCreateUsers";
            btnCreateUsers.Size = new Size(173, 23);
            btnCreateUsers.TabIndex = 0;
            btnCreateUsers.Text = "Create Users";
            btnCreateUsers.UseVisualStyleBackColor = true;
            btnCreateUsers.Click += btnAddStudent_Click;
            // 
            // btnManageUser
            // 
            btnManageUser.Location = new Point(29, 92);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(173, 23);
            btnManageUser.TabIndex = 1;
            btnManageUser.Text = "Manage User";
            btnManageUser.UseVisualStyleBackColor = true;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // btnManageCourseAndSubject
            // 
            btnManageCourseAndSubject.Location = new Point(12, 130);
            btnManageCourseAndSubject.Name = "btnManageCourseAndSubject";
            btnManageCourseAndSubject.Size = new Size(190, 23);
            btnManageCourseAndSubject.TabIndex = 4;
            btnManageCourseAndSubject.Text = "Manage Course and Subject";
            btnManageCourseAndSubject.UseVisualStyleBackColor = true;
            btnManageCourseAndSubject.Click += btnManageCourseAndSubject_Click;
            // 
            // btnAddExam
            // 
            btnAddExam.Location = new Point(42, 192);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(123, 23);
            btnAddExam.TabIndex = 6;
            btnAddExam.Text = "Add Exam";
            btnAddExam.UseVisualStyleBackColor = true;
            btnAddExam.Click += btnAddExam_Click;
            // 
            // btnAddMarks
            // 
            btnAddMarks.Location = new Point(42, 221);
            btnAddMarks.Name = "btnAddMarks";
            btnAddMarks.Size = new Size(123, 23);
            btnAddMarks.TabIndex = 7;
            btnAddMarks.Text = "Add Marks";
            btnAddMarks.UseVisualStyleBackColor = true;
            btnAddMarks.Click += btnAddMarks_Click;
            // 
            // btnAddTimetable
            // 
            btnAddTimetable.Location = new Point(29, 295);
            btnAddTimetable.Name = "btnAddTimetable";
            btnAddTimetable.Size = new Size(123, 23);
            btnAddTimetable.TabIndex = 8;
            btnAddTimetable.Text = "Add Timetable";
            btnAddTimetable.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(29, 333);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(42, 250);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(123, 23);
            btnAttendance.TabIndex = 10;
            btnAttendance.Text = "Attendance";
            btnAttendance.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 481);
            Controls.Add(btnAttendance);
            Controls.Add(btnLogout);
            Controls.Add(btnAddTimetable);
            Controls.Add(btnAddMarks);
            Controls.Add(btnAddExam);
            Controls.Add(btnManageCourseAndSubject);
            Controls.Add(btnManageUser);
            Controls.Add(btnCreateUsers);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateUsers;
        private Button btnManageUser;
        private Button btnManageCourseAndSubject;
        private Button btnAddExam;
        private Button btnAddMarks;
        private Button btnAddTimetable;
        private Button btnLogout;
        private Button btnAttendance;
    }
}