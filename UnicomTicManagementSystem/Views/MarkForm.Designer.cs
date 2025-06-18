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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbStudent = new ComboBox();
            cmbExam = new ComboBox();
            txtScore = new TextBox();
            dgvMarks = new DataGridView();
            btnMAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMarks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 64);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Student :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(85, 133);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Score :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(85, 99);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Exam :";
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
            dgvMarks.Location = new Point(298, 186);
            dgvMarks.Name = "dgvMarks";
            dgvMarks.Size = new Size(275, 178);
            dgvMarks.TabIndex = 6;
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
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnMAdd);
            Controls.Add(dgvMarks);
            Controls.Add(txtScore);
            Controls.Add(cmbExam);
            Controls.Add(cmbStudent);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MarkForm";
            Text = "MarkForm";
            Load += MarkForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbStudent;
        private ComboBox cmbExam;
        private TextBox txtScore;
        private DataGridView dgvMarks;
        private Button btnMAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
    }
}