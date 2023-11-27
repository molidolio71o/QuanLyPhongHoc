using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Form_DangNhap_Dangky_QMK
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, @"^[a-zA-z0-9]{3,24}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.,]{2,20}@gmail.com(.vn|)$");
        }
        public bool CheckID(string im)
        {
            return Regex.IsMatch(im, "^[a-zA-z_]{0,3}$");
        }
        Modify modify = new Modify();
        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            string myid = textBox_ID.Text;
            if (CheckID(myid))
            {
                MessageBox.Show("ID không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("SELECT * FROM NguoiDung Where ID = '" + myid + "'").Count() != 0)
            {
                MessageBox.Show("Đã có id này rồi! Vui lòng sử dụng id khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tentk.Trim() == "" || matkhau.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from NguoiDung where TaiKhoan = '" + tentk + "'").Count != 0)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, vui lòng đăng ký tên tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (matkhau != xnmatkhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("Select * from NguoiDung where Email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký Email khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string query = "INSERT INTO NguoiDung VALUES ('" + myid + "','" + tentk + "','" + matkhau + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Hide();
                    DangNhap dangNhap = new DangNhap();
                    dangNhap.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký!, vui lòng đăng ký tên tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myid = textBox_ID.Text;
            if (CheckID(myid))
            {
                MessageBox.Show("ID bắt buộc phải là chữ số và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("SELECT * FROM NguoiDung Where ID = '" + myid + "'").Count() != 0)
            {
                MessageBox.Show("Đã có id này rồi! Vui lòng sử dụng id khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (modify.TaiKhoans("SELECT * FROM NguoiDung Where ID = '" + myid + "'").Count() != 1)
            {
                MessageBox.Show("ID có thể sử dụng để đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListID listID = new ListID();
            listID.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
