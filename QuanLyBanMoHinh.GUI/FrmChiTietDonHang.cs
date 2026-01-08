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
    public partial class FrmChiTietDonHang : Form
    {
        private ChiTietDonHangBLL bll = new ChiTietDonHangBLL();

        private int maDon = -1;

        public FrmChiTietDonHang(int id = -1)
        {
            InitializeComponent();
            this.maDon = id;
        }

        private void FrmChiTietDonHang_Load(object sender, EventArgs e)
        {
            if (maDon == -1)
                dgvData.DataSource = bll.GetAll();
            else
                dgvData.DataSource = bll.GetByMaDon(maDon);

            if (dgvData.Columns["DonBan"] != null) dgvData.Columns["DonBan"].Visible = false;
            if (dgvData.Columns["Gundam"] != null) dgvData.Columns["Gundam"].Visible = false;
        }
    }
}
