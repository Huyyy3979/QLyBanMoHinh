using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QuanLyBanMoHinh.BLL;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.GUI
{
    public partial class FrmDoanhThu : Form
    {
        private DonBanBLL bll = new DonBanBLL();

        public FrmDoanhThu()
        {
            InitializeComponent();
        }

        private void FrmDoanhThu_Load(object sender, EventArgs e)
        {
            InitFilters();
            LoadAllStats();
            FilterData();
        }

        private void InitFilters()
        {
            // Init Month ComboBox
            var months = Enumerable.Range(1, 12).Select(i => new { Text = "Tháng " + i, Value = i }).ToList();
            cboMonth.DisplayMember = "Text";
            cboMonth.ValueMember = "Value";
            cboMonth.DataSource = months;
            cboMonth.SelectedValue = DateTime.Now.Month;

            // Init Year Numeric
            numYear.Value = DateTime.Now.Year;
            
            // Init DatePicker
            dtpDay.Value = DateTime.Now;
        }

        private void LoadAllStats()
        {
            var all = bll.GetAll();
            var today = DateTime.Today;
            
            decimal sumToday = all.Where(d => d.NgayBan.HasValue && d.NgayBan.Value.Date == today)
                                  .Sum(d => d.TongTien.GetValueOrDefault());

            decimal sumMonth = all.Where(d => d.NgayBan.HasValue && d.NgayBan.Value.Month == today.Month && d.NgayBan.Value.Year == today.Year)
                                  .Sum(d => d.TongTien.GetValueOrDefault());

            decimal sumYear = all.Where(d => d.NgayBan.HasValue && d.NgayBan.Value.Year == today.Year)
                                 .Sum(d => d.TongTien.GetValueOrDefault());

            lblTodayVal.Text = string.Format("{0:N0} VND", sumToday);
            lblMonthVal.Text = string.Format("{0:N0} VND", sumMonth);
            lblYearVal.Text = string.Format("{0:N0} VND", sumYear);
        }

        private void Filter_Changed(object sender, EventArgs e)
        {
            FilterData(sender);
        }

        private void FilterData(object caller = null)
        {
            var all = bll.GetAll();
            var filtered = all.AsQueryable();

            // Lọc theo logic: 
            // Nếu người dùng vừa thay đổi DateTimePicker, có thể lọc theo Ngày.
            // Nếu thay đổi Tháng/Năm, lọc theo Tháng/Năm.
            // Để đơn giản và trực quan, tôi sẽ lọc theo Control mà người dùng vừa tương tác cuối cùng 
            // Hoặc kết hợp các filter nếu cần. Ở đây tôi sẽ ưu tiên lọc chính xác nhất (Ngày).
            
            // Tuy nhiên để "theo yêu cầu", ta sẽ cho phép lọc linh hoạt:
            if (caller == dtpDay)
            {
                filtered = filtered.Where(d => d.NgayBan.HasValue && d.NgayBan.Value.Date == dtpDay.Value.Date);
            }
            else
            {
                if (cboMonth.SelectedValue == null) return;
                int m = Convert.ToInt32(cboMonth.SelectedValue);
                int y = Convert.ToInt32(numYear.Value);
                filtered = filtered.Where(d => d.NgayBan.HasValue && d.NgayBan.Value.Month == m && d.NgayBan.Value.Year == y);
            }

            var list = filtered.OrderByDescending(d => d.NgayBan).ToList();
            
            // Format hiển thị cho Grid
            dgvData.DataSource = list.Select(d => new {
                MaDon = d.MaDon,
                NgayBan = d.NgayBan,
                MaKH = d.MaKH,
                TongTien = d.TongTien
            }).ToList();

            if (dgvData.Columns["MaDon"] != null) dgvData.Columns["MaDon"].HeaderText = "Mã đơn hàng";
            if (dgvData.Columns["NgayBan"] != null) {
                dgvData.Columns["NgayBan"].HeaderText = "Ngày bán";
                dgvData.Columns["NgayBan"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }
            if (dgvData.Columns["MaKH"] != null) dgvData.Columns["MaKH"].HeaderText = "Mã khách hàng";
            if (dgvData.Columns["TongTien"] != null) {
                dgvData.Columns["TongTien"].HeaderText = "Tổng tiền";
                dgvData.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
        }
    }
}
