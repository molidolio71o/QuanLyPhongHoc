using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_DangNhap_Dangky_QMK
{
    public partial class XemThietBi : Form
    {
        public XemThietBi()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();

        private void button_tracuu_Click(object sender, EventArgs e)
        {
            string tenphong = textBox_TenPhong.Text;
            string demo = textBox_TenPhong.Text;
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-PP2SQ4N0\MSSQLSERVER01;Initial Catalog=QL_PH;Integrated Security=True");
            try
            {
                string query = "Select * from Phong,ThietBi where phong.IDP = ThietBi.IDP and TenPhong ='" + tenphong + "'";
                modify.Command(query);
                SqlCommand com = new SqlCommand(query, cnn);
                com.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cnn.Close();
                dataGridView1.DataSource = dt;

            }
            catch
            {
                MessageBox.Show("Error");
            }
            if (tenphong.Trim() == "")
            {
                MessageBox.Show("Tên phòng không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from Phong,ThietBi where phong.IDP = ThietBi.IDP and TenPhong ='" + tenphong + "'").Count() != 1)
            {
                MessageBox.Show("Không có tên phòng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[7].Value.ToString();
                textBox2.Text = row.Cells[0].Value.ToString();
                textBox3.Text = row.Cells[8].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_TenPhong.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemThietBi_Load(object sender, EventArgs e)
        {

        }
    }
}
