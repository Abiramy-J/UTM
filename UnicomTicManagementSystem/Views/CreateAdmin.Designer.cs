namespace UnicomTicManagementSystem.Views
{
    partial class CreateAdmin
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
            lbUsername = new Label();
            txtUsername = new TextBox();
            dgvAdmin = new DataGridView();
            lbPassword = new Label();
            lbCPassword = new Label();
            txtPassword = new TextBox();
            txtCPassword = new TextBox();
            btnCreateAdmin = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(188, 46);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(100, 23);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Usename :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(294, 47);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 23);
            txtUsername.TabIndex = 1;
            // 
            // dgvAdmin
            // 
            dgvAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAdmin.Location = new Point(43, 198);
            dgvAdmin.Name = "dgvAdmin";
            dgvAdmin.Size = new Size(480, 223);
            dgvAdmin.TabIndex = 2;
            dgvAdmin.CellClick += dgvAdmin_CellClick;
            dgvAdmin.CellContentClick += dgvAdmin_CellContentClick;
            // 
            // lbPassword
            // 
            lbPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(188, 86);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(100, 23);
            lbPassword.TabIndex = 4;
            lbPassword.Text = "Password:";
            // 
            // lbCPassword
            // 
            lbCPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCPassword.Location = new Point(124, 127);
            lbCPassword.Name = "lbCPassword";
            lbCPassword.Size = new Size(164, 23);
            lbCPassword.TabIndex = 5;
            lbCPassword.Text = "Confirm Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(294, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 23);
            txtPassword.TabIndex = 6;
            // 
            // txtCPassword
            // 
            txtCPassword.Location = new Point(294, 128);
            txtCPassword.Name = "txtCPassword";
            txtCPassword.Size = new Size(224, 23);
            txtCPassword.TabIndex = 7;
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.BackColor = SystemColors.ActiveCaption;
            btnCreateAdmin.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAdmin.Location = new Point(564, 232);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(143, 34);
            btnCreateAdmin.TabIndex = 8;
            btnCreateAdmin.Text = "Create Admin";
            btnCreateAdmin.UseVisualStyleBackColor = false;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(564, 302);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(143, 34);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // CreateAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 492);
            Controls.Add(btnBack);
            Controls.Add(btnCreateAdmin);
            Controls.Add(txtCPassword);
            Controls.Add(txtPassword);
            Controls.Add(lbCPassword);
            Controls.Add(lbPassword);
            Controls.Add(dgvAdmin);
            Controls.Add(txtUsername);
            Controls.Add(lbUsername);
            Name = "CreateAdmin";
            Text = "CreateAdmin";
            Load += CreateAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAdmin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private TextBox txtUsername;
        private DataGridView dgvAdmin;
        private Label lbPassword;
        private Label lbCPassword;
        private TextBox txtPassword;
        private TextBox txtCPassword;
        private Button btnCreateAdmin;
        private Button btnBack;
    }
}