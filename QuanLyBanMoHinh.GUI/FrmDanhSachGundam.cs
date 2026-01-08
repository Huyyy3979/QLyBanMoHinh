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
    public partial class FrmDanhSachGundam : Form
    {
        private GundamBLL bll = new GundamBLL();
        private SeriesGundamBLL seriesBll = new SeriesGundamBLL();
        private HangSanXuatBLL hangBll = new HangSanXuatBLL();
        private GradeScaleBLL gradeBll = new GradeScaleBLL();
        private LoaiSanPhamBLL loaiBll = new LoaiSanPhamBLL();

        private bool isAdding = false;
        private string selectedImagePath = "";
        private int selectedId = -1;

        public FrmDanhSachGundam()
        {
            InitializeComponent();
        }

        private void FrmDanhSachGundam_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            ResetInput();
        }

        private void LoadComboBoxes()
        {
            cboSeries.DataSource = seriesBll.GetAll();
            cboSeries.DisplayMember = "TenSeries";
            cboSeries.ValueMember = "MaSeries";

            cboHang.DataSource = hangBll.GetAll();
            cboHang.DisplayMember = "TenHang";
            cboHang.ValueMember = "MaHang";

            cboGrade.DataSource = gradeBll.GetAll();
            cboGrade.DisplayMember = "TenGrade";
            cboGrade.ValueMember = "MaGrade";

            cboLoai.DataSource = loaiBll.GetAll();
            cboLoai.DisplayMember = "TenLoai";
            cboLoai.ValueMember = "MaLoai";
        }

        private void LoadData()
        {
            flpGundam.SuspendLayout();
            flpGundam.Controls.Clear();
            // Sắp xếp mới nhất lên đầu để dễ thấy sau khi Thêm
            var list = bll.GetAllGundams().OrderByDescending(g => g.MaGundam).ToList();
            
            // Hiện ngày cập nhật mới nhất của toàn bộ danh sách
            var latest = list.Count > 0 ? list.Max(x => x.NgayCapNhat) : null;
            txtNgayTao.Text = "--";
            txtNgayCapNhat.Text = latest?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";

            foreach (var item in list)
            {
                var card = new GundamCardControl();
                card.BindData(item);
                card.CardClicked += Card_CardClicked;
                flpGundam.Controls.Add(card);
            }
            flpGundam.ResumeLayout();
        }

        private void Card_CardClicked(object sender, EventArgs e)
        {
            var card = (GundamCardControl)sender;
            var data = card.Data;
            
            selectedId = data.MaGundam;
            txtTenGundam.Text = data.TenGundam;
            txtGia.Text = data.Gia?.ToString();
            cboSeries.SelectedValue = data.MaSeries;
            cboHang.SelectedValue = data.MaHang;
            cboGrade.SelectedValue = data.MaGrade;
            cboLoai.SelectedValue = data.MaLoai;
            selectedImagePath = data.HinhAnh;

            if (!string.IsNullOrEmpty(selectedImagePath) && System.IO.File.Exists(selectedImagePath))
            {
                using (var temp = Image.FromFile(selectedImagePath))
                {
                    picSelected.Image = new Bitmap(temp);
                }
            }
            else
            {
                picSelected.Image = null;
            }

            txtNgayTao.Text = data.NgayTao?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";
            txtNgayCapNhat.Text = data.NgayCapNhat?.ToString("dd/MM/yyyy hh:mm:ss tt") ?? "--";
        }

        private void ResetInput()
        {
            txtTenGundam.Text = "";
            txtGia.Text = "";
            if (cboSeries.Items.Count > 0) cboSeries.SelectedIndex = 0;
            if (cboHang.Items.Count > 0) cboHang.SelectedIndex = 0;
            if (cboGrade.Items.Count > 0) cboGrade.SelectedIndex = 0;
            if (cboLoai.Items.Count > 0) cboLoai.SelectedIndex = 0;
            
            picSelected.Image = null;
            selectedImagePath = "";
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
            
            if (show) txtTenGundam.Focus();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = ofd.FileName;
                    using (var temp = Image.FromFile(selectedImagePath))
                    {
                        picSelected.Image = new Bitmap(temp);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ResetInput();
            isAdding = true;
            ShowInput(true);
            txtTenGundam.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn một Gundam để sửa!");
                return;
            }
            isAdding = false;
            ShowInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedId == -1)
            {
                MessageBox.Show("Vui lòng chọn một Gundam để xóa!");
                return;
            }

            string msg = "Bạn có chắc muốn xóa sản phẩm này?";
            string title = "Xác nhận xóa";
            MessageBoxIcon icon = MessageBoxIcon.Question;

            if (bll.HasDependents(selectedId))
            {
                msg = "Sản phẩm này đã có dữ liệu trong đơn hàng hoặc phiếu nhập/xuất.\n" +
                      "Bạn có muốn XÓA TẬN GỐC sản phẩm này cùng toàn bộ dữ liệu liên quan không?\n" +
                      "(Lưu ý: Hành động này không thể hoàn tác!)";
                title = "Xác nhận xóa tận gốc";
                icon = MessageBoxIcon.Warning;
            }

            if (MessageBox.Show(msg, title, MessageBoxButtons.YesNo, icon) == DialogResult.Yes)
            {
                try
                {
                    bll.DeleteForce(selectedId);
                    MessageBox.Show("Đã xóa thành công!");
                    LoadData();
                    ResetInput();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa: " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGundam.Text))
            {
                MessageBox.Show("Vui lòng nhập tên Gundam!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new GundamDTO
            {
                TenGundam = txtTenGundam.Text,
                Gia = decimal.TryParse(txtGia.Text, out decimal gia) ? gia : (decimal?)null,
                MaSeries = cboSeries.SelectedValue != null ? (int)cboSeries.SelectedValue : (int?)null,
                MaHang = cboHang.SelectedValue != null ? (int)cboHang.SelectedValue : (int?)null,
                MaGrade = cboGrade.SelectedValue != null ? (int)cboGrade.SelectedValue : (int?)null,
                MaLoai = cboLoai.SelectedValue != null ? (int)cboLoai.SelectedValue : (int?)null,
                HinhAnh = selectedImagePath
            };

            if (isAdding)
            {
                bll.Add(dto);
            }
            else
            {
                dto.MaGundam = selectedId;
                // Lấy lại dữ liệu cũ để giữ NgayTao
                var existing = bll.GetById(selectedId);
                if (existing != null) dto.NgayTao = existing.NgayTao;
                
                bll.Update(dto);
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
