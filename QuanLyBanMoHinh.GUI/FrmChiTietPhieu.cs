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
    public partial class FrmChiTietPhieu : Form
    {
        private PhieuNhapBLL nhapBll = new PhieuNhapBLL();
        private PhieuXuatBLL xuatBll = new PhieuXuatBLL();
        private int maPhieu = -1;
        private bool isNhap = true;

        public FrmChiTietPhieu(int id, bool nhap = true)
        {
            InitializeComponent();
            this.maPhieu = id;
            this.isNhap = nhap;
            this.lblTitle.Text = isNhap ? "CHI TIẾT PHIẾU NHẬP" : "CHI TIẾT PHIẾU XUẤT";
        }

        private void FrmChiTietPhieu_Load(object sender, EventArgs e)
        {
            if (isNhap)
            {
                dgvData.DataSource = nhapBll.GetDetails(maPhieu);
                if (dgvData.Columns["PhieuNhap"] != null) dgvData.Columns["PhieuNhap"].Visible = false;
            }
            else
            {
                dgvData.DataSource = xuatBll.GetDetails(maPhieu);
                if (dgvData.Columns["PhieuXuat"] != null) dgvData.Columns["PhieuXuat"].Visible = false;
            }
            if (dgvData.Columns["Gundam"] != null) dgvData.Columns["Gundam"].Visible = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
