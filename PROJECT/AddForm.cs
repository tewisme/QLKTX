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
    public partial class AddForm : Form
    {
        Management F1 = null;
        string Gender = "Nam";
        public AddForm(string IDRoom, string cGender, Management MT)
        {
            InitializeComponent();
            F1 = MT;
            Gender = cGender;
            if (Gender == "Nam") rbMale.Checked = true;
            else rbFemale.Checked = true;
            tbRoom.ReadOnly = false;
            tbRoom.Text = IDRoom;
            tbRoom.ReadOnly = true;
        }
        string connString = "Data Source=.; Initial Catalog=QLKTX; Integrated Security=True; TrustServerCertificate=True";
        private void btnAdd_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.CadetBlue;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkTurquoise;
        }

        private void btnCancel_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.OrangeRed;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.DarkSalmon;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ID = tbIdStudent.Text;
            string IDRoom = tbRoom.Text;
            string Name = tbNameStudent.Text;
            DateTime CheckIn = dtpCheckIn.Value;
            if (ID == "" || IDRoom == "" || Name == "" || Gender == "" || CheckIn == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string sqlUpdate = "INSERT INTO Students (ID, IDRoom, FullName, Gender, DateIn, Fine) " +
                                    "Values (@id, @idroom, @fullname, @gender, @checkin, @fine)";
                SqlCommand cmd = new SqlCommand(sqlUpdate, conn);
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.Parameters.AddWithValue("@idroom", IDRoom);
                cmd.Parameters.AddWithValue("@fullname", Name);
                cmd.Parameters.AddWithValue("@gender", Gender);
                cmd.Parameters.AddWithValue("@checkin", CheckIn);
                cmd.Parameters.AddWithValue("@fine", 0);
                int res = cmd.ExecuteNonQuery();
                if ( res > 0 )
                {
                    MessageBox.Show("Đã thêm sinh viên thành công", "Thông báo");
                    F1.LoadData();
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Nam";
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Nữ";
        }

    }
}