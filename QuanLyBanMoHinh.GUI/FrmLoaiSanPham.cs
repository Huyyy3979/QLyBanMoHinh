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
    public partial class FrmLoaiSanPham : Form
    {
        private LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
        private bool isAdding = false;
        private int selectedId = -1;

        public FrmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void FrmLoaiSanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetInput();
        }

        private void LoadData()
        {
            flpCategories.SuspendLayout();
            flpCategories.Controls.Clear();
            // Sắt xếp mới nhất lên đầu
            var list = bll.GetAll().OrderByDescending(l => l.MaLoai).ToList();
            
            // Hiện ngày cập nhật mới nhất của toàn bộ danh sách
            var latest = list.Count > 0 ? list.Max(x => x.NgayCapNhat) : null;
            txtNgayTao.Text = "--";
            txtNgayCapNhat.Text = latest?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";

            foreach (var item in list)
            {
                var card = new CategoryCardControl();
                card.BindData(item);
                card.CardClicked += (s, ev) => {
                    selectedId = item.MaLoai;
                    txtTenLoai.Text = item.TenLoai;
                    
                    txtNgayTao.Text = item.NgayTao?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";
                    txtNgayCapNhat.Text = item.NgayCapNhat?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";
                };
                flpCategories.Controls.Add(card);
            }
            flpCategories.ResumeLayout();
        }

        private void ResetInput()
        {
            txtTenLoai.Text = "";
            selectedId = -1;
            pnlInput.Visible = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            isAdding = false;
        }

        private void ShowInput(bool show)
        {
            pnlInput.Visible = show;
            pnlInput.Enabled = show;
            btnLuu.Enabled = show;
            btnHuy.Enabled = show;
            btnThem.Enabled = !show;
            btnSua.Enabled = !show;
            btnXoa.Enabled = !show;
            if (show) txtTenLoai.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetInput();
            isAdding = true;
            ShowInput(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần sửa!", "Thông báo");
                return;
            }
            isAdding = false;
            ShowInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn loại sản phẩm cần xóa!", "Thông báo");
                return;
            }

            if (bll.HasDependents(selectedId))
            {
                MessageBox.Show("Không thể xóa loại sản phẩm này vì đang có sản phẩm (Gundam) thuộc loại này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.Delete(selectedId);
                LoadData();
                ResetInput();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLoai.Text))
            {
                MessageBox.Show("Vui lòng nhập tên loại!", "Thông báo");
                return;
            }

            var lsp = new LoaiSanPham
            {
                TenLoai = txtTenLoai.Text
            };

            if (isAdding)
            {
                bll.Add(lsp);
            }
            else
            {
                lsp.MaLoai = selectedId;
                // Giữ lại NgayTao
                var existing = bll.GetAll().FirstOrDefault(x => x.MaLoai == selectedId);
                if (existing != null) lsp.NgayTao = existing.NgayTao;
                
                bll.Update(lsp);
            }

            LoadData();
            ResetInput();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetInput();
        }
    }
}
