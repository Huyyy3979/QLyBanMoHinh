using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanMoHinh.BLL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.GUI
{
    public partial class FrmHangSanXuat : Form
    {
        private HangSanXuatBLL bll = new HangSanXuatBLL();
        private bool isAdding = false;

        public FrmHangSanXuat()
        {
            InitializeComponent();
        }

        private void FrmHangSanXuat_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetInput();
        }

        private void LoadData()
        {
            dgvHang.DataSource = bll.GetAll();
            if (dgvHang.Columns["Gundams"] != null) dgvHang.Columns["Gundams"].Visible = false;
        }

        private void ResetInput()
        {
            txtTenHang.Text = "";
            pnlInput.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            isAdding = false;
        }

        private void ShowInput(bool show)
        {
            pnlInput.Enabled = show;
            btnLuu.Enabled = show;
            btnHuy.Enabled = show;
            btnThem.Enabled = !show;
            btnSua.Enabled = !show;
            btnXoa.Enabled = !show;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetInput();
            ShowInput(true);
            txtTenHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHang.CurrentRow == null) return;
            isAdding = false;
            ShowInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHang.CurrentRow == null) return;
            var id = (int)dgvHang.CurrentRow.Cells["MaHang"].Value;

            if (bll.HasDependents(id))
            {
                MessageBox.Show("Không thể xóa hãng này vì đang có sản phẩm thuộc hãng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.Delete(id);
                LoadData();
                ResetInput();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text)) return;

            var hang = new HangSanXuat { TenHang = txtTenHang.Text };

            if (isAdding) bll.Add(hang);
            else
            {
                hang.MaHang = (int)dgvHang.CurrentRow.Cells["MaHang"].Value;
                bll.Update(hang);
            }

            LoadData();
            ResetInput();
        }

        private void btnHuy_Click(object sender, EventArgs e) => ResetInput();

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenHang.Text = dgvHang.Rows[e.RowIndex].Cells["TenHang"].Value?.ToString();
            }
        }
    }
}
