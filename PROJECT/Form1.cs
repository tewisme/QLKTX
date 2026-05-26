using ChucNangThanhToan;
using ROUTER2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QLKTX
{
    public partial class ThongKe : Form
    {
        string currentRoom = "", currentGender = "";
        public ThongKe()
        {
            InitializeComponent();
        }
        Label lbselect=null;
        int bang = 0;
        string connect = "Data Source=.;Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True;";
        SqlConnection conn = null;
        private void ConnectDB()
        {
            try
            {
                conn = new SqlConnection(connect);
                MessageBox.Show("Kết nối thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            bang = 1;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.DataSource = null;
            dgvThongKe.Columns.Clear();
            dgvThongKe.Columns.Add("ID", "Mã phòng");
            dgvThongKe.Columns["ID"].DataPropertyName = "ID";
            dgvThongKe.Columns.Add("RoomNotEmpty", "Phòng có sinh viên ở");
            dgvThongKe.Columns["RoomNotEmpty"].DataPropertyName = "RoomNotEmpty";
            dgvThongKe.Columns.Add("RoomEmpty", "Phòng còn trống");
            dgvThongKe.Columns["RoomEmpty"].DataPropertyName = "RoomEmpty";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlSelect = @"
        SELECT 
            r.ID,
            CASE 
                WHEN COUNT(s.ID) = 0 THEN N'Còn trống'
                ELSE N'Không trống'
            END AS RoomEmpty,
            CAST(COUNT(s.ID) AS nvarchar) + '/' + CAST(r.MaxQuantity AS nvarchar) AS RoomNotEmpty
        FROM Rooms r
        LEFT JOIN Students s ON r.ID = s.IDRoom
        GROUP BY r.ID, r.MaxQuantity";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvThongKe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            bang = 2;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.DataSource = null;
            dgvThongKe.Columns.Clear();
            dgvThongKe.Columns.Add("ID", "Mã phòng");
            dgvThongKe.Columns["ID"].DataPropertyName = "ID";
            dgvThongKe.Columns.Add("Type", "Loại phòng ở");
            dgvThongKe.Columns["Type"].DataPropertyName = "Type";
            dgvThongKe.Columns.Add("Quantity", "Số lượng sinh viên");
            dgvThongKe.Columns["Quantity"].DataPropertyName = "Quantity";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlSelect = @"
        SELECT 
            r.ID,
            r.Type,
            COUNT(s.ID) AS Quantity
        FROM Rooms r
        LEFT JOIN Students s ON r.ID = s.IDRoom
        GROUP BY r.ID, r.Type";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvThongKe.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {
            bang = 3;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.DataSource = null;
            dgvThongKe.Columns.Clear();
            dgvThongKe.Columns.Add("ID", "Mã phòng");
            dgvThongKe.Columns["ID"].DataPropertyName = "ID";
            dgvThongKe.Columns.Add("Type", "Loại phòng ở");
            dgvThongKe.Columns["Type"].DataPropertyName = "Type";
            dgvThongKe.Columns.Add("TienPhong", "Số tiền phòng");
            dgvThongKe.Columns["TienPhong"].DataPropertyName = "TienPhong";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlSelect = @"
        SELECT 
            r.ID,
            r.Type,
            CASE 
                WHEN COUNT(s.ID) = 0 THEN 0
                ELSE 
                    COUNT(s.ID) * f.Room 
                    + r.ElecNumber * f.Elect 
                    + r.WaterNumber * f.Water 
                    + f.Service
            END AS TienPhong
        FROM Rooms r
        INNER JOIN Fees f ON r.MaxQuantity = f.Type
        LEFT JOIN Students s ON r.ID = s.IDRoom
        GROUP BY r.ID, r.Type, r.ElecNumber, r.WaterNumber, f.Room, f.Elect, f.Water, f.Service
        ORDER BY TienPhong DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvThongKe.DataSource = dt;

                HighlightTop10();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            bang = 4;
            dgvThongKe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvThongKe.DataSource = null;
            dgvThongKe.Columns.Clear();
            dgvThongKe.Columns.Add("ID", "Mã phòng");
            dgvThongKe.Columns["ID"].DataPropertyName = "ID";
            dgvThongKe.Columns.Add("Type", "Loại phòng ở");
            dgvThongKe.Columns["Type"].DataPropertyName = "Type";
            dgvThongKe.Columns.Add("Fine", "Số tiền phạt");
            dgvThongKe.Columns["Fine"].DataPropertyName = "Fine";
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                string sqlSelect = @"
        SELECT 
            r.ID, 
            r.Type, 
            ISNULL(SUM(f.Money), 0) AS Fine
        FROM Rooms r
        INNER JOIN Students s ON r.ID = s.IDRoom
        INNER JOIN Fines f ON s.ID = f.IDStudents
        GROUP BY r.ID, r.Type
        ORDER BY Fine DESC";

                SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvThongKe.DataSource = dt;

                HighlightTop10();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void HighlightTop10()
        {
            for (int i = 0; i < dgvThongKe.Rows.Count; i++)
            {
                dgvThongKe.Rows[i].DefaultCellStyle.BackColor = Color.White;
                dgvThongKe.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                if (i < 10)
                {
                    dgvThongKe.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dgvThongKe.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void LoadTongThongKe()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // LOGIC CHUẨN ĐÉT:
                // 1. Kết nối bảng Rooms với bảng Fees bằng điều kiện: r.MaxQuantity = f.Type
                // 2. Tính số lượng SV thực tế bằng cách COUNT từ bảng Students nhóm theo phòng
                string sqlThongKe = @"
        SELECT 
            (SELECT COUNT(*) FROM Rooms) AS TongPhong,
            (SELECT COUNT(*) FROM Students) AS TongSV,
            (
                SELECT ISNULL(SUM(ISNULL(sv.SoLuongSV, 0) * f.Room + r.ElecNumber * f.Elect + r.WaterNumber * f.Water + f.Service), 0)
                FROM Rooms r
                INNER JOIN Fees f ON r.MaxQuantity = f.Type -- Map chuẩn: Số người tối đa của phòng khớp với Loại cấu hình giá
                LEFT JOIN (
                    SELECT IDRoom, COUNT(*) AS SoLuongSV 
                    FROM Students 
                    GROUP BY IDRoom
                ) sv ON r.ID = sv.IDRoom
            ) AS TongTienPhong,
            (SELECT ISNULL(SUM(Money), 0) FROM Fines) AS TongTienPhat";

                using (SqlCommand cmd = new SqlCommand(sqlThongKe, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lbID.Text = reader["TongPhong"].ToString();

                            lbStudent.Text = reader["TongSV"].ToString();
                            long tongTienPhong = Convert.ToInt64(reader["TongTienPhong"]);
                            lbTienPhong.Text = tongTienPhong.ToString("N0");

                            long tongTienPhat = Convert.ToInt64(reader["TongTienPhat"]);
                            lbTienPhat.Text = tongTienPhat.ToString("N0");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadChartNamNu()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                chartSinhVien.Series.Clear();

                Series sv = new Series("SinhVien");
                sv.ChartType = SeriesChartType.Column;
                sv.IsValueShownAsLabel = true;

                string sql = @"
        SELECT Gender, COUNT(*) AS SoLuong
        FROM Students
        GROUP BY Gender";

                SqlDataAdapter adapter =new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    sv.Points.AddXY(
                        dt.Rows[i]["Gender"].ToString(),
                        dt.Rows[i]["SoLuong"].ToString()
                    );
                }
                chartSinhVien.Series.Add(sv);
                if (sv.Points.Count > 0)
                    sv.Points[0].Color = Color.DodgerBlue;
                if (sv.Points.Count > 1)
                    sv.Points[1].Color = Color.HotPink;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            ConnectDB();
            LoadTongThongKe();
            LoadChartNamNu();
            LoadDB();
            dataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            LoadTongThongKe();
            LoadChartNamNu();
            if (bang == 1)
                label2_Click(sender, e);
            else if (bang == 2)
                label3_Click(sender, e);
            else if (bang == 3)
                label4_Click(sender, e);
            else if (bang == 4)
                label5_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            lb.BackColor = Color.DarkGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Label lb = sender as Label;
            lb.BackColor = Color.Transparent;

            //if (lb != lbselect )
            //{
            //    lb.BackColor = Color.Transparent;
            //}
        }

        //-------------------------------------tab Quản Lý Phòng---------------------------------------------------------------
        public void LoadDB()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                // Câu lệnh SQL tối ưu: Đếm sinh viên thực tế, tính Remain và Trạng thái
                string SqlSelect = @"
        SELECT 
            r.ID, 
            COUNT(s.ID) AS Quantity, 
            r.MaxQuantity, 
            r.Type, -- Tính số chỗ còn lại
            CASE 
                WHEN COUNT(s.ID) < r.MaxQuantity THEN N'Còn trống'
                ELSE N'Không trống'
            END AS state
        FROM Rooms r
        LEFT JOIN Students s ON r.ID = s.IDRoom
        GROUP BY r.ID, r.MaxQuantity, r.Type";

                SqlDataAdapter Adapter = new SqlDataAdapter(SqlSelect, conn);
                DataTable DT = new DataTable();
                Adapter.Fill(DT);

                dataList.DataSource = DT;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            BtnAdd f = new BtnAdd(this);
            f.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPhongCanXoa = dataList.SelectedRows[0].Cells[0].Value.ToString();

            DialogResult dialogResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa phòng {maPhongCanXoa} không?\n" +
                "Hành động này sẽ XÓA TẤT CẢ sinh viên ở trong phòng và các khoản TIỀN PHẠT liên quan!\nDữ liệu đã xóa sẽ không thể khôi phục!",
                "Xác nhận xóa toàn bộ dữ liệu liên quan",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connect))
                    {
                        connection.Open();

                        // Sử dụng SqlTransaction để đảm bảo an toàn dữ liệu
                        using (SqlTransaction transaction = connection.BeginTransaction())
                        {
                            try
                            {
                                // Bước 1: Xóa tiền phạt trong bảng Fines của những SV thuộc phòng này
                                // Dùng truy vấn con (Subquery) để tìm IDStudents nằm trong phòng cần xóa
                                string sqlDeleteFines = @"
                        DELETE FROM Fines 
                        WHERE IDStudents IN (SELECT ID FROM Students WHERE IDRoom = @idRoom)";

                                using (SqlCommand cmdFines = new SqlCommand(sqlDeleteFines, connection, transaction))
                                {
                                    cmdFines.Parameters.AddWithValue("@idRoom", maPhongCanXoa);
                                    cmdFines.ExecuteNonQuery();
                                }

                                string sqlDeleteStudents = "DELETE FROM Students WHERE IDRoom = @idRoom";
                                using (SqlCommand cmdStudents = new SqlCommand(sqlDeleteStudents, connection, transaction))
                                {
                                    cmdStudents.Parameters.AddWithValue("@idRoom", maPhongCanXoa);
                                    cmdStudents.ExecuteNonQuery();
                                }

                                string sqlDeleteRoom = "DELETE FROM Rooms WHERE ID = @idRoom";
                                int roomResult = 0;
                                using (SqlCommand cmdRoom = new SqlCommand(sqlDeleteRoom, connection, transaction))
                                {
                                    cmdRoom.Parameters.AddWithValue("@idRoom", maPhongCanXoa);
                                    roomResult = cmdRoom.ExecuteNonQuery();
                                }
                                if (roomResult > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Xóa phòng, sinh viên và dữ liệu phạt liên quan thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    transaction.Rollback(); // Hủy bỏ nếu không tìm thấy phòng
                                    MessageBox.Show("Không tìm thấy phòng cần xóa hoặc phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            catch (Exception exInner)
                            {
                                transaction.Rollback();
                                throw new Exception("Quá trình xóa liên kết thất bại. Chi tiết lỗi: " + exInner.Message);
                            }
                        }
                    }

                    // Tải lại dữ liệu lên giao diện
                    LoadDB();
                    if (typeof(Form).GetMethod("LoadFines") != null)
                    {
                        // Nếu em có hàm LoadFines() hoặc danh sách phạt ở form này thì gọi lại ở đây
                        // LoadFines(); 
                    }

                    btn_delete.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;

            if (dong >= 0)
            {
                ID.DataPropertyName = dataList.Rows[dong].Cells[0].Value.ToString();
                currentRoom = dataList.Rows[dong].Cells[0].Value.ToString();
                currentGender = dataList.Rows[dong].Cells[3].Value.ToString();
                btn_delete.Enabled = true;
            }
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) conn.Open();

                // Sửa chuỗi SQL gốc: Dùng LEFT JOIN để đếm sinh viên thực tế trước khi lọc bằng HAVING
                string sql = @"
        SELECT 
            r.ID, 
            COUNT(s.ID) AS Quantity, 
            r.MaxQuantity, 
            r.Type,
            CASE 
                WHEN COUNT(s.ID) < r.MaxQuantity THEN N'Còn trống'
                ELSE N'Không trống'
            END AS State
        FROM Rooms r
        LEFT JOIN Students s ON r.ID = s.IDRoom
        WHERE 1=1";

                // Lọc mã phòng
                if (tbID.Text.Trim() != "")
                {
                    sql += " AND r.ID LIKE N'%" + tbID.Text.Trim() + "%'";
                }

                // Lọc giới tính
                if (cbbType.Text != "")
                {
                    sql += " AND r.Type = N'" + cbbType.Text + "' ";
                }

                // Gom nhóm để tính hàm COUNT
                sql += " GROUP BY r.ID, r.MaxQuantity, r.Type";

                // Lọc trạng thái (Vì lọc theo kết quả hàm COUNT nên phải dùng HAVING thay vì WHERE)
                if (cbbState.Text == "Còn trống")
                {
                    sql += " HAVING COUNT(s.ID) < r.MaxQuantity";
                }
                else if (cbbState.Text == "Không trống")
                {
                    sql += " HAVING COUNT(s.ID) >= r.MaxQuantity";
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();

                // Đổ dữ liệu từ SQL vào DataTable trước (Bỏ hoàn toàn vòng lặp foreach lỗi cũ)
                adapter.Fill(dt);

                dataList.DataSource = dt;
                tbID.Text = "";
                cbbType.Text = "";
                cbbState.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa!");
                return;
            }

            string maPhong = dataList.SelectedRows[0].Cells["dgvID"].Value.ToString();

            FormEdit f = new FormEdit(maPhong);

            f.ShowDialog();
            LoadDB();
        }

        private void btn_sv_Click(object sender, EventArgs e)
        {
            Management QLSV = new Management(currentRoom, currentGender, this);
            QLSV.Show();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.MediumSpringGreen;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Aquamarine;
        }

        private void btn_payMent_Click(object sender, EventArgs e)
        {
            FrmChiTietThanhToan PayDetail = new FrmChiTietThanhToan(currentRoom);
            PayDetail.Show();
            PayDetail.Text = "Thanh toán cho phòng " + currentRoom;
        }
    }
}
