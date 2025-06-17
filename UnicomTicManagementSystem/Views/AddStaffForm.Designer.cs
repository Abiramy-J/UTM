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
            SuspendLayout();
            // 
            // lbSFullName
            // 
            lbSFullName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSFullName.Location = new Point(55, 69);
            lbSFullName.Name = "lbSFullName";
            lbSFullName.Size = new Size(100, 23);
            lbSFullName.TabIndex = 0;
            lbSFullName.Text = "Full Name : ";
            // 
            // lbAddress
            // 
            lbAddress.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(66, 107);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(100, 23);
            lbAddress.TabIndex = 1;
            lbAddress.Text = "Address : ";
            // 
            // lbEmail
            // 
            lbEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(80, 159);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(100, 23);
            lbEmail.TabIndex = 2;
            lbEmail.Text = "Email : ";
            // 
            // lbPhoneNo
            // 
            lbPhoneNo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhoneNo.Location = new Point(54, 212);
            lbPhoneNo.Name = "lbPhoneNo";
            lbPhoneNo.Size = new Size(100, 23);
            lbPhoneNo.TabIndex = 3;
            lbPhoneNo.Text = "Phone No : ";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 271);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            label1.Text = "Username : ";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(54, 326);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 5;
            label2.Text = "Password : ";
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 69);
            txtName.Name = "txtName";
            txtName.Size = new Size(361, 23);
            txtName.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 158);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(361, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(138, 107);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(361, 23);
            txtAddress.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(138, 271);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(361, 23);
            txtUsername.TabIndex = 9;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(138, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(361, 23);
            txtPassword.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(138, 212);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(361, 23);
            txtPhone.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Location = new Point(565, 377);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(670, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}