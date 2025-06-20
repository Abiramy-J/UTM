namespace UnicomTicManagementSystem.Views
{
    partial class ManageUserPannel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUserPannel));
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxMUser = new PictureBox();
            lbManageUsers = new Label();
            btnStudentManage = new Button();
            btnLecturerManage = new Button();
            btnStaffManage = new Button();
            pnlManageUser = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMUser).BeginInit();
            pnlManageUser.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(984, 30);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveBorder;
            panel2.Controls.Add(pictureBoxMUser);
            panel2.Controls.Add(lbManageUsers);
            panel2.Controls.Add(btnStudentManage);
            panel2.Controls.Add(btnLecturerManage);
            panel2.Controls.Add(btnStaffManage);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 498);
            panel2.TabIndex = 0;
            // 
            // pictureBoxMUser
            // 
            pictureBoxMUser.Image = (Image)resources.GetObject("pictureBoxMUser.Image");
            pictureBoxMUser.Location = new Point(64, 51);
            pictureBoxMUser.Name = "pictureBoxMUser";
            pictureBoxMUser.Size = new Size(68, 74);
            pictureBoxMUser.TabIndex = 0;
            pictureBoxMUser.TabStop = false;
            // 
            // lbManageUsers
            // 
            lbManageUsers.AutoSize = true;
            lbManageUsers.Font = new Font("Century", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbManageUsers.Location = new Point(23, 128);
            lbManageUsers.Name = "lbManageUsers";
            lbManageUsers.Size = new Size(150, 23);
            lbManageUsers.TabIndex = 0;
            lbManageUsers.Text = "Manage Users";
            // 
            // btnStudentManage
            // 
            btnStudentManage.BackColor = SystemColors.ActiveCaption;
            btnStudentManage.FlatStyle = FlatStyle.Flat;
            btnStudentManage.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudentManage.Location = new Point(12, 223);
            btnStudentManage.Name = "btnStudentManage";
            btnStudentManage.Size = new Size(178, 38);
            btnStudentManage.TabIndex = 1;
            btnStudentManage.Text = "Student";
            btnStudentManage.UseVisualStyleBackColor = false;
            btnStudentManage.Click += btnStudentManage_Click;
            // 
            // btnLecturerManage
            // 
            btnLecturerManage.BackColor = SystemColors.ActiveCaption;
            btnLecturerManage.FlatStyle = FlatStyle.Flat;
            btnLecturerManage.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLecturerManage.Location = new Point(12, 375);
            btnLecturerManage.Name = "btnLecturerManage";
            btnLecturerManage.Size = new Size(178, 38);
            btnLecturerManage.TabIndex = 2;
            btnLecturerManage.Text = "Lecturer";
            btnLecturerManage.UseVisualStyleBackColor = false;
            btnLecturerManage.Click += btnLecturerManage_Click;
            // 
            // btnStaffManage
            // 
            btnStaffManage.BackColor = SystemColors.ActiveCaption;
            btnStaffManage.FlatStyle = FlatStyle.Flat;
            btnStaffManage.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffManage.Location = new Point(12, 300);
            btnStaffManage.Name = "btnStaffManage";
            btnStaffManage.Size = new Size(178, 38);
            btnStaffManage.TabIndex = 0;
            btnStaffManage.Text = "Staff";
            btnStaffManage.UseVisualStyleBackColor = false;
            btnStaffManage.Click += btnStaffManage_Click;
            // 
            // pnlManageUser
            // 
            pnlManageUser.Controls.Add(label1);
            pnlManageUser.Dock = DockStyle.Fill;
            pnlManageUser.Location = new Point(0, 30);
            pnlManageUser.Name = "pnlManageUser";
            pnlManageUser.Size = new Size(984, 498);
            pnlManageUser.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(309, 128);
            label1.Name = "label1";
            label1.Size = new Size(568, 168);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the User Management Panel. Please select a category to proceed!\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageUserPannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 528);
            Controls.Add(panel2);
            Controls.Add(pnlManageUser);
            Controls.Add(panel1);
            Name = "ManageUserPannel";
            Text = "ManageUserPannel";
            Load += ManageUserPannel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMUser).EndInit();
            pnlManageUser.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlManageUser;
        private Button btnStudentManage;
        private Button btnLecturerManage;
        private Button btnStaffManage;
        private Label lbManageUsers;
        private PictureBox pictureBoxMUser;
        private Label label1;
    }
}