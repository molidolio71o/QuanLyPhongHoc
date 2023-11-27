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
    public partial class ListID : Form
    {
        public ListID()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void ketnoicsld()
        {
            SqlConnection cnn = new SqlConnection(@"Data Source=LAPTOP-PP2SQ4N0\MSSQLSERVER01;Initial Catalog=QL_PH;Integrated Security=True");
            string query = "SELECT ID FROM NguoiDung";
            modify.Command(query);
            SqlCommand com = new SqlCommand(query, cnn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            dataGridView_ID.DataSource = dt;
        }

        private void ListID_Load(object sender, EventArgs e)
        {
            ketnoicsld();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
