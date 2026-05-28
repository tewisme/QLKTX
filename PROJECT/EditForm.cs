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
    public partial class EditForm : Form
    {
        Management F1 = null;
        string ID = "";
        string connString = "Data Source=.; Initial Catalog=QLKTX; Integrated Security=True; TrustServerCertificate=True";
        string[] idF = new string[1000];
        public EditForm(string IDStudent, Management MT)
        {
            InitializeComponent();
            ID = IDStudent;
            F1 = MT;
        }
        private void LoadFines()
        {
            string sqlSelect = "SELECT * From Fines Where IDStudents = @id";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);

                    }
                }
                int index = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    idF[index] = dr["IDFines"].ToString();
                    dr["IDFines"] = index;
                    index += 1;
                }
                dt.Columns.Remove("IDStudents");
                dgvFines.DataSource = dt;
            }
        }
        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlSelect = "SELECT * From Students Where ID = @id";
                using (SqlCommand cmd = new SqlCommand(sqlSelect, conn))
                {
                    cmd.Parameters.AddWithValue("@id", ID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tbIdStudent.Text = reader["ID"].ToString();
                            tbNameStudent.Text = reader["FullName"].ToString();
                            dtpCheckIn.Value = Convert.ToDateTime(reader["DateIn"]);
                            if (reader["Gender"].ToString() == "Nam")
                            {
                                rbMale.Checked = true;
                            }
                            else rbFemale.Checked = true;
                        }
                    }
                }
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadFines();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng click chọn (bôi xanh) dòng bản phạt cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow currentRow = dgvFines.CurrentRow;
            if (currentRow == null) return;
            DialogResult resDia = MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resDia == DialogResult.No) return;
            string IDFines = idF[Convert.ToInt32(currentRow.Cells["IDFines"].Value)];
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlDelete = "Delete From Fines Where IDFines = @id";
                using (SqlCommand cmd = new SqlCommand(sqlDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@id", IDFines);
                    int res = cmd.ExecuteNonQuery();
                    if ( res > 0 )
                    {
                        MessageBox.Show("Đã xóa thành công", "Thông báo");
                        LoadFines();
                    }
                }
            }
        }

        private void EditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            F1.LoadData();
        }

        private void tbFine_Leave(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(cbbLevel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chỉ nhập số nguyên", "Thông báo");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dtpCheckIn == null || tbFine.Text == "" || tbReason.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phạt", "Thông báo");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    string idFines = Guid.NewGuid().ToString("N").Substring(0, 10);
                    DateTime date = dtpFine.Value;
                    string reason = tbReason.Text;
                    int money = Convert.ToInt32(tbFine.Text);
                    string sqlUpdate = "INSERT Into Fines (IDFines, IDStudents, Date, Reason, Money) " +
                                        "Values (@idfines, @idstudents, @date, @reason, @money)";
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@idfines", idFines);
                        cmd.Parameters.AddWithValue("@idstudents", ID);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@reason", reason);
                        cmd.Parameters.AddWithValue("@money", money);
                        int res = cmd.ExecuteNonQuery();
                        if ( res > 0 )
                        {
                            MessageBox.Show("Bạn đã thêm thành công!", "Thông báo");
                            LoadFines();
                            tbReason.Clear();
                            cbbLevel.Text = "Chọn mức phạt";
                            tbFine.Clear();
                            tbFine.Enabled = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightYellow;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNameStudent.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên", "Thông báo");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();

                    string sqlUpdate = "UPDATE Students SET FullName = @name Where ID = @id";
                    using (SqlCommand cmd = new SqlCommand(sqlUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", tbNameStudent.Text);
                        cmd.Parameters.AddWithValue("@id", tbIdStudent.Text);
                        int res = cmd.ExecuteNonQuery();
                        if (res > 0 )
                        {
                            MessageBox.Show("Đã sửa tên thành công!","Thông báo");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            LoadData();
        }

        private void cbbLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string level = cbbLevel.SelectedItem.ToString();
            ComboBox cbb = (ComboBox)sender;
            cbb.ForeColor = Color.White;
            if (level == "Nhẹ")
            {
                cbb.BackColor = Color.Yellow;
                tbFine.Text = "50000";
                tbFine.Enabled = false;
            }
            else if (level == "Vừa")
            {
                cbb.BackColor = Color.Orange;
                tbFine.Text = "100000";
                tbFine.Enabled = false;
            }
            else if (level == "Nặng")
            {
                cbb.BackColor = Color.Red;
                tbFine.Text = "200000";
                tbFine.Enabled = false;
            }
            else if (level == "Cực nặng")
            {
                tbFine.Clear();
                cbb.BackColor = Color.Purple;
                tbFine.Enabled = true;
            }
            else
            {
                cbb.ForeColor = Color.Black;
                cbb.BackColor = Color.White;
            }
        }

        private void tbFine_Leave_1(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(tbFine.Text);
                if (cbbLevel.BackColor == Color.Purple)
                {
                    if ( tmp < 300000 || tmp > 10000000)
                    {
                        MessageBox.Show("Vui lòng nhập số phạt lớn hơn 300 nghìn và nhỏ hơn 10 triệu", "Thông báo");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số nguyên", "Thông báo");
            }
        }
    }
}