namespace ROUTER2
{
    partial class EditForm
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
            this.components = new System.ComponentModel.Container();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbGender = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.tbNameStudent = new System.Windows.Forms.TextBox();
            this.lbNameStudent = new System.Windows.Forms.Label();
            this.tbIdStudent = new System.Windows.Forms.TextBox();
            this.lbIDStudent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbReason = new System.Windows.Forms.TextBox();
            this.lbReason = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbFine = new System.Windows.Forms.TextBox();
            this.lbMoney = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpFine = new System.Windows.Forms.DateTimePicker();
            this.lbDateFine = new System.Windows.Forms.Label();
            this.dgvFines = new System.Windows.Forms.DataGridView();
            this.IDFines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).BeginInit();
            this.SuspendLayout();
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Enabled = false;
            this.rbFemale.Location = new System.Drawing.Point(181, 16);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(45, 20);
            this.rbFemale.TabIndex = 4;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Nữ";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpCheckIn.Enabled = false;
            this.dtpCheckIn.Location = new System.Drawing.Point(108, 17);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(842, 22);
            this.dtpCheckIn.TabIndex = 4;
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Location = new System.Drawing.Point(10, 17);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(80, 16);
            this.lbCheckIn.TabIndex = 3;
            this.lbCheckIn.Text = "Ngày vào ở:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dtpCheckIn);
            this.panel5.Controls.Add(this.lbCheckIn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(6, 171);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1081, 49);
            this.panel5.TabIndex = 3;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(10, 18);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(63, 16);
            this.lbGender.TabIndex = 3;
            this.lbGender.Text = "Giới Tính:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbFemale);
            this.panel4.Controls.Add(this.lbGender);
            this.panel4.Controls.Add(this.rbMale);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1081, 46);
            this.panel4.TabIndex = 2;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Enabled = false;
            this.rbMale.Location = new System.Drawing.Point(108, 16);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(57, 20);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Nam";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // tbNameStudent
            // 
            this.tbNameStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameStudent.Location = new System.Drawing.Point(108, 16);
            this.tbNameStudent.Name = "tbNameStudent";
            this.tbNameStudent.ReadOnly = true;
            this.tbNameStudent.Size = new System.Drawing.Size(842, 22);
            this.tbNameStudent.TabIndex = 4;
            // 
            // lbNameStudent
            // 
            this.lbNameStudent.AutoSize = true;
            this.lbNameStudent.Location = new System.Drawing.Point(10, 16);
            this.lbNameStudent.Name = "lbNameStudent";
            this.lbNameStudent.Size = new System.Drawing.Size(67, 16);
            this.lbNameStudent.TabIndex = 3;
            this.lbNameStudent.Text = "Họ và tên:";
            // 
            // tbIdStudent
            // 
            this.tbIdStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbIdStudent.Location = new System.Drawing.Point(108, 16);
            this.tbIdStudent.Name = "tbIdStudent";
            this.tbIdStudent.ReadOnly = true;
            this.tbIdStudent.Size = new System.Drawing.Size(842, 22);
            this.tbIdStudent.TabIndex = 4;
            // 
            // lbIDStudent
            // 
            this.lbIDStudent.AutoSize = true;
            this.lbIDStudent.Location = new System.Drawing.Point(10, 16);
            this.lbIDStudent.Name = "lbIDStudent";
            this.lbIDStudent.Size = new System.Drawing.Size(84, 16);
            this.lbIDStudent.TabIndex = 3;
            this.lbIDStudent.Text = "Mã sinh viên:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbIdStudent);
            this.panel2.Controls.Add(this.lbIDStudent);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1081, 46);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1093, 226);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbNameStudent);
            this.panel3.Controls.Add(this.lbNameStudent);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1081, 46);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel9, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 226);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1093, 119);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnDelete);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(550, 63);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(538, 51);
            this.panel9.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDelete.Location = new System.Drawing.Point(133, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 33);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAdd.Location = new System.Drawing.Point(31, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 33);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbReason);
            this.panel8.Controls.Add(this.lbReason);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(5, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(537, 51);
            this.panel8.TabIndex = 2;
            // 
            // tbReason
            // 
            this.tbReason.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbReason.Location = new System.Drawing.Point(118, 6);
            this.tbReason.Multiline = true;
            this.tbReason.Name = "tbReason";
            this.tbReason.Size = new System.Drawing.Size(339, 45);
            this.tbReason.TabIndex = 10;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(38, 20);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(72, 16);
            this.lbReason.TabIndex = 9;
            this.lbReason.Text = "Lý do phạt:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbFine);
            this.panel7.Controls.Add(this.lbMoney);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(550, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(538, 50);
            this.panel7.TabIndex = 1;
            // 
            // tbFine
            // 
            this.tbFine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFine.Location = new System.Drawing.Point(114, 16);
            this.tbFine.Name = "tbFine";
            this.tbFine.Size = new System.Drawing.Size(136, 22);
            this.tbFine.TabIndex = 10;
            this.toolTip1.SetToolTip(this.tbFine, "Chỉ nhập số nguyên");
            this.tbFine.Leave += new System.EventHandler(this.tbFine_Leave);
            // 
            // lbMoney
            // 
            this.lbMoney.AutoSize = true;
            this.lbMoney.Location = new System.Drawing.Point(28, 19);
            this.lbMoney.Name = "lbMoney";
            this.lbMoney.Size = new System.Drawing.Size(80, 16);
            this.lbMoney.TabIndex = 9;
            this.lbMoney.Text = "Số tiền phạt:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpFine);
            this.panel6.Controls.Add(this.lbDateFine);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(537, 50);
            this.panel6.TabIndex = 0;
            // 
            // dtpFine
            // 
            this.dtpFine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFine.Location = new System.Drawing.Point(118, 17);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.Size = new System.Drawing.Size(197, 22);
            this.dtpFine.TabIndex = 9;
            // 
            // lbDateFine
            // 
            this.lbDateFine.AutoSize = true;
            this.lbDateFine.Location = new System.Drawing.Point(38, 19);
            this.lbDateFine.Name = "lbDateFine";
            this.lbDateFine.Size = new System.Drawing.Size(72, 16);
            this.lbDateFine.TabIndex = 8;
            this.lbDateFine.Text = "Ngày phạt:";
            // 
            // dgvFines
            // 
            this.dgvFines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDFines,
            this.Date,
            this.Reason,
            this.Money});
            this.dgvFines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFines.Location = new System.Drawing.Point(0, 345);
            this.dgvFines.Name = "dgvFines";
            this.dgvFines.RowHeadersWidth = 51;
            this.dgvFines.RowTemplate.Height = 24;
            this.dgvFines.Size = new System.Drawing.Size(1093, 379);
            this.dgvFines.TabIndex = 7;
            // 
            // IDFines
            // 
            this.IDFines.DataPropertyName = "IDFines";
            this.IDFines.HeaderText = "STT";
            this.IDFines.MinimumWidth = 6;
            this.IDFines.Name = "IDFines";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Ngày phạt";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            // 
            // Reason
            // 
            this.Reason.DataPropertyName = "Reason";
            this.Reason.HeaderText = "Lý do phạt";
            this.Reason.MinimumWidth = 6;
            this.Reason.Name = "Reason";
            // 
            // Money
            // 
            this.Money.DataPropertyName = "Money";
            this.Money.HeaderText = "Tiền phạt";
            this.Money.MinimumWidth = 6;
            this.Money.Name = "Money";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 724);
            this.Controls.Add(this.dgvFines);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditForm";
            this.Text = "Sửa sinh viên";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EditForm_FormClosed);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Label lbCheckIn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox tbNameStudent;
        private System.Windows.Forms.Label lbNameStudent;
        private System.Windows.Forms.TextBox tbIdStudent;
        private System.Windows.Forms.Label lbIDStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbMoney;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbDateFine;
        private System.Windows.Forms.DataGridView dgvFines;
        private System.Windows.Forms.TextBox tbReason;
        private System.Windows.Forms.TextBox tbFine;
        private System.Windows.Forms.DateTimePicker dtpFine;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFines;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}