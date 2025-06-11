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
            btnAddStudent = new Button();
            btnAddLecturer = new Button();
            btnAddStaff = new Button();
            btnCreateAdmin = new Button();
            btnManageCourseAndSubject = new Button();
            btnAddExam = new Button();
            btnAddMarks = new Button();
            btnAddTimetable = new Button();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(29, 63);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(173, 23);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "Add Student ";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnAddLecturer
            // 
            btnAddLecturer.Location = new Point(29, 92);
            btnAddLecturer.Name = "btnAddLecturer";
            btnAddLecturer.Size = new Size(173, 23);
            btnAddLecturer.TabIndex = 1;
            btnAddLecturer.Text = "Add Lecturer";
            btnAddLecturer.UseVisualStyleBackColor = true;
            // 
            // btnAddStaff
            // 
            btnAddStaff.Location = new Point(29, 121);
            btnAddStaff.Name = "btnAddStaff";
            btnAddStaff.Size = new Size(184, 23);
            btnAddStaff.TabIndex = 2;
            btnAddStaff.Text = "Add Staff";
            btnAddStaff.UseVisualStyleBackColor = true;
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.Location = new Point(29, 150);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(184, 23);
            btnCreateAdmin.TabIndex = 3;
            btnCreateAdmin.Text = "Create Admin";
            btnCreateAdmin.UseVisualStyleBackColor = true;
            // 
            // btnManageCourseAndSubject
            // 
            btnManageCourseAndSubject.Location = new Point(12, 190);
            btnManageCourseAndSubject.Name = "btnManageCourseAndSubject";
            btnManageCourseAndSubject.Size = new Size(190, 23);
            btnManageCourseAndSubject.TabIndex = 4;
            btnManageCourseAndSubject.Text = "Manage Course and Subject";
            btnManageCourseAndSubject.UseVisualStyleBackColor = true;
            // 
            // btnAddExam
            // 
            btnAddExam.Location = new Point(29, 237);
            btnAddExam.Name = "btnAddExam";
            btnAddExam.Size = new Size(123, 23);
            btnAddExam.TabIndex = 6;
            btnAddExam.Text = "Add Exam";
            btnAddExam.UseVisualStyleBackColor = true;
            // 
            // btnAddMarks
            // 
            btnAddMarks.Location = new Point(29, 266);
            btnAddMarks.Name = "btnAddMarks";
            btnAddMarks.Size = new Size(123, 23);
            btnAddMarks.TabIndex = 7;
            btnAddMarks.Text = "Add Marks";
            btnAddMarks.UseVisualStyleBackColor = true;
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
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 481);
            Controls.Add(btnLogout);
            Controls.Add(btnAddTimetable);
            Controls.Add(btnAddMarks);
            Controls.Add(btnAddExam);
            Controls.Add(btnManageCourseAndSubject);
            Controls.Add(btnCreateAdmin);
            Controls.Add(btnAddStaff);
            Controls.Add(btnAddLecturer);
            Controls.Add(btnAddStudent);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddStudent;
        private Button btnAddLecturer;
        private Button btnAddStaff;
        private Button btnCreateAdmin;
        private Button btnManageCourseAndSubject;
        private Button btnAddExam;
        private Button btnAddMarks;
        private Button btnAddTimetable;
        private Button btnLogout;
    }
}