namespace ChucNangThanhToan
{
    partial class FrmLichSuThanhToan
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
            this.dsLichSu = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldElect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newElect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oldWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dsLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // dsLichSu
            // 
            this.dsLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dsLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsLichSu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.TotalFine,
            this.oldElect,
            this.newElect,
            this.oldWater,
            this.newWater,
            this.Column2,
            this.Total,
            this.Column4,
            this.Column5});
            this.dsLichSu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dsLichSu.Location = new System.Drawing.Point(0, 0);
            this.dsLichSu.Name = "dsLichSu";
            this.dsLichSu.RowHeadersWidth = 82;
            this.dsLichSu.RowTemplate.Height = 33;
            this.dsLichSu.Size = new System.Drawing.Size(1470, 542);
            this.dsLichSu.TabIndex = 0;
            this.dsLichSu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dsLichSu_CellClick);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.BackColor = System.Drawing.Color.Tomato;
            this.btn_thoat.Location = new System.Drawing.Point(1280, 548);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(160, 55);
            this.btn_thoat.TabIndex = 1;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "IDRoom";
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // TotalFine
            // 
            this.TotalFine.DataPropertyName = "TotalFine";
            this.TotalFine.HeaderText = "Tổng tiền phạt";
            this.TotalFine.MinimumWidth = 10;
            this.TotalFine.Name = "TotalFine";
            // 
            // oldElect
            // 
            this.oldElect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oldElect.DataPropertyName = "oldElect";
            this.oldElect.HeaderText = "Số điện cũ";
            this.oldElect.MinimumWidth = 6;
            this.oldElect.Name = "oldElect";
            // 
            // newElect
            // 
            this.newElect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newElect.DataPropertyName = "newElect";
            this.newElect.HeaderText = "Số điện mới";
            this.newElect.MinimumWidth = 6;
            this.newElect.Name = "newElect";
            // 
            // oldWater
            // 
            this.oldWater.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.oldWater.DataPropertyName = "oldWater";
            this.oldWater.HeaderText = "Số nước cũ";
            this.oldWater.MinimumWidth = 6;
            this.oldWater.Name = "oldWater";
            // 
            // newWater
            // 
            this.newWater.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.newWater.DataPropertyName = "newWater";
            this.newWater.HeaderText = "Số nước mới";
            this.newWater.MinimumWidth = 6;
            this.newWater.Name = "newWater";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Month";
            this.Column2.HeaderText = "Tháng";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Tổng Tiền";
            this.Total.MinimumWidth = 10;
            this.Total.Name = "Total";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "State";
            this.Column4.HeaderText = "Trạng Thái";
            this.Column4.MinimumWidth = 10;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "Paydate";
            this.Column5.HeaderText = "Ngày Thanh Toán";
            this.Column5.MinimumWidth = 10;
            this.Column5.Name = "Column5";
            // 
            // FrmLichSuThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 616);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dsLichSu);
            this.Name = "FrmLichSuThanhToan";
            this.Text = "FrmLichSuThanhToan";
            this.Load += new System.EventHandler(this.FrmLichSuThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsLichSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dsLichSu;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldElect;
        private System.Windows.Forms.DataGridViewTextBoxColumn newElect;
        private System.Windows.Forms.DataGridViewTextBoxColumn oldWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn newWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}