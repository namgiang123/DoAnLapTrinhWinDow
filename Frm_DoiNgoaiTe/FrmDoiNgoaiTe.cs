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
    public partial class FrmDoiNgoaiTe : Form
    {
        public FrmDoiNgoaiTe()
        {
            InitializeComponent();
        }
        private void cmbLoaiNT_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbLoaiNT.Text)
            {
                case "USD":
                    txtTyGia.Text = "23567";
                    break;
                case "EUR":
                    txtTyGia.Text = "26785";
                    break;
            }
        }
        private void txtQuocTich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9') e.Handled = true;
        }
        private void txtSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }
        private void txtSoTienNT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') e.Handled = true;
        }

        private void FrmDoiNgoaiTe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn thoát chương trình??", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (tb == DialogResult.Cancel) e.Cancel = true;
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (cmbLoaiNT.SelectedItem =="USD")
            {
                txtSoTien.Text = (Int32.Parse(txtTyGia.Text) * Int32.Parse(txtSoTienNT.Text)).ToString();
            }
            if (cmbLoaiNT.SelectedItem == "EUR")
            {
                txtSoTien.Text = (Int32.Parse(txtTyGia.Text) * Int32.Parse(txtSoTienNT.Text)).ToString();
            }
            btnLuu.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtTenKH.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên khách hàng");
                txtTenKH.Focus();
                return;
            }
            if (txtQuocTich.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập quốc tịch khách hàng");
                txtQuocTich.Focus();
                return;
            }
            if (txtSoDT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại khách hàng");
                txtSoDT.Focus();
                return;
            }
            if (txtSoDT.TextLength == 0)
            {
                MessageBox.Show("Vui lòng nhập số tiền ngoại tệ muốn đổi");
                txtSoDT.Focus();
                return;
            }
            ListViewItem Dong;
            Dong = new ListViewItem(txtTenKH.Text);
            Dong.SubItems.Add(txtQuocTich.Text);
            Dong.SubItems.Add(txtSoDT.Text);
            Dong.SubItems.Add(cmbLoaiNT.Text);
            Dong.SubItems.Add(txtTyGia.Text);
            Dong.SubItems.Add(txtSoTienNT.Text);
            Dong.SubItems.Add(txtSoTien.Text);
            listview_DSKH.Items.Add(Dong);
            txtTenKH.Focus();
            btnLuu.Enabled = false;
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listview_DSKH.SelectedIndices.Count > 0)
            {
                DialogResult tb = MessageBox.Show("Bạn có muốn xoá dữ liệu này không??", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (tb == DialogResult.OK)
                    while (listview_DSKH.SelectedIndices.Count > 0) listview_DSKH.Items.RemoveAt(listview_DSKH.SelectedIndices[0]);
                listview_DSKH.SelectedIndices.Clear();
                btnThemMoi_Click(sender, e);
                return;
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtTenKH.Clear();
            txtQuocTich.Clear();
            txtSoDT.Clear();
            txtSoTienNT.Clear();
            cmbLoaiNT.Text = "Chọn";
            btnLuu.Enabled = false;
            btnTinh.Enabled = true;
        }
        private void FrmDoiNgoaiTe_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
        }
        private void listview_DSKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                txtTenKH.Text = listview_DSKH.FocusedItem.SubItems[0].Text;
                txtSoDT.Text = listview_DSKH.FocusedItem.SubItems[2].Text;
                txtQuocTich.Text = listview_DSKH.FocusedItem.SubItems[1].Text;
                txtSoTienNT.Text = listview_DSKH.FocusedItem.SubItems[3].Text;
                cmbLoaiNT.Text = listview_DSKH.FocusedItem.SubItems[4].Text;
                txtTyGia.Text = listview_DSKH.FocusedItem.SubItems[5].Text;
                txtSoTien.Text = listview_DSKH.FocusedItem.SubItems[6].Text;
            }
            btnTinh.Enabled = false;
            btnLuu.Enabled = false;
        }
    }
}
