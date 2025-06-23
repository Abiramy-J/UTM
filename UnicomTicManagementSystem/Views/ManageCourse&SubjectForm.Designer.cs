namespace UnicomTicManagementSystem.Views
{
    partial class ManageCourse_SubjectForm
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
            panelHeader = new Panel();
            pictureBox1 = new PictureBox();
            labelHeader = new Label();
            panelSectionHeader = new Panel();
            panel4 = new Panel();
            labelCourse = new Label();
            lbManageSubject = new Label();
            panelCourse = new Panel();
            lblSubjectError = new Label();
            lblCourseError = new Label();
            btnCUpdate = new Button();
            btnCDelete = new Button();
            btnCAdd = new Button();
            lbCoureName = new Label();
            dgvCourses = new DataGridView();
            lbCourseID = new Label();
            txtCourseID = new TextBox();
            txtCourseName = new TextBox();
            panelSubject = new Panel();
            btnSDelete = new Button();
            btnSUpdate = new Button();
            btnSAdd = new Button();
            lbSubjectId = new Label();
            lbSubjectName = new Label();
            lbCourse = new Label();
            cmbCourses = new ComboBox();
            txtSubjectID = new TextBox();
            dgvSubject = new DataGridView();
            txtSubjectName = new TextBox();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelSectionHeader.SuspendLayout();
            panelCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            panelSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = SystemColors.ActiveCaption;
            panelHeader.Controls.Add(pictureBox1);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(945, 83);
            panelHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1;
            pictureBox1.Location = new Point(233, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(66, 62);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // labelHeader
            // 
            labelHeader.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(218, 33);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(476, 41);
            labelHeader.TabIndex = 0;
            labelHeader.Text = " Courses And  Subjects";
            labelHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelSectionHeader
            // 
            panelSectionHeader.BackColor = SystemColors.GradientActiveCaption;
            panelSectionHeader.Controls.Add(panel4);
            panelSectionHeader.Dock = DockStyle.Top;
            panelSectionHeader.Location = new Point(0, 83);
            panelSectionHeader.Name = "panelSectionHeader";
            panelSectionHeader.Size = new Size(945, 20);
            panelSectionHeader.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(149, 145);
            panel4.TabIndex = 3;
            // 
            // labelCourse
            // 
            labelCourse.BackColor = SystemColors.Highlight;
            labelCourse.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCourse.ForeColor = SystemColors.ControlLightLight;
            labelCourse.Location = new Point(-2, -2);
            labelCourse.Name = "labelCourse";
            labelCourse.Size = new Size(464, 30);
            labelCourse.TabIndex = 1;
            labelCourse.Text = "Manage Course";
            labelCourse.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbManageSubject
            // 
            lbManageSubject.BackColor = SystemColors.Highlight;
            lbManageSubject.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbManageSubject.ForeColor = SystemColors.ControlLightLight;
            lbManageSubject.Location = new Point(-2, -2);
            lbManageSubject.Name = "lbManageSubject";
            lbManageSubject.Size = new Size(481, 30);
            lbManageSubject.TabIndex = 2;
            lbManageSubject.Text = "Manage Subject";
            lbManageSubject.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelCourse
            // 
            panelCourse.BorderStyle = BorderStyle.Fixed3D;
            panelCourse.Controls.Add(lblCourseError);
            panelCourse.Controls.Add(labelCourse);
            panelCourse.Controls.Add(btnCUpdate);
            panelCourse.Controls.Add(btnCDelete);
            panelCourse.Controls.Add(btnCAdd);
            panelCourse.Controls.Add(lbCoureName);
            panelCourse.Controls.Add(dgvCourses);
            panelCourse.Controls.Add(lbCourseID);
            panelCourse.Controls.Add(txtCourseID);
            panelCourse.Controls.Add(txtCourseName);
            panelCourse.Dock = DockStyle.Left;
            panelCourse.Location = new Point(0, 103);
            panelCourse.Name = "panelCourse";
            panelCourse.Size = new Size(464, 433);
            panelCourse.TabIndex = 2;
            // 
            // lblSubjectError
            // 
            lblSubjectError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubjectError.ForeColor = Color.Red;
            lblSubjectError.Location = new Point(221, 101);
            lblSubjectError.Name = "lblSubjectError";
            lblSubjectError.Size = new Size(126, 15);
            lblSubjectError.TabIndex = 38;
            lblSubjectError.Text = "Subject already exists!";
            lblSubjectError.Visible = false;
            // 
            // lblCourseError
            // 
            lblCourseError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseError.ForeColor = Color.Red;
            lblCourseError.Location = new Point(196, 123);
            lblCourseError.Name = "lblCourseError";
            lblCourseError.Size = new Size(126, 15);
            lblCourseError.TabIndex = 37;
            lblCourseError.Text = "Course already exists!";
            lblCourseError.Visible = false;
            // 
            // btnCUpdate
            // 
            btnCUpdate.BackColor = SystemColors.ActiveCaption;
            btnCUpdate.FlatStyle = FlatStyle.Flat;
            btnCUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCUpdate.Location = new Point(156, 156);
            btnCUpdate.Name = "btnCUpdate";
            btnCUpdate.Size = new Size(75, 26);
            btnCUpdate.TabIndex = 19;
            btnCUpdate.Text = "UPDATE";
            btnCUpdate.UseVisualStyleBackColor = false;
            btnCUpdate.Click += btnCUpdate_Click;
            // 
            // btnCDelete
            // 
            btnCDelete.BackColor = SystemColors.ActiveCaption;
            btnCDelete.FlatStyle = FlatStyle.Flat;
            btnCDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCDelete.Location = new Point(275, 156);
            btnCDelete.Name = "btnCDelete";
            btnCDelete.Size = new Size(75, 26);
            btnCDelete.TabIndex = 18;
            btnCDelete.Text = "DELETE";
            btnCDelete.UseVisualStyleBackColor = false;
            btnCDelete.Click += btnCDelete_Click;
            // 
            // btnCAdd
            // 
            btnCAdd.BackColor = SystemColors.ActiveCaption;
            btnCAdd.FlatStyle = FlatStyle.Flat;
            btnCAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCAdd.Location = new Point(40, 156);
            btnCAdd.Name = "btnCAdd";
            btnCAdd.Size = new Size(75, 26);
            btnCAdd.TabIndex = 17;
            btnCAdd.Text = "ADD";
            btnCAdd.UseVisualStyleBackColor = false;
            btnCAdd.Click += btnCAdd_Click;
            // 
            // lbCoureName
            // 
            lbCoureName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCoureName.Location = new Point(13, 92);
            lbCoureName.Name = "lbCoureName";
            lbCoureName.Size = new Size(137, 33);
            lbCoureName.TabIndex = 13;
            lbCoureName.Text = "Course Name :";
            // 
            // dgvCourses
            // 
            dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(31, 195);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.Size = new Size(392, 225);
            dgvCourses.TabIndex = 12;
            dgvCourses.CellClick += dgvCourses_CellClick;
            // 
            // lbCourseID
            // 
            lbCourseID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCourseID.Location = new Point(40, 49);
            lbCourseID.Name = "lbCourseID";
            lbCourseID.Size = new Size(107, 32);
            lbCourseID.TabIndex = 4;
            lbCourseID.Text = "Course ID :";
            // 
            // txtCourseID
            // 
            txtCourseID.Location = new Point(153, 54);
            txtCourseID.Name = "txtCourseID";
            txtCourseID.Size = new Size(228, 23);
            txtCourseID.TabIndex = 9;
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(146, 97);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(228, 23);
            txtCourseName.TabIndex = 10;
            // 
            // panelSubject
            // 
            panelSubject.BorderStyle = BorderStyle.Fixed3D;
            panelSubject.Controls.Add(lblSubjectError);
            panelSubject.Controls.Add(lbManageSubject);
            panelSubject.Controls.Add(btnSDelete);
            panelSubject.Controls.Add(btnSUpdate);
            panelSubject.Controls.Add(btnSAdd);
            panelSubject.Controls.Add(lbSubjectId);
            panelSubject.Controls.Add(lbSubjectName);
            panelSubject.Controls.Add(lbCourse);
            panelSubject.Controls.Add(cmbCourses);
            panelSubject.Controls.Add(txtSubjectID);
            panelSubject.Controls.Add(dgvSubject);
            panelSubject.Controls.Add(txtSubjectName);
            panelSubject.Dock = DockStyle.Fill;
            panelSubject.Location = new Point(464, 103);
            panelSubject.Name = "panelSubject";
            panelSubject.Size = new Size(481, 433);
            panelSubject.TabIndex = 3;
            // 
            // btnSDelete
            // 
            btnSDelete.BackColor = SystemColors.ActiveCaption;
            btnSDelete.FlatStyle = FlatStyle.Flat;
            btnSDelete.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSDelete.Location = new Point(354, 172);
            btnSDelete.Name = "btnSDelete";
            btnSDelete.Size = new Size(75, 26);
            btnSDelete.TabIndex = 23;
            btnSDelete.Text = "DELETE";
            btnSDelete.UseVisualStyleBackColor = false;
            btnSDelete.Click += btnSDelete_Click;
            // 
            // btnSUpdate
            // 
            btnSUpdate.BackColor = SystemColors.ActiveCaption;
            btnSUpdate.FlatStyle = FlatStyle.Flat;
            btnSUpdate.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSUpdate.Location = new Point(206, 172);
            btnSUpdate.Name = "btnSUpdate";
            btnSUpdate.Size = new Size(75, 26);
            btnSUpdate.TabIndex = 22;
            btnSUpdate.Text = "UPDATE";
            btnSUpdate.UseVisualStyleBackColor = false;
            btnSUpdate.Click += btnSUpdate_Click;
            // 
            // btnSAdd
            // 
            btnSAdd.BackColor = SystemColors.ActiveCaption;
            btnSAdd.FlatStyle = FlatStyle.Flat;
            btnSAdd.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSAdd.Location = new Point(45, 172);
            btnSAdd.Name = "btnSAdd";
            btnSAdd.Size = new Size(75, 26);
            btnSAdd.TabIndex = 21;
            btnSAdd.Text = "ADD";
            btnSAdd.UseVisualStyleBackColor = false;
            btnSAdd.Click += btnSAdd_Click;
            // 
            // lbSubjectId
            // 
            lbSubjectId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubjectId.Location = new Point(36, 39);
            lbSubjectId.Name = "lbSubjectId";
            lbSubjectId.Size = new Size(105, 39);
            lbSubjectId.TabIndex = 16;
            lbSubjectId.Text = "Subject ID :";
            // 
            // lbSubjectName
            // 
            lbSubjectName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubjectName.Location = new Point(36, 78);
            lbSubjectName.Name = "lbSubjectName";
            lbSubjectName.Size = new Size(140, 30);
            lbSubjectName.TabIndex = 15;
            lbSubjectName.Text = "Subject Name :";
            // 
            // lbCourse
            // 
            lbCourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCourse.Location = new Point(36, 124);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(93, 27);
            lbCourse.TabIndex = 14;
            lbCourse.Text = "Course  :";
            // 
            // cmbCourses
            // 
            cmbCourses.FormattingEnabled = true;
            cmbCourses.Location = new Point(147, 124);
            cmbCourses.Name = "cmbCourses";
            cmbCourses.Size = new Size(245, 23);
            cmbCourses.TabIndex = 13;
            // 
            // txtSubjectID
            // 
            txtSubjectID.Location = new Point(157, 39);
            txtSubjectID.Name = "txtSubjectID";
            txtSubjectID.Size = new Size(235, 23);
            txtSubjectID.TabIndex = 11;
            // 
            // dgvSubject
            // 
            dgvSubject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(45, 214);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.Size = new Size(384, 206);
            dgvSubject.TabIndex = 11;
            dgvSubject.CellClick += dgvSubject_CellClick;
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(182, 78);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(210, 23);
            txtSubjectName.TabIndex = 12;
            // 
            // ManageCourse_SubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 536);
            Controls.Add(panelSubject);
            Controls.Add(panelCourse);
            Controls.Add(panelSectionHeader);
            Controls.Add(panelHeader);
            Name = "ManageCourse_SubjectForm";
            Text = "ManageCourse_SubjectForm";
            Load += ManageCourse_SubjectForm_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelSectionHeader.ResumeLayout(false);
            panelCourse.ResumeLayout(false);
            panelCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            panelSubject.ResumeLayout(false);
            panelSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelSectionHeader;
        private Panel panelCourse;
        private Panel panel4;
        private Panel panelSubject;
        private Label labelHeader;
        private Label labelCourse;
        private Label lbManageSubject;
        private DataGridView dgvCourses;
        private Label lbCourseID;
        private TextBox txtCourseID;
        private TextBox txtCourseName;
        private TextBox txtSubjectID;
        private DataGridView dgvSubject;
        private TextBox txtSubjectName;
        private ComboBox cmbCourses;
        private Label lbCoureName;
        private Label lbSubjectId;
        private Label lbSubjectName;
        private Label lbCourse;
        private Button btnCUpdate;
        private Button btnCDelete;
        private Button btnCAdd;
        private Button btnSAdd;
        private Button btnSDelete;
        private Button btnSUpdate;
        private PictureBox pictureBox1;
        private Label lblCourseError;
        private Label lblSubjectError;
    }
}