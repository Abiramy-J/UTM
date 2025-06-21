namespace UnicomTicManagementSystem.Views
{
    partial class LoginForm
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
            btnLogin = new Button();
            lb1Username = new Label();
            Ib1Password = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveCaption;
            btnLogin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(99, 410);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(176, 45);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lb1Username
            // 
            lb1Username.AutoSize = true;
            lb1Username.Font = new Font("Segoe UI", 15F);
            lb1Username.Location = new Point(24, 185);
            lb1Username.Name = "lb1Username";
            lb1Username.Size = new Size(99, 28);
            lb1Username.TabIndex = 1;
            lb1Username.Text = "Username";
            // 
            // Ib1Password
            // 
            Ib1Password.AutoSize = true;
            Ib1Password.Font = new Font("Segoe UI", 15F);
            Ib1Password.Location = new Point(24, 284);
            Ib1Password.Name = "Ib1Password";
            Ib1Password.Size = new Size(93, 28);
            Ib1Password.TabIndex = 2;
            Ib1Password.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 13F);
            txtPassword.Location = new Point(24, 328);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 31);
            txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 13F);
            txtUsername.Location = new Point(24, 227);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(310, 31);
            txtUsername.TabIndex = 4;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(69, 128);
            label1.Name = "label1";
            label1.Size = new Size(237, 47);
            label1.TabIndex = 6;
            label1.Text = "Login to Your Account";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_lock_50;
            pictureBox1.Location = new Point(142, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.WhatsApp_Image_2025_06_21_at_00_09_19_f34a488c;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(384, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 545);
            panel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(637, 545);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(Ib1Password);
            Controls.Add(lb1Username);
            Controls.Add(btnLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Label lb1Username;
        private Label Ib1Password;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}