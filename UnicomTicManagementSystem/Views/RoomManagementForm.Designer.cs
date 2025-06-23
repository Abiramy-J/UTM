namespace UnicomTicManagementSystem.Views
{
    partial class RoomManagementForm
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
            dgvRooms = new DataGridView();
            cmbRoomType = new ComboBox();
            lbRoomName = new Label();
            lbRoomType = new Label();
            txtRoomName = new TextBox();
            btnRBack = new Button();
            btnRDelete = new Button();
            btnRUpdate = new Button();
            btnRAdd = new Button();
            labelMLect = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(25, 149);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(466, 317);
            dgvRooms.TabIndex = 0;
            dgvRooms.CellClick += dgvRooms_CellClick;
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(621, 209);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(201, 23);
            cmbRoomType.TabIndex = 4;
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRoomName.Location = new Point(517, 158);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new Size(98, 20);
            lbRoomName.TabIndex = 5;
            lbRoomName.Text = "Room Name:";
            // 
            // lbRoomType
            // 
            lbRoomType.AutoSize = true;
            lbRoomType.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRoomType.Location = new Point(522, 208);
            lbRoomType.Name = "lbRoomType";
            lbRoomType.Size = new Size(93, 20);
            lbRoomType.TabIndex = 6;
            lbRoomType.Text = "Room Type :";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(621, 159);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(201, 23);
            txtRoomName.TabIndex = 8;
            // 
            // btnRBack
            // 
            btnRBack.BackColor = SystemColors.ActiveCaption;
            btnRBack.Cursor = Cursors.Hand;
            btnRBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRBack.Location = new Point(580, 452);
            btnRBack.Name = "btnRBack";
            btnRBack.Size = new Size(148, 33);
            btnRBack.TabIndex = 11;
            btnRBack.Text = "BACK";
            btnRBack.UseVisualStyleBackColor = false;
            btnRBack.Click += btnRBack_Click;
            // 
            // btnRDelete
            // 
            btnRDelete.BackColor = SystemColors.ActiveCaption;
            btnRDelete.Cursor = Cursors.Hand;
            btnRDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRDelete.Location = new Point(580, 396);
            btnRDelete.Name = "btnRDelete";
            btnRDelete.Size = new Size(148, 33);
            btnRDelete.TabIndex = 12;
            btnRDelete.Text = "DELETE";
            btnRDelete.UseVisualStyleBackColor = false;
            btnRDelete.Click += btnRDelete_Click;
            // 
            // btnRUpdate
            // 
            btnRUpdate.BackColor = SystemColors.ActiveCaption;
            btnRUpdate.Cursor = Cursors.Hand;
            btnRUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRUpdate.Location = new Point(580, 342);
            btnRUpdate.Name = "btnRUpdate";
            btnRUpdate.Size = new Size(148, 33);
            btnRUpdate.TabIndex = 13;
            btnRUpdate.Text = "UPDATE";
            btnRUpdate.UseVisualStyleBackColor = false;
            btnRUpdate.Click += btnRUpdate_Click;
            // 
            // btnRAdd
            // 
            btnRAdd.BackColor = SystemColors.ActiveCaption;
            btnRAdd.Cursor = Cursors.Hand;
            btnRAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRAdd.Location = new Point(580, 282);
            btnRAdd.Name = "btnRAdd";
            btnRAdd.Size = new Size(148, 33);
            btnRAdd.TabIndex = 14;
            btnRAdd.Text = "ADD";
            btnRAdd.UseVisualStyleBackColor = false;
            btnRAdd.Click += btnRAdd_Click;
            // 
            // labelMLect
            // 
            labelMLect.BackColor = SystemColors.ControlLight;
            labelMLect.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelMLect.ForeColor = Color.Navy;
            labelMLect.Location = new Point(309, 54);
            labelMLect.Name = "labelMLect";
            labelMLect.Size = new Size(271, 47);
            labelMLect.TabIndex = 15;
            labelMLect.Text = "Room Control Panel";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_timetable_64;
            pictureBox1.Location = new Point(267, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // RoomManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(945, 536);
            Controls.Add(pictureBox1);
            Controls.Add(labelMLect);
            Controls.Add(btnRAdd);
            Controls.Add(btnRUpdate);
            Controls.Add(btnRDelete);
            Controls.Add(btnRBack);
            Controls.Add(txtRoomName);
            Controls.Add(lbRoomType);
            Controls.Add(lbRoomName);
            Controls.Add(cmbRoomType);
            Controls.Add(dgvRooms);
            Name = "RoomManagementForm";
            Text = "RoomManagementForm";
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRooms;
        private ComboBox cmbRoomType;
        private Label lbRoomName;
        private Label lbRoomType;
        private TextBox txtRoomName;
        private Button btnRBack;
        private Button btnRDelete;
        private Button btnRUpdate;
        private Button btnRAdd;
        private Label labelMLect;
        private PictureBox pictureBox1;
    }
}