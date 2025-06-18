namespace UnicomTicManagementSystem.Views
{
    partial class ManageLecturerForm
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
            dgvLecturers = new DataGridView();
            btnLeUpdate = new Button();
            btnLeDelete = new Button();
            btnLeBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLecturers).BeginInit();
            SuspendLayout();
            // 
            // dgvLecturers
            // 
            dgvLecturers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLecturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLecturers.Location = new Point(240, 30);
            dgvLecturers.Name = "dgvLecturers";
            dgvLecturers.Size = new Size(686, 340);
            dgvLecturers.TabIndex = 2;
            dgvLecturers.CellClick += dgvLecturers_CellClick;
            // 
            // btnLeUpdate
            // 
            btnLeUpdate.BackColor = SystemColors.ActiveCaption;
            btnLeUpdate.Cursor = Cursors.Hand;
            btnLeUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeUpdate.Location = new Point(240, 395);
            btnLeUpdate.Name = "btnLeUpdate";
            btnLeUpdate.Size = new Size(168, 33);
            btnLeUpdate.TabIndex = 3;
            btnLeUpdate.Text = "UPDATE";
            btnLeUpdate.UseVisualStyleBackColor = false;
            btnLeUpdate.Click += btnLeUpdate_Click;
            // 
            // btnLeDelete
            // 
            btnLeDelete.BackColor = SystemColors.ActiveCaption;
            btnLeDelete.Cursor = Cursors.Hand;
            btnLeDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeDelete.Location = new Point(492, 395);
            btnLeDelete.Name = "btnLeDelete";
            btnLeDelete.Size = new Size(168, 33);
            btnLeDelete.TabIndex = 4;
            btnLeDelete.Text = "DELETE";
            btnLeDelete.UseVisualStyleBackColor = false;
            btnLeDelete.Click += btnLeDelete_Click;
            // 
            // btnLeBack
            // 
            btnLeBack.BackColor = SystemColors.ActiveCaption;
            btnLeBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeBack.Location = new Point(758, 395);
            btnLeBack.Name = "btnLeBack";
            btnLeBack.Size = new Size(168, 33);
            btnLeBack.TabIndex = 5;
            btnLeBack.Text = "BACK";
            btnLeBack.UseVisualStyleBackColor = false;
            btnLeBack.Click += btnLeBack_Click;
            // 
            // ManageLecturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 459);
            Controls.Add(btnLeBack);
            Controls.Add(btnLeDelete);
            Controls.Add(btnLeUpdate);
            Controls.Add(dgvLecturers);
            Name = "ManageLecturerForm";
            Text = "ManageLecturerForm";
            ((System.ComponentModel.ISupportInitialize)dgvLecturers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLecturers;
        private Button btnLeUpdate;
        private Button btnLeDelete;
        private Button btnLeBack;
    }
}