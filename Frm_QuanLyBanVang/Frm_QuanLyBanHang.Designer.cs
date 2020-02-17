namespace PhanNhatNamGiang_17C1_THU1
{
    partial class Frm_QuanLyVang
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hoàng Hữu Nam",
            "1973",
            "Nam",
            "0931666186",
            "3",
            "9999",
            "Bán",
            "3656000",
            "10968000"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Hari Won",
            "1985",
            "Nữ",
            "0933567476",
            "6",
            "18K",
            "Mua",
            "2513000",
            "15078000"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Trần Tiểu Vi",
            "1985",
            "Nam",
            "0933666666",
            "10",
            "24K",
            "Mua",
            "3604000",
            "36040000"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_QuanLyVang));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NamSinh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rad_Nu = new System.Windows.Forms.RadioButton();
            this.rad_Nam = new System.Windows.Forms.RadioButton();
            this.txt_HoTenKH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.number_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rad_Ban = new System.Windows.Forms.RadioButton();
            this.rad_Mua = new System.Windows.Forms.RadioButton();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_GiaMua = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_LoaiVang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btn_ThemMoi = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.listview_DSKH = new System.Windows.Forms.ListView();
            this.HoTenKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NamSinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loaivang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.muaban = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaVND = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TongTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_SoLuong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Thoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu_Thoat
            // 
            this.menu_Thoat.Image = global::PhanNhatNamGiang_17C1_THU1.Properties.Resources.turn_off;
            this.menu_Thoat.Name = "menu_Thoat";
            this.menu_Thoat.Size = new System.Drawing.Size(66, 20);
            this.menu_Thoat.Text = "Thoát";
            this.menu_Thoat.Click += new System.EventHandler(this.menu_Thoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(163, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ MUA BÁN VÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_NamSinh);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txt_HoTenKH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(38, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(263, 58);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(148, 20);
            this.txt_SDT.TabIndex = 7;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại:";
            // 
            // txt_NamSinh
            // 
            this.txt_NamSinh.Location = new System.Drawing.Point(77, 58);
            this.txt_NamSinh.Name = "txt_NamSinh";
            this.txt_NamSinh.Size = new System.Drawing.Size(79, 20);
            this.txt_NamSinh.TabIndex = 5;
            this.txt_NamSinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NamSinh_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Năm sinh:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rad_Nu);
            this.groupBox3.Controls.Add(this.rad_Nam);
            this.groupBox3.Location = new System.Drawing.Point(433, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(163, 45);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phái";
            // 
            // rad_Nu
            // 
            this.rad_Nu.AutoSize = true;
            this.rad_Nu.Location = new System.Drawing.Point(105, 19);
            this.rad_Nu.Name = "rad_Nu";
            this.rad_Nu.Size = new System.Drawing.Size(39, 17);
            this.rad_Nu.TabIndex = 1;
            this.rad_Nu.TabStop = true;
            this.rad_Nu.Text = "Nữ";
            this.rad_Nu.UseVisualStyleBackColor = true;
            // 
            // rad_Nam
            // 
            this.rad_Nam.AutoSize = true;
            this.rad_Nam.Location = new System.Drawing.Point(23, 19);
            this.rad_Nam.Name = "rad_Nam";
            this.rad_Nam.Size = new System.Drawing.Size(47, 17);
            this.rad_Nam.TabIndex = 0;
            this.rad_Nam.TabStop = true;
            this.rad_Nam.Text = "Nam";
            this.rad_Nam.UseVisualStyleBackColor = true;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Location = new System.Drawing.Point(120, 25);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.Size = new System.Drawing.Size(291, 20);
            this.txt_HoTenKH.TabIndex = 2;
            this.txt_HoTenKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_HoTenKH_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_TongTien);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.number_SoLuong);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txt_GiaBan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_GiaMua);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmb_LoaiVang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sử dụng dịch vụ ngoại tệ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(421, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "VNĐ";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(267, 91);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(148, 20);
            this.txt_TongTien.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(211, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Tổng tiền:";
            // 
            // number_SoLuong
            // 
            this.number_SoLuong.Location = new System.Drawing.Point(62, 40);
            this.number_SoLuong.Name = "number_SoLuong";
            this.number_SoLuong.Size = new System.Drawing.Size(63, 20);
            this.number_SoLuong.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rad_Ban);
            this.groupBox4.Controls.Add(this.rad_Mua);
            this.groupBox4.Location = new System.Drawing.Point(15, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(176, 45);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mua/Bán";
            // 
            // rad_Ban
            // 
            this.rad_Ban.AutoSize = true;
            this.rad_Ban.Location = new System.Drawing.Point(109, 19);
            this.rad_Ban.Name = "rad_Ban";
            this.rad_Ban.Size = new System.Drawing.Size(44, 17);
            this.rad_Ban.TabIndex = 1;
            this.rad_Ban.TabStop = true;
            this.rad_Ban.Text = "Bán";
            this.rad_Ban.UseVisualStyleBackColor = true;
            // 
            // rad_Mua
            // 
            this.rad_Mua.AutoSize = true;
            this.rad_Mua.Location = new System.Drawing.Point(23, 19);
            this.rad_Mua.Name = "rad_Mua";
            this.rad_Mua.Size = new System.Drawing.Size(46, 17);
            this.rad_Mua.TabIndex = 0;
            this.rad_Mua.TabStop = true;
            this.rad_Mua.Text = "Mua";
            this.rad_Mua.UseVisualStyleBackColor = true;
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(533, 40);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.ReadOnly = true;
            this.txt_GiaBan.Size = new System.Drawing.Size(79, 20);
            this.txt_GiaBan.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(478, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Giá bán:";
            // 
            // txt_GiaMua
            // 
            this.txt_GiaMua.Location = new System.Drawing.Point(383, 40);
            this.txt_GiaMua.Name = "txt_GiaMua";
            this.txt_GiaMua.ReadOnly = true;
            this.txt_GiaMua.Size = new System.Drawing.Size(79, 20);
            this.txt_GiaMua.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(328, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá mua:";
            // 
            // cmb_LoaiVang
            // 
            this.cmb_LoaiVang.FormattingEnabled = true;
            this.cmb_LoaiVang.Items.AddRange(new object[] {
            "9999",
            "24K",
            "18K"});
            this.cmb_LoaiVang.Location = new System.Drawing.Point(239, 40);
            this.cmb_LoaiVang.Name = "cmb_LoaiVang";
            this.cmb_LoaiVang.Size = new System.Drawing.Size(68, 21);
            this.cmb_LoaiVang.TabIndex = 4;
            this.cmb_LoaiVang.Text = "Chọn";
            this.cmb_LoaiVang.SelectedIndexChanged += new System.EventHandler(this.cmb_LoaiVang_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Loại vàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số lượng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btn_ThemMoi);
            this.groupBox5.Controls.Add(this.btn_Luu);
            this.groupBox5.Controls.Add(this.btn_Xoa);
            this.groupBox5.Controls.Add(this.btn_Tinh);
            this.groupBox5.Location = new System.Drawing.Point(14, 280);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(682, 51);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Location = new System.Drawing.Point(537, 11);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(123, 34);
            this.btn_ThemMoi.TabIndex = 3;
            this.btn_ThemMoi.Text = "Thêm mới";
            this.btn_ThemMoi.UseVisualStyleBackColor = true;
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(189, 11);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(113, 34);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(361, 11);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(113, 34);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Location = new System.Drawing.Point(15, 11);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(113, 34);
            this.btn_Tinh.TabIndex = 0;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // listview_DSKH
            // 
            this.listview_DSKH.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoTenKH,
            this.NamSinh,
            this.Phai,
            this.SoDT,
            this.Soluong,
            this.loaivang,
            this.muaban,
            this.GiaVND,
            this.TongTien});
            this.listview_DSKH.FullRowSelect = true;
            this.listview_DSKH.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.listview_DSKH.Location = new System.Drawing.Point(14, 332);
            this.listview_DSKH.Name = "listview_DSKH";
            this.listview_DSKH.Size = new System.Drawing.Size(685, 95);
            this.listview_DSKH.TabIndex = 4;
            this.listview_DSKH.UseCompatibleStateImageBehavior = false;
            this.listview_DSKH.View = System.Windows.Forms.View.Details;
            this.listview_DSKH.SelectedIndexChanged += new System.EventHandler(this.listview_DSKH_SelectedIndexChanged);
            // 
            // HoTenKH
            // 
            this.HoTenKH.Text = "Họ Tên Khách Hàng";
            this.HoTenKH.Width = 108;
            // 
            // NamSinh
            // 
            this.NamSinh.Text = "Năm Sinh";
            this.NamSinh.Width = 62;
            // 
            // Phai
            // 
            this.Phai.Text = "Phái";
            this.Phai.Width = 48;
            // 
            // SoDT
            // 
            this.SoDT.Text = "Số ĐT";
            this.SoDT.Width = 79;
            // 
            // Soluong
            // 
            this.Soluong.Text = "Số lượng";
            this.Soluong.Width = 58;
            // 
            // loaivang
            // 
            this.loaivang.Text = "Loại vàng";
            this.loaivang.Width = 68;
            // 
            // muaban
            // 
            this.muaban.Text = "Mua/Bán";
            // 
            // GiaVND
            // 
            this.GiaVND.Text = "Giá VNĐ";
            this.GiaVND.Width = 88;
            // 
            // TongTien
            // 
            this.TongTien.Text = "Tổng tiền";
            this.TongTien.Width = 88;
            // 
            // Frm_QuanLyVang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 431);
            this.Controls.Add(this.listview_DSKH);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_QuanLyVang";
            this.Text = "Quản Lý Bán Vàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_QuanLyVang_FormClosing);
            this.Load += new System.EventHandler(this.Frm_QuanLyVang_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_SoLuong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu_Thoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_NamSinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rad_Nu;
        private System.Windows.Forms.RadioButton rad_Nam;
        private System.Windows.Forms.TextBox txt_HoTenKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_LoaiVang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rad_Ban;
        private System.Windows.Forms.RadioButton rad_Mua;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_GiaMua;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown number_SoLuong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btn_ThemMoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.ListView listview_DSKH;
        private System.Windows.Forms.ColumnHeader HoTenKH;
        private System.Windows.Forms.ColumnHeader NamSinh;
        private System.Windows.Forms.ColumnHeader Phai;
        private System.Windows.Forms.ColumnHeader SoDT;
        private System.Windows.Forms.ColumnHeader Soluong;
        private System.Windows.Forms.ColumnHeader loaivang;
        private System.Windows.Forms.ColumnHeader muaban;
        private System.Windows.Forms.ColumnHeader GiaVND;
        private System.Windows.Forms.ColumnHeader TongTien;
    }
}

