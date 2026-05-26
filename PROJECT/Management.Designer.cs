namespace ROUTER2
{
    partial class Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btAdd = new System.Windows.Forms.Button();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRemain = new System.Windows.Forms.TextBox();
            this.lbRemain = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.tbIdRoom = new System.Windows.Forms.TextBox();
            this.lbIdRoom = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSelectedNameStudent = new System.Windows.Forms.TextBox();
            this.tbSelectedIDStudent = new System.Windows.Forms.TextBox();
            this.lbSelectedNameStudent = new System.Windows.Forms.Label();
            this.lbSelectedIDStudent = new System.Windows.Forms.Label();
            this.lbSelectedStudent = new System.Windows.Forms.Label();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btAdd.Location = new System.Drawing.Point(16, 33);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(83, 40);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Thêm";
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            this.btAdd.MouseLeave += new System.EventHandler(this.btAdd_MouseLeave);
            this.btAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btAdd_MouseMove);
            // 
            // tlpControl
            // 
            this.tlpControl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpControl.ColumnCount = 5;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.08546F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.62819F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.31742F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.31853F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.5394F));
            this.tlpControl.Controls.Add(this.panel1, 0, 0);
            this.tlpControl.Controls.Add(this.panel2, 2, 0);
            this.tlpControl.Controls.Add(this.panel3, 3, 0);
            this.tlpControl.Controls.Add(this.panel4, 4, 0);
            this.tlpControl.Controls.Add(this.panel5, 1, 0);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpControl.Location = new System.Drawing.Point(0, 0);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 1;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControl.Size = new System.Drawing.Size(901, 119);
            this.tlpControl.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbRemain);
            this.panel1.Controls.Add(this.lbRemain);
            this.panel1.Controls.Add(this.tbQuantity);
            this.panel1.Controls.Add(this.lbQuantity);
            this.panel1.Controls.Add(this.tbIdRoom);
            this.panel1.Controls.Add(this.lbIdRoom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 107);
            this.panel1.TabIndex = 0;
            // 
            // tbRemain
            // 
            this.tbRemain.Location = new System.Drawing.Point(85, 77);
            this.tbRemain.Name = "tbRemain";
            this.tbRemain.ReadOnly = true;
            this.tbRemain.Size = new System.Drawing.Size(94, 22);
            this.tbRemain.TabIndex = 5;
            // 
            // lbRemain
            // 
            this.lbRemain.AutoSize = true;
            this.lbRemain.Location = new System.Drawing.Point(9, 80);
            this.lbRemain.Name = "lbRemain";
            this.lbRemain.Size = new System.Drawing.Size(46, 16);
            this.lbRemain.TabIndex = 4;
            this.lbRemain.Text = "Trống:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(85, 42);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.ReadOnly = true;
            this.tbQuantity.Size = new System.Drawing.Size(94, 22);
            this.tbQuantity.TabIndex = 3;
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Location = new System.Drawing.Point(9, 45);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(63, 16);
            this.lbQuantity.TabIndex = 2;
            this.lbQuantity.Text = "Số lượng:";
            // 
            // tbIdRoom
            // 
            this.tbIdRoom.Location = new System.Drawing.Point(85, 9);
            this.tbIdRoom.Name = "tbIdRoom";
            this.tbIdRoom.ReadOnly = true;
            this.tbIdRoom.Size = new System.Drawing.Size(94, 22);
            this.tbIdRoom.TabIndex = 1;
            this.tbIdRoom.TextChanged += new System.EventHandler(this.tbIdRoom_TextChanged);
            // 
            // lbIdRoom
            // 
            this.lbIdRoom.AutoSize = true;
            this.lbIdRoom.Location = new System.Drawing.Point(9, 12);
            this.lbIdRoom.Name = "lbIdRoom";
            this.lbIdRoom.Size = new System.Drawing.Size(70, 16);
            this.lbIdRoom.TabIndex = 0;
            this.lbIdRoom.Text = "Mã phòng:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(522, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 107);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(651, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 107);
            this.panel3.TabIndex = 2;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.LightYellow;
            this.btnEdit.Location = new System.Drawing.Point(15, 33);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseLeave += new System.EventHandler(this.btnEdit_MouseLeave);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEdit_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(771, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 107);
            this.panel4.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Location = new System.Drawing.Point(17, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseLeave += new System.EventHandler(this.btnDelete_MouseLeave);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnDelete_MouseMove);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tbSelectedNameStudent);
            this.panel5.Controls.Add(this.tbSelectedIDStudent);
            this.panel5.Controls.Add(this.lbSelectedNameStudent);
            this.panel5.Controls.Add(this.lbSelectedIDStudent);
            this.panel5.Controls.Add(this.lbSelectedStudent);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(213, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 107);
            this.panel5.TabIndex = 4;
            // 
            // tbSelectedNameStudent
            // 
            this.tbSelectedNameStudent.Location = new System.Drawing.Point(131, 74);
            this.tbSelectedNameStudent.Name = "tbSelectedNameStudent";
            this.tbSelectedNameStudent.Size = new System.Drawing.Size(94, 22);
            this.tbSelectedNameStudent.TabIndex = 10;
            // 
            // tbSelectedIDStudent
            // 
            this.tbSelectedIDStudent.Location = new System.Drawing.Point(131, 39);
            this.tbSelectedIDStudent.Name = "tbSelectedIDStudent";
            this.tbSelectedIDStudent.Size = new System.Drawing.Size(94, 22);
            this.tbSelectedIDStudent.TabIndex = 7;
            // 
            // lbSelectedNameStudent
            // 
            this.lbSelectedNameStudent.AutoSize = true;
            this.lbSelectedNameStudent.Location = new System.Drawing.Point(55, 77);
            this.lbSelectedNameStudent.Name = "lbSelectedNameStudent";
            this.lbSelectedNameStudent.Size = new System.Drawing.Size(67, 16);
            this.lbSelectedNameStudent.TabIndex = 9;
            this.lbSelectedNameStudent.Text = "Họ và tên:";
            // 
            // lbSelectedIDStudent
            // 
            this.lbSelectedIDStudent.AutoSize = true;
            this.lbSelectedIDStudent.Location = new System.Drawing.Point(55, 42);
            this.lbSelectedIDStudent.Name = "lbSelectedIDStudent";
            this.lbSelectedIDStudent.Size = new System.Drawing.Size(50, 16);
            this.lbSelectedIDStudent.TabIndex = 6;
            this.lbSelectedIDStudent.Text = "Mã SV:";
            // 
            // lbSelectedStudent
            // 
            this.lbSelectedStudent.AutoSize = true;
            this.lbSelectedStudent.Location = new System.Drawing.Point(10, 12);
            this.lbSelectedStudent.Name = "lbSelectedStudent";
            this.lbSelectedStudent.Size = new System.Drawing.Size(130, 16);
            this.lbSelectedStudent.TabIndex = 8;
            this.lbSelectedStudent.Text = "Sinh viên đang chọn:";
            // 
            // dgvRoom
            // 
            this.dgvRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Gender,
            this.DateIn,
            this.Fine});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoom.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoom.Location = new System.Drawing.Point(0, 119);
            this.dgvRoom.Name = "dgvRoom";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(901, 370);
            this.dgvRoom.TabIndex = 2;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "Mã SV";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "Tên SV";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            // 
            // DateIn
            // 
            this.DateIn.DataPropertyName = "DateIn";
            this.DateIn.HeaderText = "Ngày vào ở";
            this.DateIn.MinimumWidth = 6;
            this.DateIn.Name = "DateIn";
            // 
            // Fine
            // 
            this.Fine.DataPropertyName = "Fine";
            this.Fine.HeaderText = "Tiền phạt";
            this.Fine.MinimumWidth = 6;
            this.Fine.Name = "Fine";
            // 
            // Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 489);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.tlpControl);
            this.Name = "Management";
            this.Text = "Quản lý phòng";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Management_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlpControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.TextBox tbIdRoom;
        private System.Windows.Forms.Label lbIdRoom;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbRemain;
        private System.Windows.Forms.Label lbRemain;
        private System.Windows.Forms.TextBox tbSelectedNameStudent;
        private System.Windows.Forms.Label lbSelectedNameStudent;
        private System.Windows.Forms.Label lbSelectedStudent;
        private System.Windows.Forms.TextBox tbSelectedIDStudent;
        private System.Windows.Forms.Label lbSelectedIDStudent;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fine;
    }
}

