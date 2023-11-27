using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_DangNhap_Dangky_QMK
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label1.Text = "";
        }

        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox2.Text;
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string query = "SELECT * FROM NguoiDung WHERE Email ='" + email + "'";
                if(modify.TaiKhoans(query).Count != 0)
                {
                    label1.ForeColor = Color.Blue;
                    label1.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].Matkhau;
                }
                else
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Email này chưa được đăng ký";
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }
    }
}
