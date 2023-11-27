namespace Form_DangNhap_Dangky_QMK
{
    partial class ThemSuaXoaPH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemSuaXoaPH));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView_Phong = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Khoitao = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sua = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.comboBox_Tang = new System.Windows.Forms.ComboBox();
            this.comboBox_TinhTrang = new System.Windows.Forms.ComboBox();
            this.comboBox_IDPhong = new System.Windows.Forms.ComboBox();
            this.comboBox_IDDayPhong = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_IDGiaoVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TenPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView_Phong);
            this.groupBox1.Location = new System.Drawing.Point(326, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 347);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // dataGridView_Phong
            // 
            this.dataGridView_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Phong.Location = new System.Drawing.Point(16, 22);
            this.dataGridView_Phong.Name = "dataGridView_Phong";
            this.dataGridView_Phong.RowTemplate.Height = 25;
            this.dataGridView_Phong.Size = new System.Drawing.Size(317, 316);
            this.dataGridView_Phong.TabIndex = 0;
            this.dataGridView_Phong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Phong_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Khoitao);
            this.groupBox2.Controls.Add(this.button_Xoa);
            this.groupBox2.Controls.Add(this.button_Sua);
            this.groupBox2.Controls.Add(this.button_Them);
            this.groupBox2.Controls.Add(this.comboBox_Tang);
            this.groupBox2.Controls.Add(this.comboBox_TinhTrang);
            this.groupBox2.Controls.Add(this.comboBox_IDPhong);
            this.groupBox2.Controls.Add(this.comboBox_IDDayPhong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_IDGiaoVien);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_TenPhong);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cụ thể";
            // 
            // button_Khoitao
            // 
            this.button_Khoitao.Location = new System.Drawing.Point(106, 315);
            this.button_Khoitao.Name = "button_Khoitao";
            this.button_Khoitao.Size = new System.Drawing.Size(75, 23);
            this.button_Khoitao.TabIndex = 3;
            this.button_Khoitao.Text = "Khởi tạo";
            this.button_Khoitao.UseVisualStyleBackColor = true;
            this.button_Khoitao.Click += new System.EventHandler(this.button_Khoitao_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.Location = new System.Drawing.Point(187, 276);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(75, 23);
            this.button_Xoa.TabIndex = 3;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // button_Sua
            // 
            this.button_Sua.Location = new System.Drawing.Point(106, 276);
            this.button_Sua.Name = "button_Sua";
            this.button_Sua.Size = new System.Drawing.Size(75, 23);
            this.button_Sua.TabIndex = 3;
            this.button_Sua.Text = "Sửa";
            this.button_Sua.UseVisualStyleBackColor = true;
            this.button_Sua.Click += new System.EventHandler(this.button_Sua_Click);
            // 
            // button_Them
            // 
            this.button_Them.Location = new System.Drawing.Point(25, 276);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(75, 23);
            this.button_Them.TabIndex = 3;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // comboBox_Tang
            // 
            this.comboBox_Tang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tang.FormattingEnabled = true;
            this.comboBox_Tang.IntegralHeight = false;
            this.comboBox_Tang.Items.AddRange(new object[] {
            "1         ",
            "2         ",
            "3         ",
            "4",
            "                      "});
            this.comboBox_Tang.Location = new System.Drawing.Point(143, 105);
            this.comboBox_Tang.Name = "comboBox_Tang";
            this.comboBox_Tang.Size = new System.Drawing.Size(100, 23);
            this.comboBox_Tang.TabIndex = 2;
            // 
            // comboBox_TinhTrang
            // 
            this.comboBox_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TinhTrang.FormattingEnabled = true;
            this.comboBox_TinhTrang.IntegralHeight = false;
            this.comboBox_TinhTrang.Items.AddRange(new object[] {
            "TOT       ",
            "HONG      "});
            this.comboBox_TinhTrang.Location = new System.Drawing.Point(143, 147);
            this.comboBox_TinhTrang.Name = "comboBox_TinhTrang";
            this.comboBox_TinhTrang.Size = new System.Drawing.Size(100, 23);
            this.comboBox_TinhTrang.TabIndex = 2;
            // 
            // comboBox_IDPhong
            // 
            this.comboBox_IDPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_IDPhong.FormattingEnabled = true;
            this.comboBox_IDPhong.IntegralHeight = false;
            this.comboBox_IDPhong.Items.AddRange(new object[] {
            "PA1       ",
            "PA2       ",
            "PA3       ",
            "PA4       ",
            "PB        ",
            "PC        ",
            "PC1       ",
            "PC2       ",
            "PD        ",
            "PE1       ",
            "PE2       ",
            "PE3       ",
            "PF1       ",
            "PF2       ",
            "PF3       ",
            "PG        ",
            "PH1       ",
            "PHT       ",
            "PI1       ",
            "PI2       ",
            "PI3       ",
            "PI4       ",
            "PI5       "});
            this.comboBox_IDPhong.Location = new System.Drawing.Point(143, 22);
            this.comboBox_IDPhong.Name = "comboBox_IDPhong";
            this.comboBox_IDPhong.Size = new System.Drawing.Size(100, 23);
            this.comboBox_IDPhong.TabIndex = 2;
            // 
            // comboBox_IDDayPhong
            // 
            this.comboBox_IDDayPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_IDDayPhong.FormattingEnabled = true;
            this.comboBox_IDDayPhong.IntegralHeight = false;
            this.comboBox_IDDayPhong.Items.AddRange(new object[] {
            "DPA1      ",
            "DPA2      ",
            "DPA3      ",
            "DPA4      ",
            "DPB       ",
            "DPC       ",
            "DPC1      ",
            "DPC2      ",
            "DPD       ",
            "DPE1      ",
            "DPE2      ",
            "DPE3      ",
            "DPF1      ",
            "DPF2      ",
            "DPF3      ",
            "DPG       ",
            "DPH1      ",
            "DPHT      ",
            "DPI1      ",
            "DPI2      ",
            "DPI3      ",
            "DPI4      "});
            this.comboBox_IDDayPhong.Location = new System.Drawing.Point(143, 61);
            this.comboBox_IDDayPhong.Name = "comboBox_IDDayPhong";
            this.comboBox_IDDayPhong.Size = new System.Drawing.Size(100, 23);
            this.comboBox_IDDayPhong.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "ID Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID Dãy Phòng:";
            // 
            // textBox_IDGiaoVien
            // 
            this.textBox_IDGiaoVien.Location = new System.Drawing.Point(143, 188);
            this.textBox_IDGiaoVien.Name = "textBox_IDGiaoVien";
            this.textBox_IDGiaoVien.Size = new System.Drawing.Size(100, 23);
            this.textBox_IDGiaoVien.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Giáo Viên:";
            // 
            // textBox_TenPhong
            // 
            this.textBox_TenPhong.Location = new System.Drawing.Point(143, 230);
            this.textBox_TenPhong.Name = "textBox_TenPhong";
            this.textBox_TenPhong.Size = new System.Drawing.Size(100, 23);
            this.textBox_TenPhong.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tầng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình Trạng:";
            // 
            // ThemSuaXoaPH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemSuaXoaPH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật phòng học";
            this.Load += new System.EventHandler(this.ThemSuaXoaPH_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Phong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView_Phong;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private TextBox textBox_IDGiaoVien;
        private Label label4;
        private TextBox textBox_TenPhong;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_Tang;
        private ComboBox comboBox_TinhTrang;
        private ComboBox comboBox_IDPhong;
        private ComboBox comboBox_IDDayPhong;
        private Button button_Khoitao;
        private Button button_Xoa;
        private Button button_Sua;
        private Button button_Them;
    }
}