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
            btnManageExam = new Button();
            btnManageMarks = new Button();
            btnManageTimetable = new Button();
            btnLogout = new Button();
            btnManageRooms = new Button();
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
            btnCreateUsers.Click += btnCreateUers_Click;
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
            // btnManageExam
            // 
            btnManageExam.Location = new Point(42, 192);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(123, 23);
            btnManageExam.TabIndex = 6;
            btnManageExam.Text = "Manage Exam";
            btnManageExam.UseVisualStyleBackColor = true;
            btnManageExam.Click += btnManageExam_Click;
            // 
            // btnManageMarks
            // 
            btnManageMarks.Location = new Point(42, 221);
            btnManageMarks.Name = "btnManageMarks";
            btnManageMarks.Size = new Size(123, 23);
            btnManageMarks.TabIndex = 7;
            btnManageMarks.Text = "Manage Marks";
            btnManageMarks.UseVisualStyleBackColor = true;
            btnManageMarks.Click += btnManageMarks_Click;
            // 
            // btnManageTimetable
            // 
            btnManageTimetable.Location = new Point(29, 295);
            btnManageTimetable.Name = "btnManageTimetable";
            btnManageTimetable.Size = new Size(123, 23);
            btnManageTimetable.TabIndex = 8;
            btnManageTimetable.Text = "Manage Timetable";
            btnManageTimetable.UseVisualStyleBackColor = true;
            btnManageTimetable.Click += btnManageTimetable_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(29, 333);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(123, 23);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageRooms
            // 
            btnManageRooms.Location = new Point(42, 250);
            btnManageRooms.Name = "btnManageRooms";
            btnManageRooms.Size = new Size(123, 23);
            btnManageRooms.TabIndex = 10;
            btnManageRooms.Text = "ManageRooms";
            btnManageRooms.UseVisualStyleBackColor = true;
            btnManageRooms.Click += btnManageRooms_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 481);
            Controls.Add(btnManageRooms);
            Controls.Add(btnLogout);
            Controls.Add(btnManageTimetable);
            Controls.Add(btnManageMarks);
            Controls.Add(btnManageExam);
            Controls.Add(btnManageCourseAndSubject);
            Controls.Add(btnManageUser);
            Controls.Add(btnCreateUsers);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateUsers;
        private Button btnManageUser;
        private Button btnManageCourseAndSubject;
        private Button btnManageExam;
        private Button btnManageMarks;
        private Button btnManageTimetable;
        private Button btnLogout;
        private Button btnManageRooms;
    }
}