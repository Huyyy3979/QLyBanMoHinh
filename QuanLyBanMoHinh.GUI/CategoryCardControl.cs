using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.GUI
{
    public partial class CategoryCardControl : UserControl
    {
        public LoaiSanPham Data { get; private set; }
        public event EventHandler CardClicked;

        public CategoryCardControl()
        {
            InitializeComponent();
            SetupHover(this);
        }

        private void SetupHover(Control ctrl)
        {
            ctrl.MouseEnter += (s, e) => this.BackColor = Color.FromArgb(45, 45, 48);
            ctrl.MouseLeave += (s, e) => this.BackColor = Color.FromArgb(28, 28, 28);
            ctrl.Click += Content_Click;

            foreach (Control child in ctrl.Controls)
            {
                SetupHover(child);
            }
        }

        public void BindData(LoaiSanPham item)
        {
            this.Data = item;
            lblTenLoai.Text = item.TenLoai;
        }

        private void Content_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
