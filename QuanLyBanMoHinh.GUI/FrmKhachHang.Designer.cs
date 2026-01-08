namespace QuanLyBanMoHinh.GUI
{
    partial class FrmKhachHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblBell = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.lblNgayCapNhat = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtSearchSDT = new System.Windows.Forms.TextBox();
            this.lblSearchSDT = new System.Windows.Forms.Label();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grbInfo.SuspendLayout();
            this.grbActions.SuspendLayout();
            this.grbSearch.SuspendLayout();
            this.grbList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Controls.Add(this.lblMinimize);
            this.pnlHeader.Controls.Add(this.lblBell);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(900, 81);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(862, 8);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Size = new System.Drawing.Size(28, 21);
            this.lblClose.TabIndex = 3;
            this.lblClose.Text = "X";
            // 
            // lblMinimize
            // 
            this.lblMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMinimize.ForeColor = System.Drawing.Color.White;
            this.lblMinimize.Location = new System.Drawing.Point(832, 8);
            this.lblMinimize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimize.Size = new System.Drawing.Size(24, 21);
            this.lblMinimize.TabIndex = 2;
            this.lblMinimize.Text = "-";
            // 
            // lblBell
            // 
            this.lblBell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBell.AutoSize = true;
            this.lblBell.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblBell.Location = new System.Drawing.Point(795, 8);
            this.lblBell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBell.Name = "lblBell";
            this.lblBell.Size = new System.Drawing.Size(40, 30);
            this.lblBell.TabIndex = 1;
            this.lblBell.Text = "🔔";
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 81);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Khách hàng";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtNgayCapNhat);
            this.grbInfo.Controls.Add(this.lblNgayCapNhat);
            this.grbInfo.Controls.Add(this.txtNgayTao);
            this.grbInfo.Controls.Add(this.lblNgayTao);
            this.grbInfo.Controls.Add(this.txtDiaChi);
            this.grbInfo.Controls.Add(this.lblDiaChi);
            this.grbInfo.Controls.Add(this.txtSDT);
            this.grbInfo.Controls.Add(this.lblSDT);
            this.grbInfo.Controls.Add(this.txtMatKhau);
            this.grbInfo.Controls.Add(this.lblMatKhau);
            this.grbInfo.Controls.Add(this.txtEmail);
            this.grbInfo.Controls.Add(this.lblEmail);
            this.grbInfo.Controls.Add(this.txtTenKH);
            this.grbInfo.Controls.Add(this.lblTenKH);
            this.grbInfo.Controls.Add(this.txtMaKH);
            this.grbInfo.Controls.Add(this.lblMaKH);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(9, 86);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Size = new System.Drawing.Size(345, 390);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin khách hàng";
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.Location = new System.Drawing.Point(120, 318);
            this.txtNgayCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.ReadOnly = true;
            this.txtNgayCapNhat.Size = new System.Drawing.Size(211, 25);
            this.txtNgayCapNhat.TabIndex = 15;
            // 
            // lblNgayCapNhat
            // 
            this.lblNgayCapNhat.AutoSize = true;
            this.lblNgayCapNhat.Location = new System.Drawing.Point(11, 321);
            this.lblNgayCapNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayCapNhat.Name = "lblNgayCapNhat";
            this.lblNgayCapNhat.Size = new System.Drawing.Size(101, 19);
            this.lblNgayCapNhat.TabIndex = 14;
            this.lblNgayCapNhat.Text = "Ngày cập nhật:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.Location = new System.Drawing.Point(120, 278);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(211, 25);
            this.txtNgayTao.TabIndex = 13;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Location = new System.Drawing.Point(11, 280);
            this.lblNgayTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(68, 19);
            this.lblNgayTao.TabIndex = 12;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 237);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(211, 25);
            this.txtDiaChi.TabIndex = 11;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(11, 240);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(53, 19);
            this.lblDiaChi.TabIndex = 10;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(120, 197);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(211, 25);
            this.txtSDT.TabIndex = 9;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(11, 199);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(102, 19);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "* Số điện thoại:";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(120, 156);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(211, 25);
            this.txtMatKhau.TabIndex = 7;
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.Location = new System.Drawing.Point(11, 158);
            this.lblMatKhau.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(71, 19);
            this.lblMatKhau.TabIndex = 6;
            this.lblMatKhau.Text = "Mật khẩu:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(120, 115);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(211, 25);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(11, 118);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(120, 75);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(211, 25);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(11, 77);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(118, 19);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "* Tên khách hàng:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(120, 34);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(76, 25);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(11, 37);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(107, 19);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLamMoi.Location = new System.Drawing.Point(279, 484);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 16;
            this.btnLamMoi.Text = "Làm mời";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnSua);
            this.grbActions.Controls.Add(this.btnThem);
            this.grbActions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbActions.ForeColor = System.Drawing.Color.White;
            this.grbActions.Location = new System.Drawing.Point(58, 484);
            this.grbActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Name = "grbActions";
            this.grbActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Size = new System.Drawing.Size(195, 81);
            this.grbActions.TabIndex = 2;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Tác vụ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(105, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Controls.Add(this.btnTimKiem);
            this.grbSearch.Controls.Add(this.txtSearchSDT);
            this.grbSearch.Controls.Add(this.lblSearchSDT);
            this.grbSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbSearch.ForeColor = System.Drawing.Color.White;
            this.grbSearch.Location = new System.Drawing.Point(369, 86);
            this.grbSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbSearch.Size = new System.Drawing.Size(510, 81);
            this.grbSearch.TabIndex = 3;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Tìm kiếm khách hàng";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTimKiem.Location = new System.Drawing.Point(315, 30);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(90, 32);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtSearchSDT
            // 
            this.txtSearchSDT.Location = new System.Drawing.Point(112, 34);
            this.txtSearchSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSearchSDT.Name = "txtSearchSDT";
            this.txtSearchSDT.Size = new System.Drawing.Size(188, 25);
            this.txtSearchSDT.TabIndex = 1;
            // 
            // lblSearchSDT
            // 
            this.lblSearchSDT.AutoSize = true;
            this.lblSearchSDT.Location = new System.Drawing.Point(22, 37);
            this.lblSearchSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchSDT.Name = "lblSearchSDT";
            this.lblSearchSDT.Size = new System.Drawing.Size(92, 19);
            this.lblSearchSDT.TabIndex = 0;
            this.lblSearchSDT.Text = "Số điện thoại:";
            // 
            // grbList
            // 
            this.grbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbList.Controls.Add(this.dgvData);
            this.grbList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbList.ForeColor = System.Drawing.Color.White;
            this.grbList.Location = new System.Drawing.Point(369, 184);
            this.grbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Size = new System.Drawing.Size(510, 422);
            this.grbList.TabIndex = 4;
            this.grbList.TabStop = false;
            this.grbList.Text = "Danh sách khách hàng";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(2, 20);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(506, 400);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // FrmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(900, 718);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKhachHang";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FrmKhachHang_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbActions.ResumeLayout(false);
            this.grbSearch.ResumeLayout(false);
            this.grbSearch.PerformLayout();
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Label lblNgayCapNhat;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.Label lblSearchSDT;
        private System.Windows.Forms.TextBox txtSearchSDT;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblBell;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}
