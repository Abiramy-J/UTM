namespace UnicomTicManagementSystem.Views
{
    partial class AddLecturerForm
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
            lbSFullName = new Label();
            lbAddress = new Label();
            lbEmail = new Label();
            lbPhoneNo = new Label();
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            lbSubject = new Label();
            cmbSubject = new ComboBox();
            lbLecDeForm = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSFullName
            // 
            lbSFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSFullName.Location = new Point(96, 100);
            lbSFullName.Name = "lbSFullName";
            lbSFullName.Size = new Size(100, 23);
            lbSFullName.TabIndex = 1;
            lbSFullName.Text = "Full Name : ";
            // 
            // lbAddress
            // 
            lbAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(96, 140);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(100, 23);
            lbAddress.TabIndex = 2;
            lbAddress.Text = "Address : ";
            // 
            // lbEmail
            // 
            lbEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(96, 182);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(100, 23);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email : ";
            // 
            // lbPhoneNo
            // 
            lbPhoneNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhoneNo.Location = new Point(96, 219);
            lbPhoneNo.Name = "lbPhoneNo";
            lbPhoneNo.Size = new Size(100, 23);
            lbPhoneNo.TabIndex = 4;
            lbPhoneNo.Text = "Phone No : ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(96, 264);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 5;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(96, 308);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 6;
            label2.Text = "Password : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 23);
            txtName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(446, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(592, 398);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 34);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(202, 182);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(202, 139);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(361, 23);
            txtAddress.TabIndex = 16;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(202, 218);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(361, 23);
            txtPhone.TabIndex = 17;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(202, 264);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(361, 23);
            txtUsername.TabIndex = 18;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(202, 308);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(361, 23);
            txtPassword.TabIndex = 19;
            // 
            // lbSubject
            // 
            lbSubject.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubject.Location = new Point(96, 354);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(100, 23);
            lbSubject.TabIndex = 20;
            lbSubject.Text = "Subject : ";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(202, 354);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(213, 23);
            cmbSubject.TabIndex = 21;
            // 
            // lbLecDeForm
            // 
            lbLecDeForm.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lbLecDeForm.ForeColor = Color.Navy;
            lbLecDeForm.Location = new Point(310, 29);
            lbLecDeForm.Name = "lbLecDeForm";
            lbLecDeForm.Size = new Size(367, 41);
            lbLecDeForm.TabIndex = 22;
            lbLecDeForm.Text = "Lecturer Details Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_lecturer_1001;
            pictureBox1.Location = new Point(270, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // AddLecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(736, 493);
            Controls.Add(pictureBox1);
            Controls.Add(lbLecDeForm);
            Controls.Add(cmbSubject);
            Controls.Add(lbSubject);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbPhoneNo);
            Controls.Add(lbEmail);
            Controls.Add(lbAddress);
            Controls.Add(lbSFullName);
            Name = "AddLecturerForm";
            Text = "AddLecturerForm";
            Load += AddLecturerForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSFullName;
        private Label lbAddress;
        private Label lbEmail;
        private Label lbPhoneNo;
        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnSave;
        private Button btnBack;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label lbSubject;
        private ComboBox cmbSubject;
        private Label lbLecDeForm;
        private PictureBox pictureBox1;
    }
}