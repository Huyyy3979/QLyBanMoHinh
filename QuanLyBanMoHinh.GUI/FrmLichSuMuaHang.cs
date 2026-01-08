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
    public partial class FrmLichSuMuaHang : Form
    {
        private DonBanBLL bll = new DonBanBLL(); // Reusing DonBanBLL for history

        public FrmLichSuMuaHang()
        {
            InitializeComponent();
        }

        private void FrmLichSuMuaHang_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = bll.GetAll();
            if (dgvData.Columns["ChiTietDonHangs"] != null) dgvData.Columns["ChiTietDonHangs"].Visible = false;
            if (dgvData.Columns["ThanhToans"] != null) dgvData.Columns["ThanhToans"].Visible = false;
        }
    }
}
