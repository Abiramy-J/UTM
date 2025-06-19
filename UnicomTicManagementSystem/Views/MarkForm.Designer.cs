namespace UnicomTicManagementSystem.Views
{
    partial class MarkForm
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
            lblStudent = new Label();
            lblScore = new Label();
            lblExam = new Label();
            cmbStudent = new ComboBox();
            cmbExam = new ComboBox();
            txtScore = new TextBox();
            dgvMarks = new DataGridView();
            btnMAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            lbMSubject = new Label();
            cmbSubjects = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvMarks).BeginInit();
            SuspendLayout();
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudent.Location = new Point(76, 64);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(70, 20);
            lblStudent.TabIndex = 0;
            lblStudent.Text = "Student :";
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblScore.Location = new Point(85, 133);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(55, 20);
            lblScore.TabIndex = 1;
            lblScore.Text = "Score :";
            // 
            // lblExam
            // 
            lblExam.AutoSize = true;
            lblExam.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExam.Location = new Point(85, 99);
            lblExam.Name = "lblExam";
            lblExam.Size = new Size(54, 20);
            lblExam.TabIndex = 2;
            lblExam.Text = "Exam :";
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(179, 64);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(188, 23);
            cmbStudent.TabIndex = 3;
            // 
            // cmbExam
            // 
            cmbExam.FormattingEnabled = true;
            cmbExam.Location = new Point(179, 93);
            cmbExam.Name = "cmbExam";
            cmbExam.Size = new Size(188, 23);
            cmbExam.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(171, 130);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(196, 23);
            txtScore.TabIndex = 5;
            // 
            // dgvMarks
            // 
            dgvMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarks.Location = new Point(298, 176);
            dgvMarks.Name = "dgvMarks";
            dgvMarks.Size = new Size(476, 245);
            dgvMarks.TabIndex = 6;
            dgvMarks.CellClick += dgvMarks_CellClick;
            // 
            // btnMAdd
            // 
            btnMAdd.BackColor = SystemColors.ActiveCaption;
            btnMAdd.Cursor = Cursors.Hand;
            btnMAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMAdd.Location = new Point(100, 186);
            btnMAdd.Name = "btnMAdd";
            btnMAdd.Size = new Size(168, 33);
            btnMAdd.TabIndex = 7;
            btnMAdd.Text = "ADD";
            btnMAdd.UseVisualStyleBackColor = false;
            btnMAdd.Click += btnMAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(85, 234);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 33);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(76, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 33);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(76, 342);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 33);
            btnBack.TabIndex = 10;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbMSubject
            // 
            lbMSubject.AutoSize = true;
            lbMSubject.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMSubject.Location = new Point(436, 67);
            lbMSubject.Name = "lbMSubject";
            lbMSubject.Size = new Size(67, 20);
            lbMSubject.TabIndex = 11;
            lbMSubject.Text = "Subject :";
            // 
            // cmbSubjects
            // 
            cmbSubjects.FormattingEnabled = true;
            cmbSubjects.Location = new Point(532, 61);
            cmbSubjects.Name = "cmbSubjects";
            cmbSubjects.Size = new Size(188, 23);
            cmbSubjects.TabIndex = 12;
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbSubjects);
            Controls.Add(lbMSubject);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnMAdd);
            Controls.Add(dgvMarks);
            Controls.Add(txtScore);
            Controls.Add(cmbExam);
            Controls.Add(cmbStudent);
            Controls.Add(lblExam);
            Controls.Add(lblScore);
            Controls.Add(lblStudent);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudent;
        private Label lblScore;
        private Label lblExam;
        private ComboBox cmbStudent;
        private ComboBox cmbExam;
        private TextBox txtScore;
        private DataGridView dgvMarks;
        private Button btnMAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private Label lbMSubject;
        private ComboBox cmbSubjects;
    }
}