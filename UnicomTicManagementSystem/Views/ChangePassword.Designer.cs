namespace UnicomTicManagementSystem.Views
{
    partial class ChangePassword
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
            lblPw = new Label();
            lblUn = new Label();
            lblP = new Label();
            lbNP = new Label();
            txtU = new TextBox();
            txtNP = new TextBox();
            txtP = new TextBox();
            txtCP = new TextBox();
            btnCP = new Button();
            btnBack = new Button();
            lblValidation = new Label();
            SuspendLayout();
            // 
            // lblPw
            // 
            lblPw.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPw.Location = new Point(170, 158);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(156, 32);
            lblPw.TabIndex = 3;
            lblPw.Text = "Current Password :";
            // 
            // lblUn
            // 
            lblUn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUn.Location = new Point(222, 117);
            lblUn.Name = "lblUn";
            lblUn.Size = new Size(104, 32);
            lblUn.TabIndex = 4;
            lblUn.Text = "Username :";
            // 
            // lblP
            // 
            lblP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblP.Location = new Point(170, 252);
            lblP.Name = "lblP";
            lblP.Size = new Size(156, 32);
            lblP.TabIndex = 5;
            lblP.Text = "Confirm Password :";
            lblP.Click += lblP_Click;
            // 
            // lbNP
            // 
            lbNP.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNP.Location = new Point(192, 204);
            lbNP.Name = "lbNP";
            lbNP.Size = new Size(134, 32);
            lbNP.TabIndex = 6;
            lbNP.Text = "New Password :";
            // 
            // txtU
            // 
            txtU.Location = new Point(332, 117);
            txtU.Name = "txtU";
            txtU.Size = new Size(210, 23);
            txtU.TabIndex = 7;
            // 
            // txtNP
            // 
            txtNP.Location = new Point(332, 204);
            txtNP.Name = "txtNP";
            txtNP.Size = new Size(210, 23);
            txtNP.TabIndex = 8;
            // 
            // txtP
            // 
            txtP.Location = new Point(332, 254);
            txtP.Name = "txtP";
            txtP.Size = new Size(210, 23);
            txtP.TabIndex = 9;
            // 
            // txtCP
            // 
            txtCP.Location = new Point(332, 158);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(210, 23);
            txtCP.TabIndex = 10;
            // 
            // btnCP
            // 
            btnCP.BackColor = SystemColors.ActiveCaption;
            btnCP.Cursor = Cursors.Hand;
            btnCP.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCP.Location = new Point(267, 371);
            btnCP.Name = "btnCP";
            btnCP.Size = new Size(148, 33);
            btnCP.TabIndex = 15;
            btnCP.Text = "Change Password";
            btnCP.UseVisualStyleBackColor = false;
            btnCP.Click += btnCP_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(484, 371);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(148, 33);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblValidation
            // 
            lblValidation.AutoSize = true;
            lblValidation.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValidation.ForeColor = Color.Red;
            lblValidation.Location = new Point(267, 306);
            lblValidation.Name = "lblValidation";
            lblValidation.Size = new Size(0, 15);
            lblValidation.TabIndex = 17;
            lblValidation.Visible = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(825, 450);
            Controls.Add(lblValidation);
            Controls.Add(btnBack);
            Controls.Add(btnCP);
            Controls.Add(txtCP);
            Controls.Add(txtP);
            Controls.Add(txtNP);
            Controls.Add(txtU);
            Controls.Add(lbNP);
            Controls.Add(lblP);
            Controls.Add(lblUn);
            Controls.Add(lblPw);
            Name = "ChangePassword";
            Text = "ChangePassword";
            Load += ChangePassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPw;
        private Label lblUn;
        private Label lblP;
        private Label lbNP;
        private TextBox txtU;
        private TextBox txtNP;
        private TextBox txtP;
        private TextBox txtCP;
        private Button btnCP;
        private Button btnBack;
        private Label lblValidation;
    }
}