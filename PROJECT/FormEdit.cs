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

namespace QLKTX
{
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }
        string connectS = "Data Source=.; Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True";
        SqlConnection conn = null;
        string maPhong;
        public FormEdit(string idPhong)
        {
            InitializeComponent();
            maPhong = idPhong;
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectS);

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Sửa Phòng " + maPhong;

            tbID.ReadOnly = true;

            cbbType.Items.Clear();
            cbbType.Items.Add("Phòng Nam");
            cbbType.Items.Add("Phòng Nữ");

            LoadThongTinPhong();
        }
        private void LoadThongTinPhong()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = @"
            SELECT 
                r.ID, 
                COUNT(s.ID) AS ActualQuantity, 
                r.MaxQuantity, 
                r.Type
            FROM Rooms r
            LEFT JOIN Students s ON r.ID = s.IDRoom
            WHERE r.ID = @ID
            GROUP BY r.ID, r.MaxQuantity, r.Type";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID", maPhong);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbID.Text = reader["ID"].ToString();

                    tbQuantity.Text = reader["ActualQuantity"].ToString();

                    cbbMaxQuantity.Text = reader["MaxQuantity"].ToString();
                    cbbType.Text = reader["Type"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(tbQuantity.Text);
                int maxQuantity = int.Parse(cbbMaxQuantity.Text);

                if (quantity > maxQuantity)
                {
                    MessageBox.Show("Số người ở hiện tại không được lớn hơn số người ở tối đa!");
                    return;
                }

                if (cbbType.Text == "")
                {
                    MessageBox.Show("Bạn cần chọn loại phòng!");
                    return;
                }

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string sql = @"
    UPDATE Rooms
    SET 
        Quantity = @Quantity,
        MaxQuantity = @MaxQuantity,
        Type = @Type
    WHERE ID = @ID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Quantity", tbQuantity.Text);
                cmd.Parameters.AddWithValue("@MaxQuantity", cbbMaxQuantity.Text);
                cmd.Parameters.AddWithValue("@Type", cbbType.Text);
                cmd.Parameters.AddWithValue("@ID", maPhong);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Sửa phòng thành công!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ!");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
