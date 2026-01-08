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
    public partial class FrmPhieuXuat : Form
    {
        private PhieuXuatBLL bll = new PhieuXuatBLL();
        private GundamBLL gundamBll = new GundamBLL();
        private bool isSyncingCombos = false;

        public FrmPhieuXuat()
        {
            InitializeComponent();
        }

        private void FrmPhieuXuat_Load(object sender, EventArgs e)
        {
            LoadCombos();
            LoadData();
            txtNgayXuat.Text = DateTime.Now.ToString("dd/MM/yyyy");
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
            
            if (dgvData.Columns["MaPX"] != null) dgvData.Columns["MaPX"].HeaderText = "Mã phiếu xuất";
            if (dgvData.Columns["MaGundam"] != null) dgvData.Columns["MaGundam"].HeaderText = "Mã linh kiện";
            if (dgvData.Columns["TenGundam"] != null) dgvData.Columns["TenGundam"].HeaderText = "Tên linh kiện";
            if (dgvData.Columns["SoLuong"] != null) dgvData.Columns["SoLuong"].HeaderText = "Số lượng xuất";
            if (dgvData.Columns["GiaXuat"] != null) dgvData.Columns["GiaXuat"].HeaderText = "Giá xuất";
            if (dgvData.Columns["NgayXuat"] != null)
            {
                dgvData.Columns["NgayXuat"].HeaderText = "Ngày xuất";
                dgvData.Columns["NgayXuat"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm tt";
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

        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            if (cboMaGundam.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn linh kiện!");
                return;
            }

            if (numSoLuong.Value <= 0)
            {
                MessageBox.Show("Số lượng xuất phải lớn hơn 0!");
                return;
            }

            decimal giaXuat = 0;
            if (!decimal.TryParse(txtGiaXuat.Text, out giaXuat) || giaXuat < 0)
            {
                MessageBox.Show("Giá xuất không hợp lệ!");
                return;
            }

            try
            {
                var px = new PhieuXuat { NgayXuat = DateTime.Now, LyDo = "Xuất tại quầy" };
                var details = new List<ChiTietPhieuXuat>
                {
                    new ChiTietPhieuXuat
                    {
                        MaGundam = (int)cboMaGundam.SelectedValue,
                        SoLuong = (int)numSoLuong.Value,
                        GiaXuat = giaXuat
                    }
                };

                bll.Add(px, details);
                MessageBox.Show("Xuất kho thành công!");
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
            txtMaPX.Clear();
            numSoLuong.Value = 0;
            txtGiaXuat.Clear();
            if (cboMaGundam.Items.Count > 0) cboMaGundam.SelectedIndex = 0;
        }
    }
}
