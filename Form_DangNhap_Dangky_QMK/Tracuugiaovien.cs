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
    public partial class Tracuugiaovien : Form
    {
        public Tracuugiaovien()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void button_gv_Click(object sender, EventArgs e)
        {
            string gv = textBox_GV.Text;
            string demo = textBox_GV.Text;
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-PP2SQ4N0\MSSQLSERVER01;Initial Catalog=QL_PH;Integrated Security=True");
            try
            {
                string query = "SELECT DISTINCT HoTen,TenDP,TenPhong,TenLP FROM PHONG, GV, DAYPHONG , LoaiPhong WHERE GV.IDGV = PHONG.IDGV AND PHONG.IDDP = DayPhong.IDDP AND Phong.IDDP = LoaiPhong.IDDP AND gv.IDGV = '" + gv + "'";
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
       
            if (gv.Trim() == "")
            {
                MessageBox.Show("Mã giáo viên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("select * from GV where IDGV = '" + gv + "'").Count() != 1)
            {
                MessageBox.Show("Không có mã giáo viên này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_GV.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void traCứuGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
