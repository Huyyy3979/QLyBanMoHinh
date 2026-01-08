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
    public partial class FrmSeriesGundam : Form
    {
        private SeriesGundamBLL bll = new SeriesGundamBLL();
        private bool isAdding = false;

        public FrmSeriesGundam()
        {
            InitializeComponent();
        }

        private void FrmSeriesGundam_Load(object sender, EventArgs e)
        {
            LoadData();
            ResetInput();
        }

        private void LoadData()
        {
            dgvSeries.DataSource = bll.GetAll();
            if (dgvSeries.Columns["Gundams"] != null) dgvSeries.Columns["Gundams"].Visible = false;
        }

        private void ResetInput()
        {
            txtTenSeries.Text = "";
            pnlInput.Enabled = false;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            isAdding = false;
        }

        private void ShowInput(bool show)
        {
            pnlInput.Enabled = show;
            btnLuu.Enabled = show;
            btnHuy.Enabled = show;
            btnThem.Enabled = !show;
            btnSua.Enabled = !show;
            btnXoa.Enabled = !show;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            isAdding = true;
            ResetInput();
            ShowInput(true);
            txtTenSeries.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSeries.CurrentRow == null) return;
            isAdding = false;
            ShowInput(true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSeries.CurrentRow == null) return;
            var id = (int)dgvSeries.CurrentRow.Cells["MaSeries"].Value;

            if (bll.HasDependents(id))
            {
                MessageBox.Show("Không thể xóa series này vì đang có sản phẩm thuộc series này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bll.Delete(id);
                LoadData();
                ResetInput();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenSeries.Text)) return;

            var series = new SeriesGundam { TenSeries = txtTenSeries.Text };

            if (isAdding) bll.Add(series);
            else
            {
                series.MaSeries = (int)dgvSeries.CurrentRow.Cells["MaSeries"].Value;
                bll.Update(series);
            }

            LoadData();
            ResetInput();
        }

        private void btnHuy_Click(object sender, EventArgs e) => ResetInput();

        private void dgvSeries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenSeries.Text = dgvSeries.Rows[e.RowIndex].Cells["TenSeries"].Value?.ToString();
            }
        }
    }
}
