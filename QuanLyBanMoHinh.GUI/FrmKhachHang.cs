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
    public partial class FrmKhachHang : Form
    {
        private KhachHangBLL bll = new KhachHangBLL();

        public FrmKhachHang()
        {
            InitializeComponent();
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = bll.GetAll();
            FormatGrid();
        }

        private void FormatGrid()
        {
            if (dgvData.Columns["MaKH"] != null) dgvData.Columns["MaKH"].HeaderText = "Mã khách hàng";
            if (dgvData.Columns["TenKH"] != null) dgvData.Columns["TenKH"].HeaderText = "Tên khách hàng";
            if (dgvData.Columns["Email"] != null) dgvData.Columns["Email"].HeaderText = "Email";
            if (dgvData.Columns["MatKhau"] != null) dgvData.Columns["MatKhau"].HeaderText = "Mật khẩu";
            if (dgvData.Columns["DienThoai"] != null) dgvData.Columns["DienThoai"].HeaderText = "Số điện thoại";
            if (dgvData.Columns["DiaChi"] != null) dgvData.Columns["DiaChi"].HeaderText = "Địa chỉ";
            
            if (dgvData.Columns["NgayTao"] != null)
            {
                dgvData.Columns["NgayTao"].HeaderText = "Ngày tạo";
                dgvData.Columns["NgayTao"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss tt";
            }
            if (dgvData.Columns["NgayCapNhat"] != null)
            {
                dgvData.Columns["NgayCapNhat"].HeaderText = "Ngày cập nhật";
                dgvData.Columns["NgayCapNhat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss tt";
            }

            if (dgvData.Columns["LaVIP"] != null) dgvData.Columns["LaVIP"].Visible = false;
            if (dgvData.Columns["DonBans"] != null) dgvData.Columns["DonBans"].Visible = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var kh = new KhachHang
                {
                    TenKH = txtTenKH.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    DienThoai = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgayTao = DateTime.Now,
                    NgayCapNhat = DateTime.Now,
                    LaVIP = false
                };

                bll.Add(kh);
                MessageBox.Show("Thêm khách hàng thành công!");
                LoadData();
                btnLamMoi_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa!");
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                var kh = new KhachHang
                {
                    MaKH = int.Parse(txtMaKH.Text),
                    TenKH = txtTenKH.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = txtMatKhau.Text.Trim(),
                    DienThoai = txtSDT.Text.Trim(),
                    DiaChi = txtDiaChi.Text.Trim(),
                    NgayCapNhat = DateTime.Now,
                    LaVIP = false
                };

                bll.Update(kh);
                MessageBox.Show("Cập nhật khách hàng thành công!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string phone = txtSearchSDT.Text.Trim();
            if (string.IsNullOrEmpty(phone))
            {
                LoadData();
            }
            else
            {
                dgvData.DataSource = bll.SearchByPhone(phone);
                FormatGrid();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            txtDiaChi.Clear();
            txtNgayTao.Clear();
            txtNgayCapNhat.Clear();
            txtSearchSDT.Clear();
            LoadData();
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvData.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKH"].Value?.ToString();
                txtTenKH.Text = row.Cells["TenKH"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtMatKhau.Text = row.Cells["MatKhau"].Value?.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                
                if (row.Cells["NgayTao"].Value != null)
                    txtNgayTao.Text = ((DateTime)row.Cells["NgayTao"].Value).ToString("dd/MM/yyyy HH:mm:ss tt");
                else
                    txtNgayTao.Clear();

                if (row.Cells["NgayCapNhat"].Value != null)
                    txtNgayCapNhat.Text = ((DateTime)row.Cells["NgayCapNhat"].Value).ToString("dd/MM/yyyy HH:mm:ss tt");
                else
                    txtNgayCapNhat.Clear();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Họ tên khách hàng không được để trống!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống!");
                return false;
            }
            return true;
        }
    }
}
