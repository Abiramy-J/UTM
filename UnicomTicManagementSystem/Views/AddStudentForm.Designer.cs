﻿namespace UnicomTicManagementSystem.Views
{
    partial class AddStudentForm
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
            lbName = new Label();
            lbAddress = new Label();
            lnPhoneNo = new Label();
            lbDateOfBirth = new Label();
            lbCourse = new Label();
            lbGender = new Label();
            lbUserName = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            txtFullname = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNo = new TextBox();
            txtUsername = new TextBox();
            txtPw = new TextBox();
            txtMail = new TextBox();
            cmbCourse = new ComboBox();
            cmbGender = new ComboBox();
            dtpDOB = new DateTimePicker();
            btnSave = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            lblPhoneError = new Label();
            lblEmailError = new Label();
            lblDOBError = new Label();
            IbFullNameError = new Label();
            lb1GenderError = new Label();
            lblCourseError = new Label();
            lblFullnameError = new Label();
            lblAddressError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbName.Location = new Point(48, 109);
            lbName.Name = "lbName";
            lbName.Size = new Size(76, 17);
            lbName.TabIndex = 0;
            lbName.Text = "Full Name :";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(48, 161);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(64, 17);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Address :";
            // 
            // lnPhoneNo
            // 
            lnPhoneNo.AutoSize = true;
            lnPhoneNo.Location = new Point(48, 216);
            lnPhoneNo.Name = "lnPhoneNo";
            lnPhoneNo.Size = new Size(60, 15);
            lnPhoneNo.TabIndex = 2;
            lnPhoneNo.Text = "Phone No";
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Location = new Point(48, 275);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(73, 15);
            lbDateOfBirth.TabIndex = 3;
            lbDateOfBirth.Text = "Date of Birth";
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(48, 324);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(44, 15);
            lbCourse.TabIndex = 4;
            lbCourse.Text = "Course";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(48, 381);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 6;
            lbGender.Text = "Gender";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(448, 224);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(60, 15);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(451, 275);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(48, 436);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "E.Mail";
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(139, 109);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(326, 23);
            txtFullname.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(139, 161);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(326, 23);
            txtAddress.TabIndex = 11;
            // 
            // txtPhoneNo
            // 
            txtPhoneNo.Location = new Point(139, 216);
            txtPhoneNo.Name = "txtPhoneNo";
            txtPhoneNo.Size = new Size(257, 23);
            txtPhoneNo.TabIndex = 12;
            txtPhoneNo.TextChanged += txtPhoneNo_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(514, 221);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(194, 23);
            txtUsername.TabIndex = 13;
            // 
            // txtPw
            // 
            txtPw.Location = new Point(514, 275);
            txtPw.Name = "txtPw";
            txtPw.Size = new Size(194, 23);
            txtPw.TabIndex = 14;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(139, 428);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(257, 23);
            txtMail.TabIndex = 15;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(139, 321);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(257, 23);
            cmbCourse.TabIndex = 16;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(139, 378);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(257, 23);
            cmbGender.TabIndex = 18;
            // 
            // dtpDOB
            // 
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Location = new Point(139, 269);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(257, 23);
            dtpDOB.TabIndex = 19;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(471, 381);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 42);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(297, 39);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 21;
            label1.Text = "Student Details ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_student_903;
            pictureBox1.Location = new Point(249, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(51, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(604, 381);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 42);
            btnBack.TabIndex = 23;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPhoneError
            // 
            lblPhoneError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(139, 242);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(224, 15);
            lblPhoneError.TabIndex = 24;
            lblPhoneError.Visible = false;
            lblPhoneError.TextChanged += lblPhoneError_TextChanged;
            // 
            // lblEmailError
            // 
            lblEmailError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(139, 454);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(224, 15);
            lblEmailError.TabIndex = 25;
            lblEmailError.Visible = false;
            // 
            // lblDOBError
            // 
            lblDOBError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOBError.ForeColor = Color.Red;
            lblDOBError.Location = new Point(139, 295);
            lblDOBError.Name = "lblDOBError";
            lblDOBError.Size = new Size(224, 15);
            lblDOBError.TabIndex = 26;
            lblDOBError.Visible = false;
            // 
            // IbFullNameError
            // 
            IbFullNameError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IbFullNameError.ForeColor = Color.Red;
            IbFullNameError.Location = new Point(139, 135);
            IbFullNameError.Name = "IbFullNameError";
            IbFullNameError.Size = new Size(224, 15);
            IbFullNameError.TabIndex = 27;
            // 
            // lb1GenderError
            // 
            lb1GenderError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb1GenderError.ForeColor = Color.Red;
            lb1GenderError.Location = new Point(139, 404);
            lb1GenderError.Name = "lb1GenderError";
            lb1GenderError.Size = new Size(224, 15);
            lb1GenderError.TabIndex = 29;
            lb1GenderError.Visible = false;
            // 
            // lblCourseError
            // 
            lblCourseError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCourseError.ForeColor = Color.Red;
            lblCourseError.Location = new Point(139, 347);
            lblCourseError.Name = "lblCourseError";
            lblCourseError.Size = new Size(224, 15);
            lblCourseError.TabIndex = 30;
            lblCourseError.Visible = false;
            // 
            // lblFullnameError
            // 
            lblFullnameError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullnameError.ForeColor = Color.Red;
            lblFullnameError.Location = new Point(139, 135);
            lblFullnameError.Name = "lblFullnameError";
            lblFullnameError.Size = new Size(224, 15);
            lblFullnameError.TabIndex = 31;
            lblFullnameError.Visible = false;
            // 
            // lblAddressError
            // 
            lblAddressError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressError.ForeColor = Color.Red;
            lblAddressError.Location = new Point(139, 187);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(224, 15);
            lblAddressError.TabIndex = 32;
            lblAddressError.Visible = false;
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(736, 493);
            Controls.Add(lblAddressError);
            Controls.Add(lblFullnameError);
            Controls.Add(lblCourseError);
            Controls.Add(lb1GenderError);
            Controls.Add(IbFullNameError);
            Controls.Add(lblDOBError);
            Controls.Add(lblEmailError);
            Controls.Add(lblPhoneError);
            Controls.Add(btnBack);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(dtpDOB);
            Controls.Add(cmbGender);
            Controls.Add(cmbCourse);
            Controls.Add(txtMail);
            Controls.Add(txtPw);
            Controls.Add(txtUsername);
            Controls.Add(txtPhoneNo);
            Controls.Add(txtAddress);
            Controls.Add(txtFullname);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(lbGender);
            Controls.Add(lbCourse);
            Controls.Add(lbDateOfBirth);
            Controls.Add(lnPhoneNo);
            Controls.Add(lbAddress);
            Controls.Add(lbName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            Load += AddStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbAddress;
        private Label lnPhoneNo;
        private Label lbDateOfBirth;
        private Label lbCourse;
        private Label lbGender;
        private Label lbUserName;
        private Label lbPassword;
        private Label lbEmail;
        private TextBox txtFullname;
        private TextBox txtAddress;
        private TextBox txtPhoneNo;
        private TextBox txtUsername;
        private TextBox txtPw;
        private TextBox txtMail;
        private ComboBox cmbCourse;
        private ComboBox cmbGender;
        private DateTimePicker dtpDOB;
        private Button btnSave;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Label lblPhoneError;
        private Label lblEmailError;
        private Label lblDOBError;
        private Label IbFullNameError;
        private Label lb1GenderError;
        private Label lblCourseError;
        private Label lblFullnameError;
        private Label lblAddressError;
    }
}