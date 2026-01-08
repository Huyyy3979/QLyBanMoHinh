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
    public partial class FrmTaoPhieu : Form
    {
        private GundamBLL gundamBll = new GundamBLL();
        private PhieuNhapBLL nhapBll = new PhieuNhapBLL();
        private PhieuXuatBLL xuatBll = new PhieuXuatBLL();
        
        private bool isNhap = true;
        private List<CartItem> cart = new List<CartItem>();

        public class CartItem
        {
            public int MaGundam { get; set; }
            public string TenGundam { get; set; }
            public int SoLuong { get; set; }
        }

        public FrmTaoPhieu(bool nhap = true)
        {
            InitializeComponent();
            this.isNhap = nhap;
            this.lblTitle.Text = isNhap ? "TẠO PHIẾU NHẬP" : "TẠO PHIẾU XUẤT";
        }

        private void FrmTaoPhieu_Load(object sender, EventArgs e)
        {
            cboGundam.DataSource = gundamBll.GetAllGundams();
            cboGundam.DisplayMember = "TenGundam";
            cboGundam.ValueMember = "MaGundam";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboGundam.SelectedValue == null) return;
            int maGundam = (int)cboGundam.SelectedValue;
            var g = gundamBll.GetAllGundams().FirstOrDefault(x => x.MaGundam == maGundam);
            if (g == null) return;

            int qty = (int)numSoLuong.Value;

            var existing = cart.FirstOrDefault(x => x.MaGundam == maGundam);
            if (existing != null)
            {
                existing.SoLuong += qty;
            }
            else
            {
                cart.Add(new CartItem {
                    MaGundam = maGundam,
                    TenGundam = g.TenGundam,
                    SoLuong = qty
                });
            }

            UpdateGrid();
        }

        private void UpdateGrid()
        {
            dgvData.DataSource = null;
            dgvData.DataSource = cart.Select(x => new {
                x.TenGundam,
                x.SoLuong
            }).ToList();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0) return;

            if (isNhap)
            {
                PhieuNhap pn = new PhieuNhap { NgayNhap = DateTime.Now, GhiChu = txtGhiChu.Text };
                List<ChiTietPhieuNhap> details = cart.Select(x => new ChiTietPhieuNhap {
                    MaPN = pn.MaPN,
                    MaGundam = x.MaGundam,
                    SoLuong = x.SoLuong
                }).ToList();
                nhapBll.Add(pn, details);
            }
            else
            {
                PhieuXuat px = new PhieuXuat { NgayXuat = DateTime.Now, LyDo = txtGhiChu.Text };
                List<ChiTietPhieuXuat> details = cart.Select(x => new ChiTietPhieuXuat {
                    MaPX = px.MaPX,
                    MaGundam = x.MaGundam,
                    SoLuong = x.SoLuong
                }).ToList();
                xuatBll.Add(px, details);
            }

            MessageBox.Show("Đã lưu phiếu thành công!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
