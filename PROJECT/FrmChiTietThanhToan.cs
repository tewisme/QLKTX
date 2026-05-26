using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChucNangThanhToan
{
    public partial class FrmChiTietThanhToan : Form
    {
        string IDRoom = "";
        int type = 0, waterNumber = 0, electNumber = 0;
        int elecPrice = 0, waterPrice = 0, servicePrice = 0, roomPrice = 0;
        public FrmChiTietThanhToan(string iDRoom)
        {
            InitializeComponent();
            IDRoom = iDRoom;
        }

        string connectS = @"Data Source=.;Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True";
        SqlConnection conn = null;

        private void ConnectDB()
        {
            try
            {
                conn = new SqlConnection(connectS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");

            }
        }
        private void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectS))
                {
                    conn.Open();
                    string sqlSelectStudents = "SELECT *, '' AS Room, '' AS Fine FROM Students WHERE IDRoom = @IDRoom"; DataTable dt = new DataTable();
                    string sqlSelectRoom = "SELECt * FROM Rooms WHERE ID = @IDRoom";
                    using (SqlCommand cmdRoom = new SqlCommand(sqlSelectRoom, conn))
                    {
                        cmdRoom.Parameters.AddWithValue("@IDRoom", IDRoom);

                        using (SqlDataReader reader = cmdRoom.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lb_diencu.Text = reader["ElecNumber"].ToString();
                                lb_nuoccu.Text = reader["WaterNumber"].ToString();
                                type = Convert.ToInt32(reader["MaxQuantity"]);
                            }
                        }
                    }
                    string sqlSelectFees = "SELECT * FROM Fees Where Type = @type";
                    using (SqlCommand cmd = new SqlCommand(sqlSelectFees, conn))
                    {
                        cmd.Parameters.AddWithValue("@type", type);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                elecPrice = Convert.ToInt32(reader["Elect"]);
                                waterPrice = Convert.ToInt32(reader["Water"]);
                                roomPrice = Convert.ToInt32(reader["Room"]);
                                servicePrice = Convert.ToInt32(reader["Service"]);
                                lb_tiendichvu.Text = servicePrice.ToString();
                            }
                        }
                    }
                    using (SqlCommand cmdStudents = new SqlCommand(sqlSelectStudents, conn))
                    {
                        cmdStudents.Parameters.AddWithValue("@IDRoom", IDRoom);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmdStudents))
                        {
                            adapter.Fill(dt);
                        }
                    }
                    if (dt.Columns.Contains("Gender")) dt.Columns.Remove("Gender");
                    if (dt.Columns.Contains("IDRoom")) dt.Columns.Remove("IDRoom");
                    if (dt.Columns.Contains("DateIn")) dt.Columns.Remove("DateIn");
                    if (dt.Columns.Contains("Fine1")) dt.Columns.Remove("Fine1");

                    foreach (DataRow dr in dt.Rows)
                    {
                        string studentID = dr["ID"].ToString();
                        int fineSum = 0;

                        string selectFine = "SELECT SUM(Money) From Fines Where IDStudents = @id";

                        using (SqlCommand cmdFine = new SqlCommand(selectFine, conn))
                        {
                            cmdFine.Parameters.AddWithValue("@id", studentID);
                            object res = cmdFine.ExecuteScalar();

                            if (res != DBNull.Value && res != null)
                            {
                                fineSum = Convert.ToInt32(res);
                            }
                        }
                        dr["Room"] = roomPrice.ToString();
                        dr["Fine"] = fineSum.ToString();
                    }
                    dsSV.DataSource = dt;
                    string query = "SELECT * FROM Histories WHERE IDRoom = @id";
                    DataTable dtS = new DataTable(); ;
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", IDRoom);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dtS);
                        }
                    }
                    if (dtS.Rows.Count > 0)
                    {
                        DateTime ngayMoiNhat = dtS.AsEnumerable().Max(row => row.Field<DateTime>("Paydate"));
                        DateTime ngayHienTai = DateTime.Now;

                        if (ngayMoiNhat.Month == ngayHienTai.Month && ngayMoiNhat.Year == ngayHienTai.Year)
                        {
                            btn_TrangThai.Text = "Đã thanh toán";
                            btn_TrangThai.BackColor = Color.FromArgb(127, 255, 0);
                        }
                        else
                        {
                            btn_TrangThai.Text = "Chưa thanh toán";
                            btn_TrangThai.BackColor = SystemColors.Control;
                        }
                    }
                    else
                    {
                        btn_TrangThai.Text = "Chưa thanh toán";
                        btn_TrangThai.BackColor = Color.Tomato;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void btn_lichsu_Click(object sender, EventArgs e)
        {
            
            FrmLichSuThanhToan frm = new FrmLichSuThanhToan(IDRoom);
            frm.Text = "Lịch sử thanh toán của phòng " + IDRoom;
            frm.ShowDialog();
        }

        private void btn_TrangThai_Click(object sender, EventArgs e)
        {
            if (!(sender is Button btn)) return;
            if (btn.Text == "Chưa thanh toán")
            {
                // 1. Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_dienmoi.Text) || string.IsNullOrWhiteSpace(txt_nuocmoi.Text))
                {
                    MessageBox.Show("Vui lòng điền thông tin điện, nước mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Xác nhận thanh toán phòng
                DialogResult result = MessageBox.Show("Xác nhận thanh toán cho phòng này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // 3. Tiến hành lưu lịch sử thanh toán tiền phòng trước
                    if (LuuLichSuThanhToan())
                    {
                        btn.Text = "Đã thanh toán";
                        btn.BackColor = Color.FromArgb(127, 255, 0);
                        MessageBox.Show("Đã lưu lịch sử thanh toán thành công!", "Thông báo");

                        string connectS = @"Data Source=.;Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True";

                        using (SqlConnection conn = new SqlConnection(connectS))
                        {
                            try
                            {
                                conn.Open();

                               string queryUpdateRoom = @"
                        UPDATE Rooms 
                        SET ElecNumber = @elec, WaterNumber = @water 
                        WHERE ID = @idRoom";

                                using (SqlCommand cmdUpdate = new SqlCommand(queryUpdateRoom, conn))
                                {
                                    cmdUpdate.Parameters.AddWithValue("@elec", Convert.ToInt32(txt_dienmoi.Text.Trim()));
                                    cmdUpdate.Parameters.AddWithValue("@water", Convert.ToInt32(txt_nuocmoi.Text.Trim()));
                                    cmdUpdate.Parameters.AddWithValue("@idRoom", IDRoom);
                                    cmdUpdate.ExecuteNonQuery();
                                }

                                string queryGetStudents = "SELECT ID FROM Students WHERE IDRoom = @idRoom";
                                DataTable dtStudents = new DataTable();

                                using (SqlCommand cmdGet = new SqlCommand(queryGetStudents, conn))
                                {
                                    cmdGet.Parameters.AddWithValue("@idRoom", IDRoom);
                                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmdGet))
                                    {
                                        adapter.Fill(dtStudents);
                                    }
                                }

                                if (dtStudents.Rows.Count > 0)
                                {
                                    string queryDeleteFines = "DELETE FROM Fines WHERE IDStudents = @idStudent";
                                    int totalDeleted = 0;

                                    foreach (DataRow row in dtStudents.Rows)
                                    {
                                        string idStudent = row["ID"].ToString();

                                        if (!string.IsNullOrEmpty(idStudent))
                                        {
                                            using (SqlCommand cmdDelete = new SqlCommand(queryDeleteFines, conn))
                                            {
                                                cmdDelete.Parameters.AddWithValue("@idStudent", idStudent);
                                                int res = cmdDelete.ExecuteNonQuery();
                                                if (res > 0)
                                                {
                                                    totalDeleted += res;
                                                }
                                            }
                                        }
                                    }

                                    if (totalDeleted > 0)
                                    {
                                        MessageBox.Show($"Đã xóa thành công {totalDeleted} bản ghi phạt của các sinh viên thuộc phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }

                                LoadData();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Có lỗi xảy ra khi xử lý cập nhật dữ liệu hoặc xóa tiền phạt: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không thể lưu lịch sử thanh toán!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Tháng này đã được thanh toán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private bool LuuLichSuThanhToan()
        {
            try
            {
                string sqlInsert = @"INSERT INTO Histories (IDRoom, Month, Total, State, Paydate, newWater, oldWater, newElect, oldElect) 
                             VALUES (@IDRoom, @Month, @Total, @State, @Paydate, @newWater, @oldWater, @newElect, @oldElect)";

                using (SqlConnection connection = new SqlConnection(connectS))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(sqlInsert, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDRoom", IDRoom);
                        int thangHienTai = DateTime.Now.Month;
                        cmd.Parameters.AddWithValue("@Month", thangHienTai);
                        int tongTien = 0;
                        int.TryParse(lb_tongtien.Text, out tongTien);
                        cmd.Parameters.AddWithValue("@Total", tongTien);
                        cmd.Parameters.AddWithValue("@State", "Đã thanh toán");
                        cmd.Parameters.AddWithValue("@Paydate", DateTime.Now.Date);
                        cmd.Parameters.AddWithValue("@oldElect",lb_diencu.Text);
                        cmd.Parameters.AddWithValue("@oldWater",lb_nuoccu.Text);
                        cmd.Parameters.AddWithValue("@newElect", txt_dienmoi.Text);
                        cmd.Parameters.AddWithValue("@newWater", txt_nuocmoi.Text);
                        int rows = cmd.ExecuteNonQuery();
                        return rows > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu lịch sử: " + ex.Message, "Thông báo lỗi");
                return false;
            }
        }
        private void txt_dienmoi_Leave(object sender, EventArgs e)
        {
            int soMoi;
            int soCu = int.Parse(lb_diencu.Text);
            bool hople = int.TryParse(txt_dienmoi.Text, out soMoi);// gan duoc hople =true
            if (!hople || soMoi < soCu)
            {
                MessageBox.Show("Số nước mới phải lớn hơn số cũ hoặc là số nguyên!", "Lỗi");
                txt_dienmoi.Clear();

            }
            else
            {
                int soDien = soMoi - soCu;
                int tienDien = soDien * 2000;
                lb_tiendien.Text = tienDien.ToString();
            }
        }
        private void txt_nuocmoi_Leave(object sender, EventArgs e)
        {
            if (txt_nuocmoi.Text == "") return;
            int soMoi;
            int soCu = int.Parse(lb_nuoccu.Text);
            bool hople = int.TryParse(txt_nuocmoi.Text, out soMoi);// gan duoc hople =true
            if (!hople || soMoi < soCu)
            {
                MessageBox.Show("Số nước mới phải lớn hơn số cũ hoặc là số nguyên!", "Lỗi");
                txt_nuocmoi.Clear();
                return;

            }
            else
            {
                int soNuoc = soMoi - soCu;
                int tienNuoc = soNuoc * waterPrice;
                lb_tiennuoc.Text = tienNuoc.ToString();
                if (txt_dienmoi.Text != "")
                {
                    int tongtien = 0;

                    tongtien = tienNuoc + int.Parse(lb_tiendien.Text) + int.Parse(lb_tiendichvu.Text) + int.Parse(lb_tienphat.Text);
                    lb_tongtien.Text = tongtien.ToString();

                }
            }
        }

        private void btn_InHoaDon_Click(object sender, EventArgs e)
        {
            if(txt_dienmoi.Text ==""|| txt_nuocmoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số điện, nước mới", "Thông báo");
            }
            else
            {
                printPreviewDialog1.Document = printDocument1;
                PaperSize paperSize = new PaperSize("A4", 827, 1169);

                printDocument1.DefaultPageSettings.PaperSize = paperSize;

                printDocument1.DefaultPageSettings.Margins =
                    new Margins(50, 50, 50, 50);
                printPreviewDialog1.ShowDialog();
            }
        }

        private void txt_dienmoi_Leave_1(object sender, EventArgs e)
        {
            if (txt_dienmoi.Text == "") return;
            int soMoi;
            int soCu = int.Parse(lb_diencu.Text);
            bool hople = int.TryParse(txt_dienmoi.Text, out soMoi);// gan duoc hople =true
            if (!hople || soMoi < soCu)
            {
                MessageBox.Show("Số nước mới phải lớn hơn số cũ hoặc là số nguyên!", "Lỗi");
                txt_dienmoi.Clear();
                return;

            }
            else
            {
                int soDien = soMoi - soCu;
                int tienDien = soDien * elecPrice;
                lb_tiendien.Text = tienDien.ToString();
                if (txt_nuocmoi.Text != "")
                {
                    int tongtien = 0;

                    tongtien = tienDien + int.Parse(lb_tiennuoc.Text) + int.Parse(lb_tiendichvu.Text) + int.Parse(lb_tienphat.Text);
                    lb_tongtien.Text = tongtien.ToString();

                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font tieude = new Font("Arial", 22, FontStyle.Bold);
            Font normal = new Font("Arial", 13);
            Font dam = new Font("Arial", 14, FontStyle.Bold);
            Font fontBang = new Font("Arial", 12);
            Font fontDam = new Font("Arial", 12, FontStyle.Bold);
            Pen pen = new Pen(Color.Black, 1);
            int y = 40;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString("HÓA ĐƠN THANH TOÁN KTX", tieude, Brushes.Black, new Rectangle(0, y, 850, 40), sf);
            y += 70;
            g.DrawString("Mã phòng: "+ IDRoom, normal, Brushes.Black, 50, y);
            y += 30;
            
            g.DrawString("Loại phòng: "+type+" người", normal, Brushes.Black, 50, y);
            y += 30;
            g.DrawString("Ngày in hóa đơn: " + DateTime.Now.ToString("dd/MM/yyyy"), normal, Brushes.Black, 50, y);
            y += 50;

            int x = 50;
            int rowHeight = 40;
            int cot0 = 120;
            int cot1 = 120;
            int cot2 = 120;
            int cot3 = 120;
            int cot4 = 150;
            int width = cot0 + cot1 + cot2 + cot3 + cot4;
            // Khung ngoài
            g.DrawRectangle(pen, x, y, width, rowHeight * 3);
            // Kẻ ngang
            g.DrawLine(pen, x, y + rowHeight, x + width, y + rowHeight);
            g.DrawLine(pen, x, y + rowHeight * 2, x + width, y + rowHeight * 2);
            // Kẻ dọc
            g.DrawLine(pen, x + cot0, y, x + cot0, y + rowHeight * 3);
            g.DrawLine(pen, x + cot0 + cot1, y, x + cot0 + cot1, y + rowHeight * 3);
            g.DrawLine(pen, x + cot0 + cot1 + cot2, y, x + cot0 + cot1 + cot2, y + rowHeight * 3);
            g.DrawLine(pen, x + cot0 + cot1 + cot2 + cot3, y, x + cot0 + cot1 + cot2 + cot3, y + rowHeight * 3);
            g.DrawString("Loại", fontDam, Brushes.Black, x + 30, y + 10);
            g.DrawString("Chỉ số cũ", fontDam, Brushes.Black, x + cot0 + 10, y + 10);
            g.DrawString("Chỉ số mới", fontDam, Brushes.Black, x + cot0 + cot1 + 10, y + 10);
            g.DrawString("Số đã dùng", fontDam, Brushes.Black, x + cot0 + cot1 + cot2 + 10, y + 10);
            g.DrawString("Thành tiền", fontDam, Brushes.Black, x + cot0 + cot1 + cot2 + cot3 + 10, y + 10);
            int dienCu = int.Parse(lb_diencu.Text);
            int dienMoi = int.Parse(txt_dienmoi.Text);
            int soDien = dienMoi - dienCu;
            g.DrawString("Điện", fontBang, Brushes.Black, x + 30, y + rowHeight + 10);
            g.DrawString(dienCu.ToString(), fontBang, Brushes.Black, x + cot0 + 40, y + rowHeight + 10);
            g.DrawString(dienMoi.ToString(), fontBang, Brushes.Black, x + cot0 + cot1 + 40, y + rowHeight + 10);
            g.DrawString(soDien.ToString(), fontBang, Brushes.Black, x + cot0 + cot1 + cot2 + 40, y + rowHeight + 10);
            g.DrawString(lb_tiendien.Text, fontBang, Brushes.Black, x + cot0 + cot1 + cot2 + cot3 + 20, y + rowHeight + 10);
            int nuocCu = int.Parse(lb_nuoccu.Text);
            int nuocMoi = int.Parse(txt_nuocmoi.Text);
            int soNuoc = nuocMoi - nuocCu;
            g.DrawString("Nước", fontBang, Brushes.Black, x + 30, y + rowHeight * 2 + 10);
            g.DrawString(nuocCu.ToString(), fontBang, Brushes.Black, x + cot0 + 40, y + rowHeight * 2 + 10);
            g.DrawString(nuocMoi.ToString(), fontBang, Brushes.Black, x + cot0 + cot1 + 40, y + rowHeight * 2 + 10);
            g.DrawString(soNuoc.ToString(), fontBang, Brushes.Black, x + cot0 + cot1 + cot2 + 40, y + rowHeight * 2 + 10);
            g.DrawString(lb_tiennuoc.Text, fontBang, Brushes.Black, x + cot0 + cot1 + cot2 + cot3 + 20, y + rowHeight * 2 + 10);
            y += 170;
            g.DrawString("Tổng tiền: " + lb_tongtien.Text, normal, Brushes.Black, 50, y);
            y += 35;
            g.DrawString("Tiền dịch vụ: " + lb_tiendichvu.Text, normal, Brushes.Black, 50, y);
            y += 35;
            g.DrawString("Tiền phạt: " + lb_tienphat.Text, normal, Brushes.Black, 50, y);
            y += 35;
            int tong = TongTienPhong();
            g.DrawString("Tiền phòng: " +tong , normal, Brushes.Black, 50, y);
            y += 50;
            g.DrawString("TỔNG THANH TOÁN: " + lb_tongtien.Text + " VNĐ", dam, Brushes.Black, 50, y);
            y += 170;
            g.DrawString("Người thanh toán", normal, Brushes.Black, 70, y);
            g.DrawString("Người quản lý", normal, Brushes.Black, 430, y);
        }
        private void TinhTongTienPhat()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dsSV.Rows)
            {
                if (row.Cells["col_phat"].Value != null)
                {
                    tong += Convert.ToInt32(row.Cells["col_phat"].Value);
                }

            }
            lb_tienphat.Text = tong.ToString();
        }
        private int TongTienPhong()
        {
            int tong = 0;
            foreach (DataGridViewRow row in dsSV.Rows)
            {
                if (row.Cells["Money"].Value != null)
                {
                    tong += Convert.ToInt32(row.Cells["Money"].Value);
                }

            }
            return tong;
        }

        private void FrmChiTietThanhToan_Load(object sender, EventArgs e)
        {
            ConnectDB();
            LoadData();
            TinhTongTienPhat();
   
        }
    }
}

