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
    public partial class FrmKhachVIP : Form
    {
        private KhachHangBLL bll = new KhachHangBLL();

        public FrmKhachVIP()
        {
            InitializeComponent();
        }

        private void FrmKhachVIP_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = bll.GetVIPs();
            if (dgvData.Columns["DonBans"] != null) dgvData.Columns["DonBans"].Visible = false;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dgvData.DataSource = bll.GetVIPs();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var vips = bll.GetVIPs();
            dgvData.DataSource = vips.Where(k => k.TenKH.ToLower().Contains(keyword) || k.DienThoai.Contains(keyword)).ToList();
        }
    }
}
