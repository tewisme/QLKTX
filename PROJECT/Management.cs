using QLKTX;
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

namespace ROUTER2
{
    public partial class Management : Form
    {
        string currentRoom = "P101", currentGender ="";
        ThongKe preTK = new ThongKe();
        public Management(string IDRoom, string Gender, ThongKe TK)
        {
            InitializeComponent();
            currentRoom = IDRoom;
            currentGender = Gender;
            preTK = TK;
        }

        string connString = "Data Source=.; Initial Catalog=QLKTX; Integrated Security=True; TrustServerCertificate=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string sqlSelectStudents = "SELECT * FROM Students WHERE IDRoom = @IDRoom";

                    DataTable dt = new DataTable();
                    using (SqlCommand cmdStudents = new SqlCommand(sqlSelectStudents, conn))
                    {
                        cmdStudents.Parameters.AddWithValue("@IDRoom", currentRoom);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmdStudents))
                        {
                            adapter.Fill(dt);
                        }
                    }

                    if (dt.Columns.Contains("IDRoom"))
                    {
                        dt.Columns.Remove("IDRoom");
                    }

                    foreach (DataRow dr in dt.Rows)
                    {
                        string studentID = dr["ID"].ToString();
                        int fineSum = 0;

                        string selectFine = "SELECT SUM(Money) From Fines Where IDStudents = @id";

                        using (SqlCommand cmdFine = new SqlCommand(selectFine, conn))
                        {
                            cmdFine.Parameters.AddWithValue("@id", studentID);
                            object res = cmdFine.ExecuteScalar();

                            if (res != DBNull.Value && res != null )
                            {
                                fineSum = Convert.ToInt32(res);
                            }
                        }
                        dr["Fine"] = fineSum;
                    }
                    dgvRoom.DataSource = dt;

                    string sqlSelectRoom = "SELECT * FROM Rooms WHERE ID = @IDRoom";

                    string roomId = "";
                    int maxQuantity = 0;
                    bool isFound = false;

                    // 1. ĐOẠN 1: Dùng Reader để đọc thông tin phòng và lưu vào biến tạm
                    using (SqlCommand cmdRoom = new SqlCommand(sqlSelectRoom, conn))
                    {
                        cmdRoom.Parameters.AddWithValue("@IDRoom", currentRoom);

                        using (SqlDataReader reader = cmdRoom.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                roomId = reader["ID"].ToString();
                                maxQuantity = Convert.ToInt32(reader["MaxQuantity"]);
                                isFound = true;
                            }
                        }
                    }
                    if (isFound)
                    {
                        string sqlCountSV = "SELECT COUNT(*) FROM Students WHERE IDRoom = @IDRoom";
                        int quantity = 0;

                        using (SqlCommand cmdCount = new SqlCommand(sqlCountSV, conn))
                        {
                            cmdCount.Parameters.AddWithValue("@IDRoom", currentRoom);
                            quantity = Convert.ToInt32(cmdCount.ExecuteScalar());
                        }

                        // 3. Hiển thị tất cả lên giao diện
                        tbIdRoom.Text = roomId;
                        tbQuantity.Text = quantity.ToString();
                        tbRemain.Text = (maxQuantity - quantity).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin phòng này!", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi xảy ra");
            }
        }

        #region Hiệu ứng Màu sắc các Button (Mouse Hover)

        private void btAdd_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkTurquoise;
        }

        private void btAdd_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.CadetBlue;
        }

        private void btnEdit_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Yellow;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightYellow;
        }

        private void btnDelete_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.OrangeRed;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSalmon;
        }

        #endregion

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow currentRow = dgvRoom.CurrentRow;
            if (currentRow == null) return;
            tbSelectedIDStudent.Text = currentRow.Cells[0].Value.ToString();
            tbSelectedNameStudent.Text = currentRow.Cells[1].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string IDStudent = tbSelectedIDStudent.Text;
            if (dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn (bôi xanh) dòng sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult resDia = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resDia == DialogResult.No) return;
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string SelectedId = tbSelectedIDStudent.Text;
                    string sqlDelete = "DELETE FROM Students Where ID = @id";
                    SqlCommand cmd = new SqlCommand(sqlDelete, conn);
                    cmd.Parameters.AddWithValue("@id", SelectedId);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("Xóa thành công", "Thông báo");
                        LoadData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string IDRoom = tbIdRoom.Text;

            AddForm AF = new AddForm(IDRoom, currentGender, this);
            AF.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string IDStudent = tbSelectedIDStudent.Text;
            if (dgvRoom.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn (bôi xanh) dòng sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            EditForm EF = new EditForm(IDStudent, this);
            EF.Show();
            EF.Text = "Sửa sinh viên " + tbSelectedNameStudent.Text;
        }

        private void tbIdRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void Management_FormClosed(object sender, FormClosedEventArgs e)
        {
            preTK.LoadDB();
        }
    }
}