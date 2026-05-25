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
    public partial class BtnAdd : Form
    {
        public BtnAdd()
        {
            InitializeComponent();
        }
        string connectionS = "Data Source=.; Initial Catalog=QLKTX;Trusted_Connection=True;TrustServerCertificate=True";
        ThongKe f = new ThongKe();
        public BtnAdd(ThongKe f1)
        {
            InitializeComponent();

            f = f1;
        }

        private void BtnAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text.Trim()))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
                return;
            }


            if (!int.TryParse(cbMax.Text.Trim(), out int toiDa))
            {
                MessageBox.Show("Số người tối đa phải là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMax.Focus();
                return;
            }

            if (string.IsNullOrEmpty(cbType.Text))
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbType.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã phòng và Tên phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(connectionS))
            {
                string query = "INSERT INTO Rooms (ID, Quantity, MaxQuantity, WaterNumber, ElecNumber, Type) " +
                               "VALUES (@ID, @Quantity, @MaxQuantity,@Water, @Elec, @Type)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@Quantity", 0);
                    cmd.Parameters.AddWithValue("@MaxQuantity", Convert.ToInt32(cbMax.Text));
                    cmd.Parameters.AddWithValue("@Type", cbType.Text);
                    cmd.Parameters.AddWithValue("@Water", 0);
                    cmd.Parameters.AddWithValue("@Elec", 0);



                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật dữ liệu vào CSDL thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        f.LoadDB();
                        this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message, "Lỗi cú pháp/Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
