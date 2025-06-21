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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // btnCreateUsers
            // 
            btnCreateUsers.BackColor = Color.Lavender;
            btnCreateUsers.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUsers.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateUsers.Location = new Point(412, 41);
            btnCreateUsers.Name = "btnCreateUsers";
            btnCreateUsers.Size = new Size(250, 32);
            btnCreateUsers.TabIndex = 0;
            btnCreateUsers.Text = "Create Users";
            btnCreateUsers.UseVisualStyleBackColor = false;
            btnCreateUsers.Click += btnCreateUers_Click;
            // 
            // btnManageUser
            // 
            btnManageUser.BackColor = Color.Lavender;
            btnManageUser.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageUser.Location = new Point(412, 102);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(250, 32);
            btnManageUser.TabIndex = 1;
            btnManageUser.Text = "Manage User";
            btnManageUser.UseVisualStyleBackColor = false;
            btnManageUser.Click += btnManageUser_Click;
            // 
            // btnManageCourseAndSubject
            // 
            btnManageCourseAndSubject.BackColor = Color.Lavender;
            btnManageCourseAndSubject.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageCourseAndSubject.Location = new Point(412, 220);
            btnManageCourseAndSubject.Name = "btnManageCourseAndSubject";
            btnManageCourseAndSubject.Size = new Size(250, 32);
            btnManageCourseAndSubject.TabIndex = 4;
            btnManageCourseAndSubject.Text = "Manage Course and Subject";
            btnManageCourseAndSubject.UseVisualStyleBackColor = false;
            btnManageCourseAndSubject.Click += btnManageCourseAndSubject_Click;
            // 
            // btnManageExam
            // 
            btnManageExam.BackColor = Color.Lavender;
            btnManageExam.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageExam.Location = new Point(412, 163);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(250, 32);
            btnManageExam.TabIndex = 6;
            btnManageExam.Text = "Manage Exam";
            btnManageExam.UseVisualStyleBackColor = false;
            btnManageExam.Click += btnManageExam_Click;
            // 
            // btnManageMarks
            // 
            btnManageMarks.BackColor = Color.Lavender;
            btnManageMarks.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageMarks.Location = new Point(412, 279);
            btnManageMarks.Name = "btnManageMarks";
            btnManageMarks.Size = new Size(250, 32);
            btnManageMarks.TabIndex = 7;
            btnManageMarks.Text = "Manage Marks";
            btnManageMarks.UseVisualStyleBackColor = false;
            btnManageMarks.Click += btnManageMarks_Click;
            // 
            // btnManageTimetable
            // 
            btnManageTimetable.BackColor = Color.Lavender;
            btnManageTimetable.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageTimetable.Location = new Point(412, 404);
            btnManageTimetable.Name = "btnManageTimetable";
            btnManageTimetable.Size = new Size(250, 32);
            btnManageTimetable.TabIndex = 8;
            btnManageTimetable.Text = "Manage Timetable";
            btnManageTimetable.UseVisualStyleBackColor = false;
            btnManageTimetable.Click += btnManageTimetable_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Lavender;
            btnLogout.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(412, 471);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(250, 32);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageRooms
            // 
            btnManageRooms.BackColor = Color.Lavender;
            btnManageRooms.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageRooms.Location = new Point(412, 345);
            btnManageRooms.Name = "btnManageRooms";
            btnManageRooms.Size = new Size(250, 32);
            btnManageRooms.TabIndex = 10;
            btnManageRooms.Text = "ManageRooms";
            btnManageRooms.UseVisualStyleBackColor = false;
            btnManageRooms.Click += btnManageRooms_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_06_20_at_22_47_51_3515973c;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 536);
            panel1.TabIndex = 11;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(945, 536);
            Controls.Add(panel1);
            Controls.Add(btnManageRooms);
            Controls.Add(btnLogout);
            Controls.Add(btnManageTimetable);
            Controls.Add(btnManageMarks);
            Controls.Add(btnManageExam);
            Controls.Add(btnManageCourseAndSubject);
            Controls.Add(btnManageUser);
            Controls.Add(btnCreateUsers);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            FormClosing += AdminDashboardForm_FormClosing;
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
        private Panel panel1;
    }
}