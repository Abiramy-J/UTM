namespace UnicomTicManagementSystem.Views
{
    partial class StudentForm
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
            lbFullName = new Label();
            lbAddress = new Label();
            lbPnNo = new Label();
            lbDateOfBirth = new Label();
            lbGender = new Label();
            lbCourse = new Label();
            lbUserName = new Label();
            lbPw = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNo = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            cmbCourse = new ComboBox();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            lbMail = new Label();
            textBox1 = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            dgvStudents = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Location = new Point(58, 9);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(61, 15);
            lbFullName.TabIndex = 0;
            lbFullName.Text = "Full Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(58, 44);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(49, 15);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Address";
            // 
            // lbPnNo
            // 
            lbPnNo.AutoSize = true;
            lbPnNo.Location = new Point(58, 84);
            lbPnNo.Name = "lbPnNo";
            lbPnNo.Size = new Size(88, 15);
            lbPnNo.TabIndex = 2;
            lbPnNo.Text = "Phone Number";
            lbPnNo.TextAlign = ContentAlignment.TopRight;
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Location = new Point(58, 122);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(73, 15);
            lbDateOfBirth.TabIndex = 3;
            lbDateOfBirth.Text = "Date of Birth";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(58, 170);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 4;
            lbGender.Text = "Gender";
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(58, 200);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(44, 15);
            lbCourse.TabIndex = 5;
            lbCourse.Text = "Course";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(58, 245);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(60, 15);
            lbUserName.TabIndex = 6;
            lbUserName.Text = "Username";
            // 
            // lbPw
            // 
            lbPw.AutoSize = true;
            lbPw.Location = new Point(58, 286);
            lbPw.Name = "lbPw";
            lbPw.Size = new Size(57, 15);
            lbPw.TabIndex = 7;
            lbPw.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 1);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 8;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(145, 44);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 9;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(152, 81);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(100, 23);
            txtPhoneNo.TabIndex = 10;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(145, 245);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(145, 283);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 13;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(145, 199);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(121, 23);
            cmbCourse.TabIndex = 14;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(145, 170);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(121, 23);
            cmbGender.TabIndex = 15;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(152, 116);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 23);
            dtpDOB.TabIndex = 16;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(69, 334);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(39, 15);
            lbMail.TabIndex = 17;
            lbMail.Text = "E.Mail";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(240, 23);
            textBox1.TabIndex = 18;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(263, 402);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(435, 390);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(552, 390);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "DElETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(667, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 22;
            btnBack.Text = "BACK  ";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(435, 143);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(335, 220);
            dgvStudents.TabIndex = 23;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(textBox1);
            Controls.Add(lbMail);
            Controls.Add(dtpDOB);
            Controls.Add(cmbGender);
            Controls.Add(cmbCourse);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(lbPw);
            Controls.Add(lbUserName);
            Controls.Add(lbCourse);
            Controls.Add(lbGender);
            Controls.Add(lbDateOfBirth);
            Controls.Add(lbPnNo);
            Controls.Add(lbAddress);
            Controls.Add(lbFullName);
            Name = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFullName;
        private Label lbAddress;
        private Label lbPnNo;
        private Label lbDateOfBirth;
        private Label lbGender;
        private Label lbCourse;
        private Label lbUserName;
        private Label lbPw;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhoneNo;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private ComboBox cmbCourse;
        private ComboBox cmbGender;
        private DateTimePicker dtpDOB;
        private Label lbMail;
        private TextBox textBox1;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private DataGridView dgvStudents;
    }
}