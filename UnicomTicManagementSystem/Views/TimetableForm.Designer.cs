namespace UnicomTicManagementSystem.Views
{
    partial class TimetableForm
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
            IbDate = new Label();
            btnTAdd = new Button();
            lbRoomName = new Label();
            IbSubject = new Label();
            lbTimeSlot = new Label();
            cmbRoomName = new ComboBox();
            cmbSubject = new ComboBox();
            cmbTimeSlot = new ComboBox();
            dtpTTDate = new DateTimePicker();
            btnTBack = new Button();
            btnTDelete = new Button();
            btnTUpdate = new Button();
            dgvTimetable = new DataGridView();
            labelMLect = new Label();
            pictureBox1 = new PictureBox();
            lblNoRoomWarning = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // IbDate
            // 
            IbDate.AutoSize = true;
            IbDate.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbDate.Location = new Point(41, 431);
            IbDate.Name = "IbDate";
            IbDate.Size = new Size(49, 20);
            IbDate.TabIndex = 6;
            IbDate.Text = "Date :";
            // 
            // btnTAdd
            // 
            btnTAdd.BackColor = SystemColors.ActiveCaption;
            btnTAdd.Cursor = Cursors.Hand;
            btnTAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTAdd.Location = new Point(751, 192);
            btnTAdd.Name = "btnTAdd";
            btnTAdd.Size = new Size(140, 31);
            btnTAdd.TabIndex = 15;
            btnTAdd.Text = "ADD";
            btnTAdd.UseVisualStyleBackColor = false;
            btnTAdd.Click += btnTAdd_Click;
            // 
            // lbRoomName
            // 
            lbRoomName.AutoSize = true;
            lbRoomName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbRoomName.Location = new Point(395, 428);
            lbRoomName.Name = "lbRoomName";
            lbRoomName.Size = new Size(98, 20);
            lbRoomName.TabIndex = 16;
            lbRoomName.Text = "Room Name:";
            // 
            // IbSubject
            // 
            IbSubject.AutoSize = true;
            IbSubject.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IbSubject.Location = new Point(41, 468);
            IbSubject.Name = "IbSubject";
            IbSubject.Size = new Size(67, 20);
            IbSubject.TabIndex = 17;
            IbSubject.Text = "Subject :";
            // 
            // lbTimeSlot
            // 
            lbTimeSlot.AutoSize = true;
            lbTimeSlot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTimeSlot.Location = new Point(395, 471);
            lbTimeSlot.Name = "lbTimeSlot";
            lbTimeSlot.Size = new Size(80, 20);
            lbTimeSlot.TabIndex = 18;
            lbTimeSlot.Text = "Time Slot :";
            // 
            // cmbRoomName
            // 
            cmbRoomName.FormattingEnabled = true;
            cmbRoomName.Location = new Point(517, 425);
            cmbRoomName.Name = "cmbRoomName";
            cmbRoomName.Size = new Size(169, 23);
            cmbRoomName.TabIndex = 19;
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(124, 468);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(200, 23);
            cmbSubject.TabIndex = 20;
            // 
            // cmbTimeSlot
            // 
            cmbTimeSlot.FormattingEnabled = true;
            cmbTimeSlot.Location = new Point(517, 472);
            cmbTimeSlot.Name = "cmbTimeSlot";
            cmbTimeSlot.Size = new Size(169, 23);
            cmbTimeSlot.TabIndex = 21;
            // 
            // dtpTTDate
            // 
            dtpTTDate.CustomFormat = "MMM dd yyyy dddd";
            dtpTTDate.Format = DateTimePickerFormat.Custom;
            dtpTTDate.Location = new Point(124, 428);
            dtpTTDate.Name = "dtpTTDate";
            dtpTTDate.Size = new Size(200, 23);
            dtpTTDate.TabIndex = 22;
            // 
            // btnTBack
            // 
            btnTBack.BackColor = SystemColors.ActiveCaption;
            btnTBack.Cursor = Cursors.Hand;
            btnTBack.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTBack.Location = new Point(751, 381);
            btnTBack.Name = "btnTBack";
            btnTBack.Size = new Size(140, 33);
            btnTBack.TabIndex = 23;
            btnTBack.Text = "BACK";
            btnTBack.UseVisualStyleBackColor = false;
            btnTBack.Click += btnTBack_Click;
            // 
            // btnTDelete
            // 
            btnTDelete.BackColor = SystemColors.ActiveCaption;
            btnTDelete.Cursor = Cursors.Hand;
            btnTDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTDelete.Location = new Point(751, 320);
            btnTDelete.Name = "btnTDelete";
            btnTDelete.Size = new Size(140, 33);
            btnTDelete.TabIndex = 24;
            btnTDelete.Text = "DELETE";
            btnTDelete.UseVisualStyleBackColor = false;
            btnTDelete.Click += btnTDelete_Click;
            // 
            // btnTUpdate
            // 
            btnTUpdate.BackColor = SystemColors.ActiveCaption;
            btnTUpdate.Cursor = Cursors.Hand;
            btnTUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTUpdate.Location = new Point(751, 256);
            btnTUpdate.Name = "btnTUpdate";
            btnTUpdate.Size = new Size(140, 34);
            btnTUpdate.TabIndex = 25;
            btnTUpdate.Text = "UPDATE";
            btnTUpdate.UseVisualStyleBackColor = false;
            btnTUpdate.Click += btnTUpdate_Click;
            // 
            // dgvTimetable
            // 
            dgvTimetable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTimetable.Location = new Point(28, 108);
            dgvTimetable.Name = "dgvTimetable";
            dgvTimetable.Size = new Size(658, 290);
            dgvTimetable.TabIndex = 26;
            dgvTimetable.CellClick += dgvTimetable_CellClick;
            // 
            // labelMLect
            // 
            labelMLect.BackColor = SystemColors.ControlLight;
            labelMLect.Font = new Font("Segoe UI Historic", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            labelMLect.ForeColor = Color.Navy;
            labelMLect.Location = new Point(356, 38);
            labelMLect.Name = "labelMLect";
            labelMLect.Size = new Size(271, 47);
            labelMLect.TabIndex = 27;
            labelMLect.Text = "Timetable Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_timetable_96;
            pictureBox1.Location = new Point(304, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // lblNoRoomWarning
            // 
            lblNoRoomWarning.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNoRoomWarning.ForeColor = Color.Red;
            lblNoRoomWarning.Location = new Point(443, 451);
            lblNoRoomWarning.Name = "lblNoRoomWarning";
            lblNoRoomWarning.Size = new Size(348, 15);
            lblNoRoomWarning.TabIndex = 33;
            lblNoRoomWarning.Visible = false;
            // 
            // TimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(945, 536);
            Controls.Add(lblNoRoomWarning);
            Controls.Add(pictureBox1);
            Controls.Add(labelMLect);
            Controls.Add(dgvTimetable);
            Controls.Add(btnTUpdate);
            Controls.Add(btnTDelete);
            Controls.Add(btnTBack);
            Controls.Add(dtpTTDate);
            Controls.Add(cmbTimeSlot);
            Controls.Add(cmbSubject);
            Controls.Add(cmbRoomName);
            Controls.Add(lbTimeSlot);
            Controls.Add(IbSubject);
            Controls.Add(lbRoomName);
            Controls.Add(btnTAdd);
            Controls.Add(IbDate);
            Name = "TimetableForm";
            Text = "TimetableForm";
            ((System.ComponentModel.ISupportInitialize)dgvTimetable).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IbDate;
        private Button btnTAdd;
        private Label lbRoomName;
        private Label IbSubject;
        private Label lbTimeSlot;
        private ComboBox cmbRoomName;
        private ComboBox cmbSubject;
        private ComboBox cmbTimeSlot;
        private DateTimePicker dtpTTDate;
        private Button btnTBack;
        private Button btnTDelete;
        private Button btnTUpdate;
        private DataGridView dgvTimetable;
        private Label labelMLect;
        private PictureBox pictureBox1;
        private Label lblNoRoomWarning;
    }
}