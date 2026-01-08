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
    public partial class FrmTonKho : Form
    {
        private TonKhoBLL bll = new TonKhoBLL();

        public FrmTonKho()
        {
            InitializeComponent();
        }

        private void FrmTonKho_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dgvData.DataSource = bll.GetAll();
            if (dgvData.Columns["Gundam"] != null) dgvData.Columns["Gundam"].Visible = false;
        }

        private void btnKiemKe_Click(object sender, EventArgs e)
        {
            if (dgvData.CurrentRow == null) return;
            var current = (QuanLyBanMoHinh.DAL.enities.TonKho)dgvData.CurrentRow.DataBoundItem;
            
            // Tạm thời dùng InputBox của VB để demo nhanh hoặc có thể dùng Form con
            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập số lượng tồn kho thực tế cho sản phẩm này:", "Kiểm kê tồn kho", current.SoLuongTon?.ToString());
            
            if (int.TryParse(input, out int newQty))
            {
                current.SoLuongTon = newQty;
                bll.Update(current);
                MessageBox.Show("Đã cập nhật số lượng tồn kho thành công!");
                LoadData();
            }
        }

        private void btnXuatBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xuất báo cáo tồn kho ra file Excel thành công (giả lập)!", "Thông báo");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.ToLower();
            var all = bll.GetAll();
            dgvData.DataSource = all.Where(t => t.Gundam != null && t.Gundam.TenGundam.ToLower().Contains(keyword)).ToList();
        }
    }
}
