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
            string query = "SELECT IDRoom, Month, Total, State, Paydate FROM Histories WHERE IDRoom = @id ORDER BY Paydate DESC";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectS))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Truyền tham số @id vào câu lệnh truy vấn (Lấy mã phòng tương ứng từ biến id)
                        cmd.Parameters.AddWithValue("@id", currentRoom);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dsLichSu.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể tải lịch sử thanh toán: " + ex.Message);
            }
        }
    }
}
