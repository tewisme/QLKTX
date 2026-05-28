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

namespace ChucNangThanhToan
{
    public partial class FrmLichSuThanhToan : Form
    {
        string currentRoom = "";

        // Tạo các thuộc tính công khai (Public) để Form Chi Tiết có thể vào lấy dữ liệu
        public bool IsSelected { get; set; } = false; // Kiểm tra xem người dùng có chọn dòng nào không
        public string SelectedOldElect { get; set; }
        public string SelectedNewElect { get; set; }
        public string SelectedOldWater { get; set; }
        public string SelectedNewWater { get; set; }
        public string SelectedTotalFine { get; set; }
        public string SelectedTotal { get; set; }
        public FrmLichSuThanhToan(string IDRoom)
        {
            InitializeComponent();
            currentRoom = IDRoom;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmLichSuThanhToan_Load(object sender, EventArgs e)
        {
            string connectS = @"Data Source=.;Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True";
            string query = "SELECT IDRoom, Month, Total, State, Paydate,oldElect, newElect, oldWater, newWater, TotalFine FROM Histories WHERE IDRoom = @id ORDER BY Paydate DESC";
            
            try
            {
                using (SqlConnection conn = new SqlConnection(connectS))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // truyền tham số @id vào câu lệnh truy vấn (lấy mã phòng tương ứng từ biến id)
                        cmd.Parameters.AddWithValue("@id", currentRoom);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dsLichSu.DataSource = dt;
                            if (dsLichSu.Columns["TotalFine"] != null)
                            {
                                dsLichSu.Columns["TotalFine"].Visible= false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lịch sử thanh toán: " + ex.Message);
            }

        }
        private void dsLichSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dsLichSu.Rows[e.RowIndex];
                SelectedOldElect = row.Cells["oldElect"].Value?.ToString();
                SelectedNewElect = row.Cells["newElect"].Value?.ToString();
                SelectedOldWater = row.Cells["oldWater"].Value?.ToString();
                SelectedNewWater = row.Cells["newWater"].Value?.ToString();
                SelectedTotalFine = row.Cells["TotalFine"].Value != DBNull.Value ? row.Cells["TotalFine"].Value?.ToString() : "0";
                SelectedTotal = row.Cells["Total"].Value?.ToString();

                IsSelected = true;
                this.Close();
            }
        }
    }
}
