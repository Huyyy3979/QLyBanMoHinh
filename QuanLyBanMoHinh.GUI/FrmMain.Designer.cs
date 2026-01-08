namespace QuanLyBanMoHinh.GUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            
            // Thong Ke
            this.pnlSubMenuThongKe = new System.Windows.Forms.Panel();
            this.btnDoanhThu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();

            // Kho
            this.pnlSubMenuKho = new System.Windows.Forms.Panel();
            this.btnPhieuXuat = new System.Windows.Forms.Button();
            this.btnPhieuNhap = new System.Windows.Forms.Button();
            this.btnTonKho = new System.Windows.Forms.Button();
            this.btnKho = new System.Windows.Forms.Button();

            // Khach Hang
            this.pnlSubMenuKhachHang = new System.Windows.Forms.Panel();
            this.btnLichSuMua = new System.Windows.Forms.Button();
            this.btnKhachVIP = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnMenuKhachHang = new System.Windows.Forms.Button(); // Renamed to avoid confusion

            // Don Hang
            this.pnlSubMenuDonHang = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChiTietDon = new System.Windows.Forms.Button();
            this.btnDonBan = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();

            // Thuong Hieu
            this.pnlSubMenuThuongHieu = new System.Windows.Forms.Panel();
            this.btnHang = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.btnThuongHieu = new System.Windows.Forms.Button();

            // Gundam
            this.pnlSubMenuGundam = new System.Windows.Forms.Panel();
            this.btnLoaiSanPham = new System.Windows.Forms.Button();
            this.btnDanhSachGundam = new System.Windows.Forms.Button();
            this.btnMoHinh = new System.Windows.Forms.Button();

            this.label1 = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();

            this.pnlMenu.SuspendLayout();
            this.pnlSubMenuKho.SuspendLayout();
            this.pnlSubMenuKhachHang.SuspendLayout();
            this.pnlSubMenuDonHang.SuspendLayout();
            this.pnlSubMenuThuongHieu.SuspendLayout();
            this.pnlSubMenuGundam.SuspendLayout();
            this.pnlSubMenuThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            // Add in reverse order of Top docking
            this.pnlMenu.Controls.Add(this.btnDangXuat);
            
            this.pnlMenu.Controls.Add(this.pnlSubMenuThongKe);
            this.pnlMenu.Controls.Add(this.btnThongKe);

            this.pnlMenu.Controls.Add(this.pnlSubMenuKho);
            this.pnlMenu.Controls.Add(this.btnKho);
            
            this.pnlMenu.Controls.Add(this.pnlSubMenuKhachHang);
            this.pnlMenu.Controls.Add(this.btnMenuKhachHang);
            
            this.pnlMenu.Controls.Add(this.pnlSubMenuDonHang);
            this.pnlMenu.Controls.Add(this.btnHoaDon);
            
            this.pnlMenu.Controls.Add(this.pnlSubMenuThuongHieu);
            this.pnlMenu.Controls.Add(this.btnThuongHieu);
            
            this.pnlMenu.Controls.Add(this.pnlSubMenuGundam);
            this.pnlMenu.Controls.Add(this.btnMoHinh);
            
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.picLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(220, 645);
            this.pnlMenu.TabIndex = 0;

            // picLogo, label1, btnMoHinh, pnlSubMenuGundam, btnThuongHieu, pnlSubMenuThuongHieu existing setups...
             // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::QuanLyBanMoHinh.GUI.Properties.Resources.c020ae2090799f233a410c7c299878a9;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;

            // label1
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODEL SHOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

             // btnMoHinh
            this.btnMoHinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMoHinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoHinh.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoHinh.ForeColor = System.Drawing.Color.White;
            this.btnMoHinh.Location = new System.Drawing.Point(0, 200);
            this.btnMoHinh.Name = "btnMoHinh";
            this.btnMoHinh.Size = new System.Drawing.Size(220, 45);
            this.btnMoHinh.TabIndex = 7;
            this.btnMoHinh.Text = "Quản lý Gundam";
            this.btnMoHinh.UseVisualStyleBackColor = true;
            this.btnMoHinh.Click += new System.EventHandler(this.btnMoHinh_Click);

            // pnlSubMenuGundam
            this.pnlSubMenuGundam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuGundam.Controls.Add(this.btnLoaiSanPham);
            this.pnlSubMenuGundam.Controls.Add(this.btnDanhSachGundam);
            this.pnlSubMenuGundam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuGundam.Location = new System.Drawing.Point(0, 245);
            this.pnlSubMenuGundam.Name = "pnlSubMenuGundam";
            this.pnlSubMenuGundam.Size = new System.Drawing.Size(220, 90);
            this.pnlSubMenuGundam.TabIndex = 9;
            this.pnlSubMenuGundam.Visible = false;

            // btnDanhSachGundam
            this.btnDanhSachGundam.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhSachGundam.FlatAppearance.BorderSize = 0;
            this.btnDanhSachGundam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachGundam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnDanhSachGundam.ForeColor = System.Drawing.Color.White;
            this.btnDanhSachGundam.Location = new System.Drawing.Point(0, 0);
            this.btnDanhSachGundam.Name = "btnDanhSachGundam";
            this.btnDanhSachGundam.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDanhSachGundam.Size = new System.Drawing.Size(220, 40);
            this.btnDanhSachGundam.Text = "Danh sách Gundam";
            this.btnDanhSachGundam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhSachGundam.UseVisualStyleBackColor = true;
            this.btnDanhSachGundam.Click += new System.EventHandler(this.btnDanhSachGundam_Click);

            // btnLoaiSanPham
            this.btnLoaiSanPham.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnLoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnLoaiSanPham.Location = new System.Drawing.Point(0, 40);
            this.btnLoaiSanPham.Name = "btnLoaiSanPham";
            this.btnLoaiSanPham.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLoaiSanPham.Size = new System.Drawing.Size(220, 40);
            this.btnLoaiSanPham.Text = "Loại sản phẩm";
            this.btnLoaiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiSanPham.UseVisualStyleBackColor = true;
            this.btnLoaiSanPham.Click += new System.EventHandler(this.btnLoaiSanPham_Click);

            // btnThuongHieu
            this.btnThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThuongHieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuongHieu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThuongHieu.ForeColor = System.Drawing.Color.White;
            this.btnThuongHieu.Location = new System.Drawing.Point(0, 335);
            this.btnThuongHieu.Name = "btnThuongHieu";
            this.btnThuongHieu.Size = new System.Drawing.Size(220, 45);
            this.btnThuongHieu.TabIndex = 5;
            this.btnThuongHieu.Text = "Series & Hãng";
            this.btnThuongHieu.UseVisualStyleBackColor = true;
            this.btnThuongHieu.Click += new System.EventHandler(this.btnThuongHieu_Click);

            // pnlSubMenuThuongHieu
            this.pnlSubMenuThuongHieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuThuongHieu.Controls.Add(this.btnHang);
            this.pnlSubMenuThuongHieu.Controls.Add(this.btnSeries);
            this.pnlSubMenuThuongHieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuThuongHieu.Location = new System.Drawing.Point(0, 380);
            this.pnlSubMenuThuongHieu.Name = "pnlSubMenuThuongHieu";
            this.pnlSubMenuThuongHieu.Size = new System.Drawing.Size(220, 90);
            this.pnlSubMenuThuongHieu.Visible = false;

            // btnSeries
            this.btnSeries.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSeries.FlatAppearance.BorderSize = 0;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnSeries.ForeColor = System.Drawing.Color.White;
            this.btnSeries.Location = new System.Drawing.Point(0, 0);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSeries.Size = new System.Drawing.Size(220, 40);
            this.btnSeries.Text = "Series Gundam";
            this.btnSeries.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeries.UseVisualStyleBackColor = true;
            this.btnSeries.Click += new System.EventHandler(this.btnSeries_Click);

            // btnHang
            this.btnHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHang.FlatAppearance.BorderSize = 0;
            this.btnHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnHang.ForeColor = System.Drawing.Color.White;
            this.btnHang.Location = new System.Drawing.Point(0, 40);
            this.btnHang.Name = "btnHang";
            this.btnHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnHang.Size = new System.Drawing.Size(220, 40);
            this.btnHang.Text = "Hãng sản xuất";
            this.btnHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHang.UseVisualStyleBackColor = true;
            this.btnHang.Click += new System.EventHandler(this.btnHang_Click);

            // btnHoaDon (Orders) -- Renamed logic grouping
            this.btnHoaDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnHoaDon.Location = new System.Drawing.Point(0, 470);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(220, 45);
            this.btnHoaDon.Text = "Quản lý Đơn hàng";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);

            // pnlSubMenuDonHang
            this.pnlSubMenuDonHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuDonHang.Controls.Add(this.btnThanhToan);
            this.pnlSubMenuDonHang.Controls.Add(this.btnChiTietDon);
            this.pnlSubMenuDonHang.Controls.Add(this.btnDonBan);
            this.pnlSubMenuDonHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuDonHang.Location = new System.Drawing.Point(0, 515);
            this.pnlSubMenuDonHang.Name = "pnlSubMenuDonHang";
            this.pnlSubMenuDonHang.Size = new System.Drawing.Size(220, 130);
            this.pnlSubMenuDonHang.Visible = false;

            // btnDonBan
            this.btnDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDonBan.FlatAppearance.BorderSize = 0;
            this.btnDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDonBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnDonBan.ForeColor = System.Drawing.Color.White;
            this.btnDonBan.Location = new System.Drawing.Point(0, 0);
            this.btnDonBan.Name = "btnDonBan";
            this.btnDonBan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDonBan.Size = new System.Drawing.Size(220, 40);
            this.btnDonBan.Text = "Đơn bán";
            this.btnDonBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDonBan.UseVisualStyleBackColor = true;
            this.btnDonBan.Click += new System.EventHandler(this.btnDonBan_Click);
            
            // btnChiTietDon
            this.btnChiTietDon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChiTietDon.FlatAppearance.BorderSize = 0;
            this.btnChiTietDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietDon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnChiTietDon.ForeColor = System.Drawing.Color.White;
            this.btnChiTietDon.Location = new System.Drawing.Point(0, 40);
            this.btnChiTietDon.Name = "btnChiTietDon";
            this.btnChiTietDon.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnChiTietDon.Size = new System.Drawing.Size(220, 40);
            this.btnChiTietDon.Text = "Chi tiết đơn hàng";
            this.btnChiTietDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChiTietDon.UseVisualStyleBackColor = true;
            this.btnChiTietDon.Click += new System.EventHandler(this.btnChiTietDon_Click);

            // btnThanhToan
            this.btnThanhToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(0, 80);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnThanhToan.Size = new System.Drawing.Size(220, 40);
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // btnMenuKhachHang (Parent Button)
            this.btnMenuKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuKhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMenuKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnMenuKhachHang.Location = new System.Drawing.Point(0, 645); 
            this.btnMenuKhachHang.Name = "btnMenuKhachHang";
            this.btnMenuKhachHang.Size = new System.Drawing.Size(220, 45);
            this.btnMenuKhachHang.Text = "Quản lý Khách hàng";
            this.btnMenuKhachHang.UseVisualStyleBackColor = true;
            this.btnMenuKhachHang.Click += new System.EventHandler(this.btnMenuKhachHang_Click);
            
             // pnlSubMenuKhachHang
            this.pnlSubMenuKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuKhachHang.Controls.Add(this.btnLichSuMua);
            this.pnlSubMenuKhachHang.Controls.Add(this.btnKhachVIP);
            this.pnlSubMenuKhachHang.Controls.Add(this.btnKhachHang);
            this.pnlSubMenuKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuKhachHang.Location = new System.Drawing.Point(0, 690);
            this.pnlSubMenuKhachHang.Name = "pnlSubMenuKhachHang";
            this.pnlSubMenuKhachHang.Size = new System.Drawing.Size(220, 130);
            this.pnlSubMenuKhachHang.Visible = false;

            // btnKhachHang
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 0);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnKhachHang.Size = new System.Drawing.Size(220, 40);
            this.btnKhachHang.Text = "Danh sách Khách";
            this.btnKhachHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachHang.UseVisualStyleBackColor = true;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);

             // btnKhachVIP
            this.btnKhachVIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachVIP.FlatAppearance.BorderSize = 0;
            this.btnKhachVIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachVIP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnKhachVIP.ForeColor = System.Drawing.Color.White;
            this.btnKhachVIP.Location = new System.Drawing.Point(0, 40);
            this.btnKhachVIP.Name = "btnKhachVIP";
            this.btnKhachVIP.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnKhachVIP.Size = new System.Drawing.Size(220, 40);
            this.btnKhachVIP.Text = "Khách VIP";
            this.btnKhachVIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachVIP.UseVisualStyleBackColor = true;
            this.btnKhachVIP.Click += new System.EventHandler(this.btnKhachVIP_Click);

            // btnLichSuMua
            this.btnLichSuMua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLichSuMua.FlatAppearance.BorderSize = 0;
            this.btnLichSuMua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLichSuMua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnLichSuMua.ForeColor = System.Drawing.Color.White;
            this.btnLichSuMua.Location = new System.Drawing.Point(0, 80);
            this.btnLichSuMua.Name = "btnLichSuMua";
            this.btnLichSuMua.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnLichSuMua.Size = new System.Drawing.Size(220, 40);
            this.btnLichSuMua.Text = "Lịch sử mua hàng";
            this.btnLichSuMua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLichSuMua.UseVisualStyleBackColor = true;
            this.btnLichSuMua.Click += new System.EventHandler(this.btnLichSuMua_Click);

            // btnKho (Parent)
            this.btnKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKho.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnKho.ForeColor = System.Drawing.Color.White;
            this.btnKho.Location = new System.Drawing.Point(0, 820); 
            this.btnKho.Name = "btnKho";
            this.btnKho.Size = new System.Drawing.Size(220, 45);
            this.btnKho.TabIndex = 2;
            this.btnKho.Text = "Quản lý Kho";
            this.btnKho.UseVisualStyleBackColor = true;
            this.btnKho.Click += new System.EventHandler(this.btnKho_Click);

             // pnlSubMenuKho
            this.pnlSubMenuKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuKho.Controls.Add(this.btnPhieuXuat);
            this.pnlSubMenuKho.Controls.Add(this.btnPhieuNhap);
            this.pnlSubMenuKho.Controls.Add(this.btnTonKho);
            this.pnlSubMenuKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuKho.Location = new System.Drawing.Point(0, 865);
            this.pnlSubMenuKho.Name = "pnlSubMenuKho";
            this.pnlSubMenuKho.Size = new System.Drawing.Size(220, 130);
            this.pnlSubMenuKho.Visible = false;

            // btnTonKho
            this.btnTonKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTonKho.FlatAppearance.BorderSize = 0;
            this.btnTonKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTonKho.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnTonKho.ForeColor = System.Drawing.Color.White;
            this.btnTonKho.Location = new System.Drawing.Point(0, 0);
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTonKho.Size = new System.Drawing.Size(220, 40);
            this.btnTonKho.Text = "Tồn kho";
            this.btnTonKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTonKho.UseVisualStyleBackColor = true;
            this.btnTonKho.Click += new System.EventHandler(this.btnTonKho_Click);

            // btnPhieuNhap
            this.btnPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuNhap.FlatAppearance.BorderSize = 0;
            this.btnPhieuNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnPhieuNhap.ForeColor = System.Drawing.Color.White;
            this.btnPhieuNhap.Location = new System.Drawing.Point(0, 40);
            this.btnPhieuNhap.Name = "btnPhieuNhap";
            this.btnPhieuNhap.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPhieuNhap.Size = new System.Drawing.Size(220, 40);
            this.btnPhieuNhap.Text = "Phiếu nhập";
            this.btnPhieuNhap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuNhap.UseVisualStyleBackColor = true;
            this.btnPhieuNhap.Click += new System.EventHandler(this.btnPhieuNhap_Click);
            
             // btnPhieuXuat
            this.btnPhieuXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhieuXuat.FlatAppearance.BorderSize = 0;
            this.btnPhieuXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhieuXuat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnPhieuXuat.ForeColor = System.Drawing.Color.White;
            this.btnPhieuXuat.Location = new System.Drawing.Point(0, 80);
            this.btnPhieuXuat.Name = "btnPhieuXuat";
            this.btnPhieuXuat.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPhieuXuat.Size = new System.Drawing.Size(220, 40);
            this.btnPhieuXuat.Text = "Phiếu xuất";
            this.btnPhieuXuat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhieuXuat.UseVisualStyleBackColor = true;
            this.btnPhieuXuat.Click += new System.EventHandler(this.btnPhieuXuat_Click);

            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongKe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnThongKe.ForeColor = System.Drawing.Color.White;
            this.btnThongKe.Location = new System.Drawing.Point(0, 995); 
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(220, 45);
            this.btnThongKe.TabIndex = 10;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);

            // 
            // pnlSubMenuThongKe
            // 
            this.pnlSubMenuThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(59)))));
            this.pnlSubMenuThongKe.Controls.Add(this.btnDoanhThu);
            this.pnlSubMenuThongKe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubMenuThongKe.Location = new System.Drawing.Point(0, 1040);
            this.pnlSubMenuThongKe.Name = "pnlSubMenuThongKe";
            this.pnlSubMenuThongKe.Size = new System.Drawing.Size(220, 45);
            this.pnlSubMenuThongKe.TabIndex = 11;
            this.pnlSubMenuThongKe.Visible = false;

            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoanhThu.FlatAppearance.BorderSize = 0;
            this.btnDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoanhThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular);
            this.btnDoanhThu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDoanhThu.Size = new System.Drawing.Size(220, 40);
            this.btnDoanhThu.Text = "Doanh thu";
            this.btnDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhThu.UseVisualStyleBackColor = true;
            this.btnDoanhThu.Click += new System.EventHandler(this.btnDoanhThu_Click);
            
            // btnDangXuat
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 597); 
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(220, 48);
            this.btnDangXuat.TabIndex = 8;
            this.btnDangXuat.Text = " Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);

             // pnlContent
            this.pnlContent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(220, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(940, 645);
            this.pnlContent.TabIndex = 1;

            // FrmMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 645);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bán mô hình";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlSubMenuKho.ResumeLayout(false);
            this.pnlSubMenuKhachHang.ResumeLayout(false);
            this.pnlSubMenuDonHang.ResumeLayout(false);
            this.pnlSubMenuThuongHieu.ResumeLayout(false);
            this.pnlSubMenuGundam.ResumeLayout(false);
            this.pnlSubMenuThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label1;
        
        // Gundam
        private System.Windows.Forms.Button btnMoHinh;
        private System.Windows.Forms.Panel pnlSubMenuGundam;
        private System.Windows.Forms.Button btnLoaiSanPham;
        private System.Windows.Forms.Button btnDanhSachGundam;
        
        // Thuong Hieu
        private System.Windows.Forms.Button btnThuongHieu;
        private System.Windows.Forms.Panel pnlSubMenuThuongHieu;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnHang;

        // Don Hang
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Panel pnlSubMenuDonHang;
        private System.Windows.Forms.Button btnDonBan;
        private System.Windows.Forms.Button btnChiTietDon;
        private System.Windows.Forms.Button btnThanhToan;

        // Khach Hang
        private System.Windows.Forms.Button btnMenuKhachHang;
        private System.Windows.Forms.Panel pnlSubMenuKhachHang;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnKhachVIP;
        private System.Windows.Forms.Button btnLichSuMua;

        // Kho
        private System.Windows.Forms.Button btnKho;
        private System.Windows.Forms.Panel pnlSubMenuKho;
        private System.Windows.Forms.Button btnTonKho;
        private System.Windows.Forms.Button btnPhieuNhap;
        private System.Windows.Forms.Button btnPhieuXuat;

        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Panel pnlSubMenuThongKe;
        private System.Windows.Forms.Button btnDoanhThu;
    }
}