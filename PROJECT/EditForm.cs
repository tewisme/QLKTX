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
                dt.Columns.Remove("IDStudents");
                dgvFines.DataSource = dt;
            }
        }
        private void EditForm_Load(object sender, EventArgs e)
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
            string IDFines = currentRow.Cells["IDFines"].Value.ToString();
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
                int tmp = Convert.ToInt32(tbFine.Text);
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
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}