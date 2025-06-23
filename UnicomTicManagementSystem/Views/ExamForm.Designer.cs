namespace UnicomTicManagementSystem.Views
{
    partial class ExamForm
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
            lbExamName = new Label();
            dtpExamDate = new DateTimePicker();
            cmbSubject = new ComboBox();
            txtExamName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvExam = new DataGridView();
            btnBack = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            labelEA = new Label();
            pictureBox1 = new PictureBox();
            lblSubjectWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvExam).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbExamName
            // 
            lbExamName.AutoSize = true;
            lbExamName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbExamName.Location = new Point(12, 467);
            lbExamName.Name = "lbExamName";
            lbExamName.Size = new Size(95, 20);
            lbExamName.TabIndex = 0;
            lbExamName.Text = "Exam Name:";
            // 
            // dtpExamDate
            // 
            dtpExamDate.CustomFormat = "mmm dd yyyy ddd";
            dtpExamDate.Location = new Point(118, 413);
            dtpExamDate.Name = "dtpExamDate";
            dtpExamDate.Size = new Size(219, 23);
            dtpExamDate.TabIndex = 1;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(472, 464);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(155, 23);
            cmbSubject.TabIndex = 2;
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(118, 464);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(224, 23);
            txtExamName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 416);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 4;
            label1.Text = "Exam Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(389, 467);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "Subject :";
            // 
            // dgvExam
            // 
            dgvExam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExam.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExam.Location = new Point(41, 112);
            dgvExam.Name = "dgvExam";
            dgvExam.Size = new Size(586, 277);
            dgvExam.TabIndex = 6;
            dgvExam.CellClick += dgvExam_CellClick;
            dgvExam.CellContentClick += dgvExam_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(683, 356);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 33);
            btnBack.TabIndex = 7;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(683, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 30);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(683, 235);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 33);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveCaption;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(683, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(168, 33);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // labelEA
            // 
            labelEA.BackColor = SystemColors.ControlLight;
            labelEA.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelEA.ForeColor = Color.Navy;
            labelEA.Location = new Point(367, 39);
            labelEA.Name = "labelEA";
            labelEA.Size = new Size(196, 47);
            labelEA.TabIndex = 35;
            labelEA.Text = "Exam Allocations";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_exam_100__1_;
            pictureBox1.Location = new Point(329, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(43, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 36;
            pictureBox1.TabStop = false;
            // 
            // lblSubjectWarning
            // 
            lblSubjectWarning.AutoSize = true;
            lblSubjectWarning.Location = new Point(525, 490);
            lblSubjectWarning.Name = "lblSubjectWarning";
            lblSubjectWarning.Size = new Size(0, 15);
            lblSubjectWarning.TabIndex = 37;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(945, 536);
            Controls.Add(lblSubjectWarning);
            Controls.Add(pictureBox1);
            Controls.Add(labelEA);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnBack);
            Controls.Add(dgvExam);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtExamName);
            Controls.Add(cmbSubject);
            Controls.Add(dtpExamDate);
            Controls.Add(lbExamName);
            Name = "ExamForm";
            Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)dgvExam).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbExamName;
        private DateTimePicker dtpExamDate;
        private ComboBox cmbSubject;
        private TextBox txtExamName;
        private Label label1;
        private Label label2;
        private DataGridView dgvExam;
        private Button btnBack;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Label labelEA;
        private PictureBox pictureBox1;
        private Label lblSubjectWarning;
    }
}