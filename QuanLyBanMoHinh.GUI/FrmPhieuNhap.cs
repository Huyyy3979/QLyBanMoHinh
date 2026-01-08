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
    public partial class FrmPhieuNhap : Form
    {
        private PhieuNhapBLL bll = new PhieuNhapBLL();
        private GundamBLL gundamBll = new GundamBLL();
        private bool isSyncingCombos = false;

        public FrmPhieuNhap()
        {
            InitializeComponent();
        }

        private void FrmPhieuNhap_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadData();
            txtNgayNhap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void LoadCombos()
        {
            var gundams = gundamBll.GetAllGundams();
            
            isSyncingCombos = true;
            
            cboMaGundam.DataSource = new BindingSource(gundams, null);
            cboMaGundam.DisplayMember = "MaGundam";
            cboMaGundam.ValueMember = "MaGundam";

            cboTenGundam.DataSource = new BindingSource(gundams, null);
            cboTenGundam.DisplayMember = "TenGundam";
            cboTenGundam.ValueMember = "MaGundam";

            isSyncingCombos = false;
        }

        private void LoadData()
        {
            dgvData.DataSource = bll.GetAllDetails();
            
            if (dgvData.Columns["MaPN"] != null) dgvData.Columns["MaPN"].HeaderText = "Mã phiếu nhập";
            if (dgvData.Columns["MaGundam"] != null) dgvData.Columns["MaGundam"].HeaderText = "Mã linh kiện";
            if (dgvData.Columns["TenGundam"] != null) dgvData.Columns["TenGundam"].HeaderText = "Tên linh kiện";
            if (dgvData.Columns["SoLuong"] != null) dgvData.Columns["SoLuong"].HeaderText = "Số lượng nhập";
            if (dgvData.Columns["GiaNhap"] != null) dgvData.Columns["GiaNhap"].HeaderText = "Giá nhập";
            if (dgvData.Columns["NgayNhap"] != null)
            {
                dgvData.Columns["NgayNhap"].HeaderText = "Ngày nhập";
                dgvData.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";
            }
        }

        private void cboGundam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isSyncingCombos) return;
            isSyncingCombos = true;

            ComboBox combo = sender as ComboBox;
            if (combo == cboMaGundam)
            {
                cboTenGundam.SelectedValue = cboMaGundam.SelectedValue;
            }
            else if (combo == cboTenGundam)
            {
                cboMaGundam.SelectedValue = cboTenGundam.SelectedValue;
            }

            isSyncingCombos = false;
        }

        private void btnNhapKho_Click(object sender, EventArgs e)
        {
            if (cboMaGundam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn linh kiện!");
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0!");
                return;
            }

            decimal giaNhap = 0;
            if (!decimal.TryParse(txtGiaNhap.Text, out giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ!");
                return;
            }

            try
            {
                var pn = new PhieuNhap { NgayNhap = DateTime.Now };
                var details = new List<ChiTietPhieuNhap>
                {
                    new ChiTietPhieuNhap
                    {
                        MaGundam = (int)cboMaGundam.SelectedValue,
                        SoLuong = (int)numSoLuong.Value,
                        GiaNhap = giaNhap
                    }
                };

                bll.Add(pn, details);
                MessageBox.Show("Nhập kho thành công!");
                LoadData();
                ResetInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetInput();
            LoadData();
        }

        private void ResetInput()
        {
            txtMaPN.Clear();
            numSoLuong.Value = 0;
            txtGiaNhap.Clear();
            if (cboMaGundam.Items.Count > 0) cboMaGundam.SelectedIndex = 0;
        }
    }
}
