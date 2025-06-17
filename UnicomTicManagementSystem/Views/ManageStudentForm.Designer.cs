namespace UnicomTicManagementSystem.Views
{
    partial class ManageStudentForm
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
            dgvStudents = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnBack = new Button();
            lbMStudentRecords = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(251, 61);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(686, 340);
            dgvStudents.TabIndex = 0;
            dgvStudents.CellClick += dgvStudents_CellClick;
            dgvStudents.CellContentClick += dgvStudents_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(251, 414);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(168, 33);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(512, 414);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(168, 33);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(769, 414);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(168, 33);
            btnBack.TabIndex = 3;
            btnBack.Text = "BACK";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lbMStudentRecords
            // 
            lbMStudentRecords.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbMStudentRecords.ForeColor = Color.RoyalBlue;
            lbMStudentRecords.Location = new Point(432, 9);
            lbMStudentRecords.Name = "lbMStudentRecords";
            lbMStudentRecords.Size = new Size(344, 36);
            lbMStudentRecords.TabIndex = 4;
            lbMStudentRecords.Text = "Manage Student Records";
            lbMStudentRecords.TextAlign = ContentAlignment.MiddleCenter;
            lbMStudentRecords.Click += lbMStudentRecords_Click;
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 459);
            Controls.Add(lbMStudentRecords);
            Controls.Add(btnBack);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvStudents);
            Name = "ManageStudentForm";
            Text = "ManageStudentForm";
            Load += ManageStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnBack;
        private Label lbMStudentRecords;
    }
}