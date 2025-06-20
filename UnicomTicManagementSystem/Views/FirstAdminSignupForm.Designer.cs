namespace UnicomTicManagementSystem.Views
{
    partial class FirstAdminSignupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstAdminSignupForm));
            lbUsername = new Label();
            lbPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            lbConfirm = new Label();
            btnCreateAdmin = new Button();
            lbPwNote = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 15F);
            lbUsername.ForeColor = SystemColors.ControlText;
            lbUsername.Location = new Point(30, 167);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(99, 28);
            lbUsername.TabIndex = 0;
            lbUsername.Text = "Username";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 15F);
            lbPassword.Location = new Point(30, 244);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(93, 28);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(30, 198);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(370, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Window;
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(30, 275);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(370, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirm
            // 
            txtConfirm.Font = new Font("Segoe UI", 13F);
            txtConfirm.Location = new Point(30, 378);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(370, 31);
            txtConfirm.TabIndex = 4;
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.Font = new Font("Segoe UI", 15F);
            lbConfirm.Location = new Point(30, 347);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(168, 28);
            lbConfirm.TabIndex = 5;
            lbConfirm.Text = "Confirm Password";
            // 
            // btnCreateAdmin
            // 
            btnCreateAdmin.BackColor = SystemColors.ActiveCaption;
            btnCreateAdmin.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAdmin.ForeColor = SystemColors.ControlText;
            btnCreateAdmin.Location = new Point(115, 453);
            btnCreateAdmin.Name = "btnCreateAdmin";
            btnCreateAdmin.Size = new Size(242, 37);
            btnCreateAdmin.TabIndex = 6;
            btnCreateAdmin.Text = "CreateAdmin";
            btnCreateAdmin.UseVisualStyleBackColor = false;
            btnCreateAdmin.Click += btnCreateAdmin_Click;
            // 
            // lbPwNote
            // 
            lbPwNote.AutoSize = true;
            lbPwNote.Font = new Font("Segoe UI", 9F);
            lbPwNote.Location = new Point(30, 309);
            lbPwNote.Name = "lbPwNote";
            lbPwNote.Size = new Size(370, 15);
            lbPwNote.TabIndex = 7;
            lbPwNote.Text = "Password must be 6–12 characters, must include letters and numbers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(157, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(102, 118);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 9;
            label1.Text = "Create First Admin";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(421, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 521);
            panel1.TabIndex = 10;
            // 
            // FirstAdminSignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(663, 521);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lbPwNote);
            Controls.Add(btnCreateAdmin);
            Controls.Add(lbConfirm);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "FirstAdminSignupForm";
            Text = "FirstAdminSignupForm";
            Load += FirstAdminSignupForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Label lbConfirm;
        private Button btnCreateAdmin;
        private Label lbPwNote;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
    }
}