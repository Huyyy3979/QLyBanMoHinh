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
    public partial class FrmTaoDonHang : Form
    {
        private GundamBLL gundamBll = new GundamBLL();
        private KhachHangBLL khachBll = new KhachHangBLL();
        private DonBanBLL donBll = new DonBanBLL();
        
        private List<ChiTietDonHang> cart = new List<ChiTietDonHang>();

        public FrmTaoDonHang()
        {
            InitializeComponent();
        }

        private void FrmTaoDonHang_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            dgvCart.AutoGenerateColumns = false;
        }

        private void LoadComboBoxes()
        {
            cboKhachHang.DataSource = khachBll.GetAll();
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";

            cboGundam.DataSource = gundamBll.GetAllGundams();
            cboGundam.DisplayMember = "TenGundam";
            cboGundam.ValueMember = "MaGundam";
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cboGundam.SelectedValue == null) return;
            int maGundam = (int)cboGundam.SelectedValue;
            var g = gundamBll.GetAllGundams().FirstOrDefault(x => x.MaGundam == maGundam);
            if (g == null) return;

            int qty = (int)numSoLuong.Value;
            decimal price = g.Gia.GetValueOrDefault();

            var item = cart.FirstOrDefault(c => c.MaGundam == maGundam);
            if (item != null)
            {
                item.SoLuong += qty;
            }
            else
            {
                cart.Add(new ChiTietDonHang
                {
                    MaGundam = maGundam,
                    SoLuong = qty,
                    DonGia = price
                });
            }

            UpdateCartGrid();
        }

        private void UpdateCartGrid()
        {
            dgvCart.DataSource = null;
            dgvCart.DataSource = cart.Select(c => new {
                TenGundam = gundamBll.GetAllGundams().FirstOrDefault(g => g.MaGundam == c.MaGundam)?.TenGundam,
                SoLuong = c.SoLuong,
                DonGia = c.DonGia,
                ThanhTien = c.SoLuong * c.DonGia
            }).ToList();

            lblTongTien.Text = "Tổng tiền: " + cart.Sum(c => c.SoLuong * c.DonGia)?.ToString("N0") + " VND";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0) return;
            if (cboKhachHang.SelectedValue == null) return;

            DonBan don = new DonBan
            {
                MaKH = (int)cboKhachHang.SelectedValue,
                NgayBan = DateTime.Now,
                TongTien = cart.Sum(c => c.SoLuong * c.DonGia)
            };

            try
            {
                donBll.Add(don, cart);
                MessageBox.Show("Đã tạo đơn hàng thành công!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
