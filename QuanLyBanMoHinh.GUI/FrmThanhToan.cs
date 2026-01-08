using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanMoHinh.BLL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.GUI
{
    public partial class FrmThanhToan : Form
    {
        private ThanhToanBLL bll = new ThanhToanBLL();

        public FrmThanhToan()
        {
            InitializeComponent();
        }

        private void FrmThanhToan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = bll.GetAll();
            if (dgvData.Columns["MaTT"] != null) dgvData.Columns["MaTT"].HeaderText = "Mã phương thức";
            if (dgvData.Columns["PhuongThuc"] != null) dgvData.Columns["PhuongThuc"].HeaderText = "Tên phương thức";
            if (dgvData.Columns["MaDon"] != null) dgvData.Columns["MaDon"].Visible = false;
            if (dgvData.Columns["TrangThai"] != null) dgvData.Columns["TrangThai"].Visible = false;
            if (dgvData.Columns["DonBan"] != null) dgvData.Columns["DonBan"].Visible = false;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvData.Rows[e.RowIndex];
                txtMaTT.Text = row.Cells["MaTT"].Value.ToString();
                txtPhuongThuc.Text = row.Cells["PhuongThuc"].Value?.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhuongThuc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phương thức thanh toán!");
                return;
            }

            try
            {
                var item = new ThanhToan { PhuongThuc = txtPhuongThuc.Text };
                bll.Add(item);
                MessageBox.Show("Thêm thành công!");
                LoadData();
                ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaTT.Text))
            {
                MessageBox.Show("Vui lòng chọn phương thức cần sửa!");
                return;
            }

            try
            {
                var item = new ThanhToan 
                { 
                    MaTT = int.Parse(txtMaTT.Text),
                    PhuongThuc = txtPhuongThuc.Text 
                };
                bll.Update(item);
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;
            int id = (int)dgvData.CurrentRow.Cells["MaTT"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa phương thức thanh toán này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    bll.Delete(id);
                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
                    ResetInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadData();
        }

        private void ResetInput()
        {
            txtMaTT.Clear();
            txtPhuongThuc.Clear();
        }
    }
}
