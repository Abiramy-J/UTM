namespace UnicomTicManagementSystem.Views
{
    partial class AddStaffForm
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
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPhone = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            lblFullnameError = new Label();
            lblAddressError = new Label();
            lblPhoneError = new Label();
            lblEmailError = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbSFullName
            // 
            lbSFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSFullName.Location = new Point(92, 108);
            lbSFullName.Name = "lbSFullName";
            lbSFullName.Size = new Size(100, 23);
            lbSFullName.TabIndex = 0;
            lbSFullName.Text = "Full Name : ";
            // 
            // lbAddress
            // 
            lbAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(92, 158);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(100, 23);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Address : ";
            // 
            // lbEmail
            // 
            lbEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(92, 203);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(63, 23);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email : ";
            // 
            // lbPhoneNo
            // 
            lbPhoneNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhoneNo.Location = new Point(92, 250);
            lbPhoneNo.Name = "lbPhoneNo";
            lbPhoneNo.Size = new Size(100, 23);
            lbPhoneNo.TabIndex = 3;
            lbPhoneNo.Text = "Phone No : ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 295);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(92, 343);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Password : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(198, 108);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 23);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(198, 202);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(198, 158);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(361, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(198, 294);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(361, 23);
            txtUsername.TabIndex = 9;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(198, 343);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(361, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(198, 250);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(361, 23);
            txtPhone.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(421, 407);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(566, 407);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 35);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Historic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(323, 42);
            label3.Name = "label3";
            label3.Size = new Size(236, 38);
            label3.TabIndex = 14;
            label3.Text = "Staff Details ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_staff_1001;
            pictureBox1.Location = new Point(274, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // lblFullnameError
            // 
            lblFullnameError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullnameError.ForeColor = Color.Red;
            lblFullnameError.Location = new Point(198, 134);
            lblFullnameError.Name = "lblFullnameError";
            lblFullnameError.Size = new Size(224, 15);
            lblFullnameError.TabIndex = 32;
            lblFullnameError.Visible = false;
            // 
            // lblAddressError
            // 
            lblAddressError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddressError.ForeColor = Color.Red;
            lblAddressError.Location = new Point(198, 184);
            lblAddressError.Name = "lblAddressError";
            lblAddressError.Size = new Size(224, 15);
            lblAddressError.TabIndex = 33;
            lblAddressError.Visible = false;
            // 
            // lblPhoneError
            // 
            lblPhoneError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneError.ForeColor = Color.Red;
            lblPhoneError.Location = new Point(198, 276);
            lblPhoneError.Name = "lblPhoneError";
            lblPhoneError.Size = new Size(224, 15);
            lblPhoneError.TabIndex = 34;
            lblPhoneError.Visible = false;
            // 
            // lblEmailError
            // 
            lblEmailError.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailError.ForeColor = Color.Red;
            lblEmailError.Location = new Point(198, 224);
            lblEmailError.Name = "lblEmailError";
            lblEmailError.Size = new Size(224, 15);
            lblEmailError.TabIndex = 35;
            lblEmailError.Visible = false;
            // 
            // AddStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(736, 493);
            Controls.Add(lblEmailError);
            Controls.Add(lblPhoneError);
            Controls.Add(lblAddressError);
            Controls.Add(lblFullnameError);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(txtPhone);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbPhoneNo);
            Controls.Add(lbEmail);
            Controls.Add(lbAddress);
            Controls.Add(lbSFullName);
            Name = "AddStaffForm";
            Text = "AddStaffForm";
            Load += AddStaffForm_Load;
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
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPhone;
        private Button btnSave;
        private Button btnBack;
        private Label label3;
        private PictureBox pictureBox1;
        private Label lblFullnameError;
        private Label lblAddressError;
        private Label lblPhoneError;
        private Label lblEmailError;
    }
}