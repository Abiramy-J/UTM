namespace UnicomTicManagementSystem.Views
{
    partial class CreateUserPannel
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
            panelside = new Panel();
            pictureBox1 = new PictureBox();
            lbCreateUser = new Label();
            btnAdmin = new Button();
            btnStudent = new Button();
            button2 = new Button();
            btnStaff = new Button();
            panelHead = new Panel();
            btnCloseCU = new Button();
            pnlCreateUser = new Panel();
            panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHead.SuspendLayout();
            SuspendLayout();
            // 
            // panelside
            // 
            panelside.BackColor = SystemColors.ActiveBorder;
            panelside.Controls.Add(pictureBox1);
            panelside.Controls.Add(lbCreateUser);
            panelside.Controls.Add(btnAdmin);
            panelside.Controls.Add(btnStudent);
            panelside.Controls.Add(button2);
            panelside.Controls.Add(btnStaff);
            panelside.Dock = DockStyle.Left;
            panelside.Location = new Point(0, 30);
            panelside.Name = "panelside";
            panelside.Size = new Size(200, 498);
            panelside.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_staff_100;
            pictureBox1.Location = new Point(48, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 84);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lbCreateUser
            // 
            lbCreateUser.AutoSize = true;
            lbCreateUser.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbCreateUser.Location = new Point(41, 113);
            lbCreateUser.Name = "lbCreateUser";
            lbCreateUser.Size = new Size(106, 21);
            lbCreateUser.TabIndex = 2;
            lbCreateUser.Text = "Create Users";
            lbCreateUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = SystemColors.ActiveCaption;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.Location = new Point(12, 383);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(178, 38);
            btnAdmin.TabIndex = 5;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnStudent
            // 
            btnStudent.BackColor = SystemColors.ActiveCaption;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.Location = new Point(12, 174);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(178, 38);
            btnStudent.TabIndex = 2;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(12, 309);
            button2.Name = "button2";
            button2.Size = new Size(178, 38);
            button2.TabIndex = 4;
            button2.Text = "Leturer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnStaff
            // 
            btnStaff.BackColor = SystemColors.ActiveCaption;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaff.Location = new Point(12, 244);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(178, 38);
            btnStaff.TabIndex = 3;
            btnStaff.Text = "Staff";
            btnStaff.UseVisualStyleBackColor = false;
            btnStaff.Click += btnStaff_Click;
            // 
            // panelHead
            // 
            panelHead.BackColor = SystemColors.ActiveBorder;
            panelHead.Controls.Add(btnCloseCU);
            panelHead.Dock = DockStyle.Top;
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(984, 30);
            panelHead.TabIndex = 1;
            // 
            // btnCloseCU
            // 
            btnCloseCU.BackColor = SystemColors.ActiveBorder;
            btnCloseCU.FlatStyle = FlatStyle.Flat;
            btnCloseCU.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCloseCU.ForeColor = Color.Red;
            btnCloseCU.Location = new Point(944, 0);
            btnCloseCU.Name = "btnCloseCU";
            btnCloseCU.Size = new Size(40, 30);
            btnCloseCU.TabIndex = 7;
            btnCloseCU.Text = "X";
            btnCloseCU.UseVisualStyleBackColor = false;
            btnCloseCU.Click += btnCloseCU_Click;
            // 
            // pnlCreateUser
            // 
            pnlCreateUser.Dock = DockStyle.Fill;
            pnlCreateUser.Location = new Point(200, 30);
            pnlCreateUser.Name = "pnlCreateUser";
            pnlCreateUser.Size = new Size(784, 498);
            pnlCreateUser.TabIndex = 2;
            pnlCreateUser.Paint += pnlCreateUser_Paint;
            // 
            // CreateUserPannel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 528);
            Controls.Add(pnlCreateUser);
            Controls.Add(panelside);
            Controls.Add(panelHead);
            Name = "CreateUserPannel";
            Text = "CreateUserPannel";
            Load += CreateUserPannel_Load;
            panelside.ResumeLayout(false);
            panelside.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHead.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelside;
        private Panel panelHead;
        private Button btnStudent;
        private Button btnAdmin;
        private Button button2;
        private Button btnStaff;
        private PictureBox pictureBox1;
        private Label lbCreateUser;
        private Button btnCloseCU;
        private Panel pnlCreateUser;
    }
}