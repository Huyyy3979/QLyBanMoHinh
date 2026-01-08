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
    public partial class FrmDonBan : Form
    {
        private DonBanBLL bll = new DonBanBLL();

        public FrmDonBan()
        {
            InitializeComponent();
        }

        private void FrmDonBan_Load(object sender, EventArgs e)
        {
            dgvData.DataSource = bll.GetAll();
            if (dgvData.Columns["ChiTietDonHangs"] != null) dgvData.Columns["ChiTietDonHangs"].Visible = false;
            if (dgvData.Columns["ThanhToans"] != null) dgvData.Columns["ThanhToans"].Visible = false;
            if (dgvData.Columns["KhachHang"] != null) dgvData.Columns["KhachHang"].Visible = false;
        }

        private void btnTaoDon_Click(object sender, EventArgs e)
        {
            FrmTaoDonHang frm = new FrmTaoDonHang();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvData.DataSource = bll.GetAll();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;
            int id = (int)dgvData.CurrentRow.Cells["MaDon"].Value;
            FrmChiTietDonHang frm = new FrmChiTietDonHang(id);
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;
            int id = (int)dgvData.CurrentRow.Cells["MaDon"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa đơn hàng này cùng toàn bộ chi tiết và lịch sử thanh toán liên quan?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    bll.Delete(id);
                    MessageBox.Show("Đã xóa đơn hàng thành công!");
                    dgvData.DataSource = bll.GetAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;
            int maDon = (int)dgvData.CurrentRow.Cells["MaDon"].Value;
            
            var ctBll = new ChiTietDonHangBLL();
            var gdBll = new GundamBLL();
            var list = ctBll.GetByMaDon(maDon);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------- HOÁ ĐƠN BÁN HÀNG ----------");
            sb.AppendLine($"Mã đơn: {maDon}");
            sb.AppendLine($"Ngày: {dgvData.CurrentRow.Cells["NgayBan"].Value}");
            sb.AppendLine("--------------------------------------");
            sb.AppendLine(string.Format("{0,-20} {1,-10} {2,-10}", "Sản phẩm", "SL", "Thành tiền"));
            
            foreach (var item in list)
            {
                var g = gdBll.GetById(item.MaGundam);
                string name = (g != null && !string.IsNullOrEmpty(g.TenGundam)) ? g.TenGundam : "Sản phẩm " + item.MaGundam;
                if (name.Length > 18) name = name.Substring(0, 15) + "...";
                
                sb.AppendLine(string.Format("{0,-20} {1,-10} {2,-10:N0}", name, item.SoLuong, (item.SoLuong * item.DonGia)));
            }
            sb.AppendLine("--------------------------------------");
            sb.AppendLine($"TỔNG CỘNG: {dgvData.CurrentRow.Cells["TongTien"].Value:N0} VND");
            sb.AppendLine("--------------------------------------");
            sb.AppendLine("Cảm ơn quý khách đã mua Gundam!");

            MessageBox.Show(sb.ToString(), "Bản xem trước hoá đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
