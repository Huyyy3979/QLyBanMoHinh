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



namespace QuanLyBanMoHinh.GUI
{
    public partial class FrmMain : Form
    {
        private Form activeForm = null;

        public FrmMain()
        {
            InitializeComponent();
            customizeDesign();
        }
        
        private void customizeDesign()
        {
            pnlSubMenuGundam.Visible = false;
            pnlSubMenuThuongHieu.Visible = false;
            pnlSubMenuDonHang.Visible = false;
            pnlSubMenuKhachHang.Visible = false;
            pnlSubMenuKho.Visible = false;
            pnlSubMenuThongKe.Visible = false;
        }

        private void hideSubMenu()
        {
            if (pnlSubMenuGundam.Visible == true) pnlSubMenuGundam.Visible = false;
            if (pnlSubMenuThuongHieu.Visible == true) pnlSubMenuThuongHieu.Visible = false;
            if (pnlSubMenuDonHang.Visible == true) pnlSubMenuDonHang.Visible = false;
            if (pnlSubMenuKhachHang.Visible == true) pnlSubMenuKhachHang.Visible = false;
            if (pnlSubMenuKho.Visible == true) pnlSubMenuKho.Visible = false;
            if (pnlSubMenuThongKe.Visible == true) pnlSubMenuThongKe.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        void ActiveButton(Button btn)
        {
             // Optional: reset colors
             foreach (Control c in pnlMenu.Controls)
             {
                 if (c is Button button) button.BackColor = Color.DimGray; // Or default color
             }
        }
       
        void OpenChildForm(Form child)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(child);
            pnlContent.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        // GUNDAM
        private void btnMoHinh_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuGundam);
        }

        private void btnDanhSachGundam_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDanhSachGundam()); 
            // hideSubMenu();
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLoaiSanPham());
            // hideSubMenu();
        }

        // THUONG HIEU
        private void btnThuongHieu_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuThuongHieu);
        }

        private void btnSeries_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSeriesGundam());
        }

        private void btnHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmHangSanXuat());
        }

        // DON HANG
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuDonHang);
        }

        private void btnDonBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDonBan());
        }

        private void btnChiTietDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmChiTietDonHang());
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmThanhToan());
        }

        // KHACH HANG
        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuKhachHang);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
             OpenChildForm(new FrmKhachHang());
        }

        private void btnKhachVIP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmKhachVIP());
        }

        private void btnLichSuMua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmLichSuMuaHang());
        }

        // KHO
        private void btnKho_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuKho);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmTonKho());
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhieuNhap());
        }

        private void btnPhieuXuat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPhieuXuat());
        }
        
        // THONG KE
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlSubMenuThongKe);
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmDoanhThu());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
             // Trở về form đăng nhập (Form1.cs)
             Form1 loginForm = new Form1();
             loginForm.Show();
             this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
