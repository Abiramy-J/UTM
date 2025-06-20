namespace UnicomTicManagementSystem.Views
{
    partial class ManageStaffForm
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
            dgvStaff = new DataGridView();
            btnStaffUpdate = new Button();
            btnStaffDelete = new Button();
            btnStaffBack = new Button();
            labelMStaff = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvStaff
            // 
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStaff.Location = new Point(225, 106);
            dgvStaff.Name = "dgvStaff";
            dgvStaff.Size = new Size(686, 269);
            dgvStaff.TabIndex = 1;
            dgvStaff.CellClick += dgvStaff_CellClick;
            dgvStaff.CellContentClick += dgvStaff_CellClick;
            // 
            // btnStaffUpdate
            // 
            btnStaffUpdate.BackColor = SystemColors.ActiveCaption;
            btnStaffUpdate.Cursor = Cursors.Hand;
            btnStaffUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffUpdate.Location = new Point(234, 405);
            btnStaffUpdate.Name = "btnStaffUpdate";
            btnStaffUpdate.Size = new Size(168, 33);
            btnStaffUpdate.TabIndex = 2;
            btnStaffUpdate.Text = "UPDATE";
            btnStaffUpdate.UseVisualStyleBackColor = false;
            btnStaffUpdate.Click += btnStaffUpdate_Click;
            // 
            // btnStaffDelete
            // 
            btnStaffDelete.BackColor = SystemColors.ActiveCaption;
            btnStaffDelete.Cursor = Cursors.Hand;
            btnStaffDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffDelete.Location = new Point(491, 405);
            btnStaffDelete.Name = "btnStaffDelete";
            btnStaffDelete.Size = new Size(168, 33);
            btnStaffDelete.TabIndex = 3;
            btnStaffDelete.Text = "DELETE";
            btnStaffDelete.UseVisualStyleBackColor = false;
            btnStaffDelete.Click += btnStaffDelete_Click;
            // 
            // btnStaffBack
            // 
            btnStaffBack.BackColor = SystemColors.ActiveCaption;
            btnStaffBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStaffBack.Location = new Point(743, 405);
            btnStaffBack.Name = "btnStaffBack";
            btnStaffBack.Size = new Size(168, 33);
            btnStaffBack.TabIndex = 4;
            btnStaffBack.Text = "BACK";
            btnStaffBack.UseVisualStyleBackColor = false;
            btnStaffBack.Click += btnStaffBack_Click;
            // 
            // labelMStaff
            // 
            labelMStaff.BackColor = SystemColors.ControlLight;
            labelMStaff.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelMStaff.ForeColor = Color.Navy;
            labelMStaff.Location = new Point(491, 39);
            labelMStaff.Name = "labelMStaff";
            labelMStaff.Size = new Size(263, 47);
            labelMStaff.TabIndex = 7;
            labelMStaff.Text = "Manage Staff Records";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_staff_100__1_;
            pictureBox1.Location = new Point(437, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(58, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ManageStaffForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(968, 459);
            Controls.Add(pictureBox1);
            Controls.Add(labelMStaff);
            Controls.Add(btnStaffBack);
            Controls.Add(btnStaffDelete);
            Controls.Add(btnStaffUpdate);
            Controls.Add(dgvStaff);
            Name = "ManageStaffForm";
            Text = "ManageStaffForm";
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStaff;
        private Button btnStaffUpdate;
        private Button btnStaffDelete;
        private Button btnStaffBack;
        private Label labelMStaff;
        private PictureBox pictureBox1;
    }
}