namespace UnicomTicManagementSystem.Views
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
            lbSubject = new Label();
            lbGender = new Label();
            lbUserName = new Label();
            lbPassword = new Label();
            lbEmail = new Label();
            SuspendLayout();
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(56, 9);
            lbName.Name = "lbName";
            lbName.Size = new Size(61, 15);
            lbName.TabIndex = 0;
            lbName.Text = "Full Name";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Location = new Point(56, 45);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(49, 15);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Address";
            // 
            // lnPhoneNo
            // 
            lnPhoneNo.AutoSize = true;
            lnPhoneNo.Location = new Point(56, 90);
            lnPhoneNo.Name = "lnPhoneNo";
            lnPhoneNo.Size = new Size(60, 15);
            lnPhoneNo.TabIndex = 2;
            lnPhoneNo.Text = "Phone No";
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Location = new Point(56, 146);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(73, 15);
            lbDateOfBirth.TabIndex = 3;
            lbDateOfBirth.Text = "Date of Birth";
            // 
            // lbCourse
            // 
            lbCourse.AutoSize = true;
            lbCourse.Location = new Point(56, 182);
            lbCourse.Name = "lbCourse";
            lbCourse.Size = new Size(44, 15);
            lbCourse.TabIndex = 4;
            lbCourse.Text = "Course";
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Location = new Point(56, 232);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(46, 15);
            lbSubject.TabIndex = 5;
            lbSubject.Text = "Subject";
            // 
            // lbGender
            // 
            lbGender.AutoSize = true;
            lbGender.Location = new Point(56, 275);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(45, 15);
            lbGender.TabIndex = 6;
            lbGender.Text = "Gender";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Location = new Point(56, 327);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(60, 15);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(56, 376);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(66, 410);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "E.Mail";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbUserName);
            Controls.Add(lbGender);
            Controls.Add(lbSubject);
            Controls.Add(lbCourse);
            Controls.Add(lbDateOfBirth);
            Controls.Add(lnPhoneNo);
            Controls.Add(lbAddress);
            Controls.Add(lbName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbName;
        private Label lbAddress;
        private Label lnPhoneNo;
        private Label lbDateOfBirth;
        private Label lbCourse;
        private Label lbSubject;
        private Label lbGender;
        private Label lbUserName;
        private Label lbPassword;
        private Label lbEmail;
    }
}