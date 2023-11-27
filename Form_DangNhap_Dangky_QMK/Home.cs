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
    public partial class Home : Form
    {
        
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất?","Thông báo!",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Modify modify = new Modify();
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();
            }
        }

        private void traCuuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Tracuugiaovien tracuugiaovien = new Tracuugiaovien();
            tracuugiaovien.MdiParent = this;
            tracuugiaovien.Show();
            label_ThayDoi.Text = "Tra cứu giảng viên";
        }

        private void cậpNhậtPhòngHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            ThemSuaXoaPH themSuaXoaPH = new ThemSuaXoaPH();
            themSuaXoaPH.MdiParent = this;
            themSuaXoaPH.Show();
            label_ThayDoi.Text = "Tra cứu phòng học";
        }

        private void traCứuThiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            XemThietBi xemThietBi = new XemThietBi();
            xemThietBi.MdiParent = this;
            xemThietBi.Show();
            label_ThayDoi.Text = "Xem thiết bị";
        }
        int x = 170, y = 202, a = 1;
        Font LargeFont = new Font("Arial", 20, FontStyle.Bold);
        Font HoverFont = new Font("Segoe UI", 9, FontStyle.Bold);
        Font ResetFont = new Font("Segoe UI", 9,FontStyle.Regular);
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            label_ThayDoi.Text = "Trang chủ";
            Trangchu trangchu = new Trangchu();
            trangchu.MdiParent = this;
            trangchu.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Tracuugiaovien tracuugiaovien = new Tracuugiaovien();
            tracuugiaovien.MdiParent = this;
            tracuugiaovien.Show();
            label_ThayDoi.Text = "Tra cứu giảng viên";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            ThemSuaXoaPH themSuaXoaPH = new ThemSuaXoaPH();
            themSuaXoaPH.MdiParent = this;
            themSuaXoaPH.Show();
            label_ThayDoi.Text = "Tra cứu phòng học";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            XemThietBi xemThietBi = new XemThietBi();
            xemThietBi.MdiParent = this;
            xemThietBi.Show();
            label_ThayDoi.Text = "Xem thiết bị";
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            label_TrangChus.Font = HoverFont;
            label_TrangChus.ForeColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label_TrangChus.Font = ResetFont;
            label_TrangChus.ForeColor = Color.Black;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label_TraCuuGiangVien.Font = HoverFont;
            label_TraCuuGiangVien.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label_TraCuuGiangVien.Font = ResetFont;
            label_TraCuuGiangVien.ForeColor = Color.Black;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label_TraCuuPH.Font = HoverFont;
            label_TraCuuPH.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label_TraCuuPH.Font = ResetFont;
            label_TraCuuPH.ForeColor = Color.Black;
        }

        private void label_XemThietBi_MouseEnter(object sender, EventArgs e)
        {
            label_XemThietBi.Font = HoverFont;
            label_XemThietBi.ForeColor = Color.Red;
        }

        private void label_XemThietBi_MouseLeave(object sender, EventArgs e)
        {
            label_XemThietBi.Font = ResetFont;
            label_XemThietBi.ForeColor = Color.Black;
        }

        private void label_SoDoTDMU_MouseEnter(object sender, EventArgs e)
        {
            label_SoDoTDMU.Font = HoverFont;
            label_SoDoTDMU.ForeColor = Color.Red;
            pictureBox_SoDoTDMU.Visible = true;
            label_ThayDoi.Text = "Sơ đồ TDMU";   
        }

        private void label_SoDoTDMU_MouseLeave(object sender, EventArgs e)
        {
            label_SoDoTDMU.Font = HoverFont;
            label_SoDoTDMU.ForeColor = Color.Black;
            this.Controls.Clear();
            this.InitializeComponent();
            pictureBox_SoDoTDMU.Visible = false;
            label_ThayDoi.Text = "Quản lý phòng học - TDMU";
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label_ChayChu.Location = new Point(x, y);
                if(x >= 505)
                {
                    a = -1;
                    label_ChayChu.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if(x <= 167)
                {
                    a = 1;
                    label_ChayChu.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch (Exception ex)    
            { }
        }

    }
}
