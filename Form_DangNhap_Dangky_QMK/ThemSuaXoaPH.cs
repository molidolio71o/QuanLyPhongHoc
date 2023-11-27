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
    public partial class ThemSuaXoaPH : Form
    {
        SqlCommand command;
        SqlConnection connection;
        string str = @"Data Source=LAPTOP-PP2SQ4N0\MSSQLSERVER01;Initial Catalog=QL_PH;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Phong";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView_Phong.DataSource=table;
        }
        public ThemSuaXoaPH()
        {
            InitializeComponent();
        }
        
        private void dataGridView_Phong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView_Phong.CurrentRow.Index;
            comboBox_IDPhong.Text = dataGridView_Phong.Rows[i].Cells[0].Value.ToString();
            comboBox_IDDayPhong.Text = dataGridView_Phong.Rows[i].Cells[1].Value.ToString();
            comboBox_Tang.Text = dataGridView_Phong.Rows[i].Cells[4].Value.ToString();
            comboBox_TinhTrang.Text = dataGridView_Phong.Rows[i].Cells[5].Value.ToString();
            textBox_IDGiaoVien.Text = dataGridView_Phong.Rows[i].Cells[2].Value.ToString();
            textBox_TenPhong.Text = dataGridView_Phong.Rows[i].Cells[3].Value.ToString();
        }

        private void ThemSuaXoaPH_Load(object sender, EventArgs e)
        {
        
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            if (textBox_IDGiaoVien.Text == "" || comboBox_IDPhong.Text == "" || comboBox_IDDayPhong.Text =="" || textBox_TenPhong.Text == "" || comboBox_Tang.Text == "" || comboBox_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "insert into Phong values('" + comboBox_IDPhong.Text + "','" + comboBox_IDDayPhong.Text + "','" + textBox_IDGiaoVien.Text + "','" + textBox_TenPhong.Text + "','" + comboBox_Tang.Text + "','" + comboBox_TinhTrang.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Đã thêm dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_IDGiaoVien.Text == "" || comboBox_IDPhong.Text == "" || comboBox_IDDayPhong.Text == "" || textBox_TenPhong.Text == "" || comboBox_Tang.Text == "" || comboBox_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "delete from Phong where IDP= '"+comboBox_IDPhong.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Đã xóa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            if (textBox_IDGiaoVien.Text == "" || comboBox_IDPhong.Text == "" || comboBox_IDDayPhong.Text == "" || textBox_TenPhong.Text == "" || comboBox_Tang.Text == "" || comboBox_TinhTrang.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            command = connection.CreateCommand();
            command.CommandText = "update Phong set IDDP = '"+comboBox_IDDayPhong.Text+"', IDGV = '"+textBox_IDGiaoVien.Text+"', TenPhong= '"+textBox_TenPhong.Text+"', Tang = '"+comboBox_Tang.Text+"', TinhTrang = '"+comboBox_TinhTrang.Text+"' where IDP = '"+comboBox_IDPhong.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
            MessageBox.Show("Đã sữa dữ liệu được chọn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button_Khoitao_Click(object sender, EventArgs e)
        {
            comboBox_IDDayPhong.Text = null;
            comboBox_IDPhong.Text = null;
            comboBox_Tang.Text = null;
            comboBox_TinhTrang.Text = null;
            textBox_IDGiaoVien.Clear();
            textBox_TenPhong.Clear();
        }
    }
}
