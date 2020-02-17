using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhanNhatNamGiang_17C1_THU1
{
    public partial class Frm_QuanLyVang : Form
    {
        public Frm_QuanLyVang()
        {
            InitializeComponent();
        }

        private void cmb_LoaiVang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_LoaiVang.Text)
            {
                case "9999":
                    txt_GiaBan.Text = "3656000";
                    txt_GiaMua.Text = "3644000";
                    break;

                case "24K":
                    txt_GiaBan.Text = "3616000";
                    txt_GiaMua.Text = "3604000";
                    break;
                case "18K":
                    txt_GiaBan.Text = "2653000";
                    txt_GiaMua.Text = "2513000";
                    break;
            }
        }
        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            txt_HoTenKH.Clear();
            txt_NamSinh.Clear();
            txt_SDT.Clear();
            number_SoLuong.Value = 0;
            cmb_LoaiVang.Text = "Chọn";
            txt_GiaMua.Clear();
            txt_GiaBan.Clear();
            btn_Luu.Enabled = false;
            btn_Tinh.Enabled = true;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (listview_DSKH.SelectedIndices.Count > 0)
            {
                DialogResult tb = MessageBox.Show("Bạn có muốn xoá dữ liệu này không??", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                    while (listview_DSKH.SelectedIndices.Count > 0) listview_DSKH.Items.RemoveAt(listview_DSKH.SelectedIndices[0]);
                listview_DSKH.SelectedIndices.Clear();
                btn_ThemMoi_Click(sender, e);
                return;
            }
        }
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (txt_HoTenKH.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng");
                txt_HoTenKH.Focus();
                return;
            }
            if (txt_NamSinh.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập năm sinh khách hàng");
                txt_NamSinh.Focus();
                return;
            }
            if (txt_SDT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                txt_SDT.Focus();
                return;
            }
            ListViewItem Dong;
            Dong = new ListViewItem(txt_HoTenKH.Text);
            Dong.SubItems.Add(txt_NamSinh.Text);
            Dong.SubItems.Add(rad_Nam.Checked ? "Nam" : "Nữ");
            Dong.SubItems.Add(txt_SDT.Text);
            Dong.SubItems.Add(number_SoLuong.Value.ToString());
            Dong.SubItems.Add(cmb_LoaiVang.Text);
            Dong.SubItems.Add(rad_Mua.Checked ? "Mua" : "Bán");
            Dong.SubItems.Add(rad_Mua.Checked ? txt_GiaBan.Text : txt_GiaMua.Text);
            Dong.SubItems.Add(txt_TongTien.Text);
            listview_DSKH.Items.Add(Dong);
            txt_HoTenKH.Focus();
            btn_Luu.Enabled = false;
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {
            if (rad_Mua.Checked = true)
            {
                txt_TongTien.Text = (Int32.Parse(txt_GiaMua.Text) * number_SoLuong.Value).ToString();
            }
            else
            {
                txt_TongTien.Text = (Int32.Parse(txt_GiaBan.Text) * number_SoLuong.Value).ToString();
            }
            btn_Luu.Enabled = true;
        }
        private void txt_HoTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') e.Handled = true;
        }
        private void txt_NamSinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void menu_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Frm_QuanLyVang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát chương trình??", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.Cancel) e.Cancel = true;
        }

        private void Frm_QuanLyVang_Load(object sender, EventArgs e)
        {
            btn_Luu.Enabled = false;
        }

        private void listview_DSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                txt_HoTenKH.Text = listview_DSKH.FocusedItem.SubItems[0].Text;
                txt_NamSinh.Text = listview_DSKH.FocusedItem.SubItems[1].Text;
                rad_Nam.Checked = listview_DSKH.FocusedItem.SubItems[2].Text == "Nam" ? true : false;
                rad_Nu.Checked = !rad_Nam.Checked;
                txt_SDT.Text = listview_DSKH.FocusedItem.SubItems[3].Text;
                number_SoLuong.Value=int.Parse(listview_DSKH.FocusedItem.SubItems[4].Text);
                cmb_LoaiVang.Text = listview_DSKH.FocusedItem.SubItems[5].Text;
                rad_Mua.Checked = listview_DSKH.FocusedItem.SubItems[6].Text == "Mua" ? true : false;
                rad_Ban.Checked = !rad_Mua.Checked;
                txt_TongTien.Text = listview_DSKH.FocusedItem.SubItems[8].Text;
            }
            btn_Tinh.Enabled = false;
            btn_Luu.Enabled = false;
        }

    }
}
