namespace ChucNangThanhToan
{
    partial class FrmChiTietThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChiTietThanhToan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nuoccu = new System.Windows.Forms.Label();
            this.lb_diencu = new System.Windows.Forms.Label();
            this.btn_lichsu = new System.Windows.Forms.Button();
            this.txt_nuocmoi = new System.Windows.Forms.TextBox();
            this.txt_dienmoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dsSV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_tiendichvu = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.lb_tiennuoc = new System.Windows.Forms.Label();
            this.lb_tienphat = new System.Windows.Forms.Label();
            this.lb_tiendien = new System.Windows.Forms.Label();
            this.btn_TrangThai = new System.Windows.Forms.Button();
            this.btn_InHoaDon = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_nuoccu);
            this.panel1.Controls.Add(this.lb_diencu);
            this.panel1.Controls.Add(this.txt_nuocmoi);
            this.panel1.Controls.Add(this.txt_dienmoi);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_TrangThai);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1353, 119);
            this.panel1.TabIndex = 0;
            // 
            // lb_nuoccu
            // 
            this.lb_nuoccu.AutoSize = true;
            this.lb_nuoccu.Location = new System.Drawing.Point(552, 69);
            this.lb_nuoccu.Name = "lb_nuoccu";
            this.lb_nuoccu.Size = new System.Drawing.Size(32, 17);
            this.lb_nuoccu.TabIndex = 3;
            this.lb_nuoccu.Text = "206";
            // 
            // lb_diencu
            // 
            this.lb_diencu.AutoSize = true;
            this.lb_diencu.Location = new System.Drawing.Point(169, 70);
            this.lb_diencu.Name = "lb_diencu";
            this.lb_diencu.Size = new System.Drawing.Size(32, 17);
            this.lb_diencu.TabIndex = 9;
            this.lb_diencu.Text = "345";
            // 
            // btn_lichsu
            // 
            this.btn_lichsu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_lichsu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_lichsu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_lichsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lichsu.Location = new System.Drawing.Point(919, 106);
            this.btn_lichsu.Name = "btn_lichsu";
            this.btn_lichsu.Size = new System.Drawing.Size(376, 44);
            this.btn_lichsu.TabIndex = 8;
            this.btn_lichsu.Text = "Lịch sử thanh toán";
            this.btn_lichsu.UseVisualStyleBackColor = false;
            this.btn_lichsu.Click += new System.EventHandler(this.btn_lichsu_Click);
            // 
            // txt_nuocmoi
            // 
            this.txt_nuocmoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nuocmoi.Location = new System.Drawing.Point(552, 12);
            this.txt_nuocmoi.Name = "txt_nuocmoi";
            this.txt_nuocmoi.Size = new System.Drawing.Size(231, 22);
            this.txt_nuocmoi.TabIndex = 6;
            this.txt_nuocmoi.Leave += new System.EventHandler(this.txt_nuocmoi_Leave);
            // 
            // txt_dienmoi
            // 
            this.txt_dienmoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dienmoi.Location = new System.Drawing.Point(169, 15);
            this.txt_dienmoi.Name = "txt_dienmoi";
            this.txt_dienmoi.Size = new System.Drawing.Size(205, 22);
            this.txt_dienmoi.TabIndex = 4;
            this.txt_dienmoi.Leave += new System.EventHandler(this.txt_dienmoi_Leave_1);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nước cũ:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số nước mới:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số điện cũ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số điện mới:";
            // 
            // dsSV
            // 
            this.dsSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Money,
            this.col_phat});
            this.dsSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dsSV.Location = new System.Drawing.Point(0, 119);
            this.dsSV.Name = "dsSV";
            this.dsSV.RowHeadersWidth = 82;
            this.dsSV.RowTemplate.Height = 33;
            this.dsSV.Size = new System.Drawing.Size(1353, 661);
            this.dsSV.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "ID";
            this.Column1.FillWeight = 99.91701F;
            this.Column1.HeaderText = "Mã SV";
            this.Column1.MinimumWidth = 10;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "FullName";
            this.Column2.FillWeight = 100.2487F;
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 10;
            this.Column2.Name = "Column2";
            // 
            // Money
            // 
            this.Money.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Money.DataPropertyName = "Room";
            this.Money.FillWeight = 99.91641F;
            this.Money.HeaderText = "Tiền Phòng/Người";
            this.Money.MinimumWidth = 10;
            this.Money.Name = "Money";
            // 
            // col_phat
            // 
            this.col_phat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_phat.DataPropertyName = "Fine";
            this.col_phat.FillWeight = 99.91779F;
            this.col_phat.HeaderText = "Tiền Phạt";
            this.col_phat.MinimumWidth = 10;
            this.col_phat.Name = "col_phat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lb_tiendichvu);
            this.panel2.Controls.Add(this.btn_lichsu);
            this.panel2.Controls.Add(this.lb_tongtien);
            this.panel2.Controls.Add(this.lb_tiennuoc);
            this.panel2.Controls.Add(this.lb_tienphat);
            this.panel2.Controls.Add(this.lb_tiendien);
            this.panel2.Controls.Add(this.btn_InHoaDon);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1353, 201);
            this.panel2.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Đơn vị: VNĐ";
            // 
            // lb_tiendichvu
            // 
            this.lb_tiendichvu.AutoSize = true;
            this.lb_tiendichvu.Location = new System.Drawing.Point(644, 76);
            this.lb_tiendichvu.Name = "lb_tiendichvu";
            this.lb_tiendichvu.Size = new System.Drawing.Size(48, 17);
            this.lb_tiendichvu.TabIndex = 16;
            this.lb_tiendichvu.Text = "50000";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Location = new System.Drawing.Point(202, 133);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(16, 17);
            this.lb_tongtien.TabIndex = 15;
            this.lb_tongtien.Text = "0";
            // 
            // lb_tiennuoc
            // 
            this.lb_tiennuoc.AutoSize = true;
            this.lb_tiennuoc.Location = new System.Drawing.Point(202, 76);
            this.lb_tiennuoc.Name = "lb_tiennuoc";
            this.lb_tiennuoc.Size = new System.Drawing.Size(16, 17);
            this.lb_tiennuoc.TabIndex = 14;
            this.lb_tiennuoc.Text = "0";
            // 
            // lb_tienphat
            // 
            this.lb_tienphat.AutoSize = true;
            this.lb_tienphat.Location = new System.Drawing.Point(640, 25);
            this.lb_tienphat.Name = "lb_tienphat";
            this.lb_tienphat.Size = new System.Drawing.Size(16, 17);
            this.lb_tienphat.TabIndex = 13;
            this.lb_tienphat.Text = "0";
            // 
            // lb_tiendien
            // 
            this.lb_tiendien.AutoSize = true;
            this.lb_tiendien.Location = new System.Drawing.Point(202, 26);
            this.lb_tiendien.Name = "lb_tiendien";
            this.lb_tiendien.Size = new System.Drawing.Size(16, 17);
            this.lb_tiendien.TabIndex = 12;
            this.lb_tiendien.Text = "0";
            // 
            // btn_TrangThai
            // 
            this.btn_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TrangThai.BackColor = System.Drawing.Color.Tomato;
            this.btn_TrangThai.Location = new System.Drawing.Point(889, 35);
            this.btn_TrangThai.Name = "btn_TrangThai";
            this.btn_TrangThai.Size = new System.Drawing.Size(376, 51);
            this.btn_TrangThai.TabIndex = 3;
            this.btn_TrangThai.Text = "Chưa thanh toán";
            this.btn_TrangThai.UseVisualStyleBackColor = false;
            this.btn_TrangThai.Click += new System.EventHandler(this.btn_TrangThai_Click);
            // 
            // btn_InHoaDon
            // 
            this.btn_InHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InHoaDon.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_InHoaDon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_InHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InHoaDon.Location = new System.Drawing.Point(919, 26);
            this.btn_InHoaDon.Name = "btn_InHoaDon";
            this.btn_InHoaDon.Size = new System.Drawing.Size(376, 48);
            this.btn_InHoaDon.TabIndex = 11;
            this.btn_InHoaDon.Text = "In hóa đơn";
            this.btn_InHoaDon.UseVisualStyleBackColor = false;
            this.btn_InHoaDon.Click += new System.EventHandler(this.btn_InHoaDon_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "TỔNG TIỀN: ";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Tiền dịch vụ:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tổng tiền phạt:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng tiền nước:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền điện:";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmChiTietThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1353, 780);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dsSV);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmChiTietThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Thanh toán";
            this.Load += new System.EventHandler(this.FrmChiTietThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nuocmoi;
        private System.Windows.Forms.TextBox txt_dienmoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lichsu;
        private System.Windows.Forms.DataGridView dsSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_InHoaDon;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_TrangThai;
        private System.Windows.Forms.Label lb_diencu;
        private System.Windows.Forms.Label lb_nuoccu;
        private System.Windows.Forms.Label lb_tienphat;
        private System.Windows.Forms.Label lb_tiendien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_tiendichvu;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.Label lb_tiennuoc;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Money;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phat;
    }
}

