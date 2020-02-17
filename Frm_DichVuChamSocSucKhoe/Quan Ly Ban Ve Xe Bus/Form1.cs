using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Ve_Xe_Bus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtTenKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') e.Handled = true;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void txtSoLuongVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void cmbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbKhachHang.Text)
            {
                case "Cá nhân":
                    txtDonGia.Text = "2500";
                    break;
                case "Trường":
                    txtDonGia.Text = "2000";
                    break;
            }
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn thoát chương trình..!!", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.Cancel) e.Cancel = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cmbKhachHang.SelectedItem == "Cá nhân")
            {
                txtTongTien.Text = (Int32.Parse(txtSoLuongVe.Text)*Int32.Parse(txtDonGia.Text)).ToString();
            }
            if (cmbKhachHang.SelectedItem == "Trường")
            {
                txtTongTien.Text = (Int32.Parse(txtSoLuongVe.Text)*Int32.Parse(txtDonGia.Text)).ToString();
            }
            btnLuu.Enabled = true;
        }

        private void listview_TTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                txtTenKH.Text = listview_TTKH.FocusedItem.SubItems[0].Text;
                txtSoDienThoai.Text = listview_TTKH.FocusedItem.SubItems[2].Text;
                txtDiaChi.Text = listview_TTKH.FocusedItem.SubItems[1].Text;
                cmbKhachHang.Text = listview_TTKH.FocusedItem.SubItems[3].Text;
                txtDonGia.Text = listview_TTKH.FocusedItem.SubItems[4].Text;
                txtSoLuongVe.Text = listview_TTKH.FocusedItem.SubItems[5].Text;
                txtTongTien.Text = listview_TTKH.FocusedItem.SubItems[6].Text;
            }
            btnTinh.Enabled = false;
            btnXoa.Enabled = true;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            cmbKhachHang.Text = "Chọn";
            txtDonGia.Clear();
            txtSoLuongVe.Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTenKH.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng");
                txtTenKH.Focus();
                return;
            }
            if (txtSoDienThoai.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                txtSoDienThoai.Focus();
                return;
            }
            if (txtDiaChi.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập địa chỉ khách hàng");
                txtDiaChi.Focus();
                return;
            }
            if (txtDonGia.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập đơn giá");
                txtDonGia.Focus();
                return;
            }
            if (txtSoLuongVe.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng vé");
                txtSoLuongVe.Focus();
                return;
            }
            ListViewItem Dong;
            Dong = new ListViewItem(txtTenKH.Text);
            Dong.SubItems.Add(txtSoDienThoai.Text);
            Dong.SubItems.Add(txtDiaChi.Text);
            Dong.SubItems.Add(cmbKhachHang.Text);
            Dong.SubItems.Add(txtDonGia.Text);
            Dong.SubItems.Add(txtSoLuongVe.Text);
            Dong.SubItems.Add(txtTongTien.Text);
            listview_TTKH.Items.Add(Dong);
            txtTenKH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listview_TTKH.SelectedIndices.Count > 0)
            {
                DialogResult tb = MessageBox.Show("Bạn xoá dữ liệu này?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                    while (listview_TTKH.SelectedIndices.Count > 0) listview_TTKH.Items.RemoveAt(listview_TTKH.SelectedIndices[0]);
                listview_TTKH.SelectedIndices.Clear();
                btnThemMoi_Click(sender, e);
                return;
            }
        }
    }
}
