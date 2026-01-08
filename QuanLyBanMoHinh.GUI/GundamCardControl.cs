namespace QuanLyBanMoHinh.GUI
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using QuanLyBanMoHinh.BLL;

    public partial class GundamCardControl : UserControl
    {
        public GundamDTO Data { get; private set; }
        public event EventHandler CardClicked;

        public GundamCardControl()
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

        public void BindData(GundamDTO data)
        {
            this.Data = data;
            lblTen.Text = data.TenGundam;
            lblGia.Text = string.Format("{0:N0}đ", data.Gia.GetValueOrDefault());
            
            if (!string.IsNullOrEmpty(data.HinhAnh) && System.IO.File.Exists(data.HinhAnh))
            {
                using (var temp = Image.FromFile(data.HinhAnh))
                {
                    picHinh.Image = new Bitmap(temp);
                }
            }
            else
            {
                picHinh.Image = null; 
            }
        }

        private void Content_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
