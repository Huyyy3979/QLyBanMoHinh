namespace QuanLyBanMoHinh.GUI
{
    partial class FrmDanhSachGundam
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.picSelected = new System.Windows.Forms.PictureBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblHang = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.cboGrade = new System.Windows.Forms.ComboBox();
            this.cboHang = new System.Windows.Forms.ComboBox();
            this.cboSeries = new System.Windows.Forms.ComboBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenGundam = new System.Windows.Forms.TextBox();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.flpGundam = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.txtNgayCapNhat = new System.Windows.Forms.TextBox();
            this.lblNgayCapNhat = new System.Windows.Forms.Label();
            this.txtNgayTao = new System.Windows.Forms.TextBox();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(712, 49);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 8);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(249, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH SÁCH GUNDAM";
            // 
            // pnlInput
            // 
            this.pnlInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlInput.Controls.Add(this.btnSelectImage);
            this.pnlInput.Controls.Add(this.picSelected);
            this.pnlInput.Controls.Add(this.lblLoai);
            this.pnlInput.Controls.Add(this.lblGrade);
            this.pnlInput.Controls.Add(this.lblHang);
            this.pnlInput.Controls.Add(this.lblSeries);
            this.pnlInput.Controls.Add(this.lblGia);
            this.pnlInput.Controls.Add(this.lblTen);
            this.pnlInput.Controls.Add(this.cboLoai);
            this.pnlInput.Controls.Add(this.cboGrade);
            this.pnlInput.Controls.Add(this.cboHang);
            this.pnlInput.Controls.Add(this.cboSeries);
            this.pnlInput.Controls.Add(this.txtGia);
            this.pnlInput.Controls.Add(this.txtTenGundam);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 90);
            this.pnlInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(712, 106);
            this.pnlInput.TabIndex = 2;
            this.pnlInput.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(15, 85);
            this.btnSelectImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 19);
            this.btnSelectImage.TabIndex = 13;
            this.btnSelectImage.Text = "Chọn ảnh";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // picSelected
            // 
            this.picSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelected.Location = new System.Drawing.Point(15, 8);
            this.picSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSelected.Name = "picSelected";
            this.picSelected.Size = new System.Drawing.Size(76, 82);
            this.picSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelected.TabIndex = 12;
            this.picSelected.TabStop = false;
            // 
            // lblLoai
            // 
            this.lblLoai.ForeColor = System.Drawing.Color.White;
            this.lblLoai.Location = new System.Drawing.Point(540, 45);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(75, 19);
            this.lblLoai.TabIndex = 14;
            this.lblLoai.Text = "Loại:";
            // 
            // lblGrade
            // 
            this.lblGrade.ForeColor = System.Drawing.Color.White;
            this.lblGrade.Location = new System.Drawing.Point(540, 16);
            this.lblGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(75, 19);
            this.lblGrade.TabIndex = 15;
            this.lblGrade.Text = "Grade:";
            // 
            // lblHang
            // 
            this.lblHang.ForeColor = System.Drawing.Color.White;
            this.lblHang.Location = new System.Drawing.Point(352, 45);
            this.lblHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHang.Name = "lblHang";
            this.lblHang.Size = new System.Drawing.Size(75, 19);
            this.lblHang.TabIndex = 16;
            this.lblHang.Text = "Hãng SX:";
            // 
            // lblSeries
            // 
            this.lblSeries.ForeColor = System.Drawing.Color.White;
            this.lblSeries.Location = new System.Drawing.Point(352, 16);
            this.lblSeries.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(75, 19);
            this.lblSeries.TabIndex = 17;
            this.lblSeries.Text = "Series:";
            // 
            // lblGia
            // 
            this.lblGia.ForeColor = System.Drawing.Color.White;
            this.lblGia.Location = new System.Drawing.Point(105, 45);
            this.lblGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(75, 19);
            this.lblGia.TabIndex = 18;
            this.lblGia.Text = "Giá:";
            // 
            // lblTen
            // 
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(105, 16);
            this.lblTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(75, 19);
            this.lblTen.TabIndex = 19;
            this.lblTen.Text = "Tên Gundam:";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.Location = new System.Drawing.Point(615, 42);
            this.cboLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(91, 21);
            this.cboLoai.TabIndex = 11;
            // 
            // cboGrade
            // 
            this.cboGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrade.Location = new System.Drawing.Point(615, 14);
            this.cboGrade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboGrade.Name = "cboGrade";
            this.cboGrade.Size = new System.Drawing.Size(91, 21);
            this.cboGrade.TabIndex = 10;
            // 
            // cboHang
            // 
            this.cboHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHang.Location = new System.Drawing.Point(435, 42);
            this.cboHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboHang.Name = "cboHang";
            this.cboHang.Size = new System.Drawing.Size(91, 21);
            this.cboHang.TabIndex = 9;
            // 
            // cboSeries
            // 
            this.cboSeries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSeries.Location = new System.Drawing.Point(435, 14);
            this.cboSeries.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboSeries.Name = "cboSeries";
            this.cboSeries.Size = new System.Drawing.Size(91, 21);
            this.cboSeries.TabIndex = 8;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(188, 42);
            this.txtGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(151, 20);
            this.txtGia.TabIndex = 7;
            // 
            // txtTenGundam
            // 
            this.txtTenGundam.Location = new System.Drawing.Point(188, 14);
            this.txtTenGundam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenGundam.Name = "txtTenGundam";
            this.txtTenGundam.Size = new System.Drawing.Size(151, 20);
            this.txtTenGundam.TabIndex = 6;
            // 
            // pnlActions
            // 
            this.pnlActions.Controls.Add(this.btnHuy);
            this.pnlActions.Controls.Add(this.btnLuu);
            this.pnlActions.Controls.Add(this.btnXoa);
            this.pnlActions.Controls.Add(this.btnSua);
            this.pnlActions.Controls.Add(this.btnThem);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Location = new System.Drawing.Point(0, 49);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(712, 41);
            this.pnlActions.TabIndex = 3;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Green;
            this.btnHuy.Enabled = false;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(600, 8);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(68, 28);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLuu.Enabled = false;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(525, 8);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(68, 28);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(165, 8);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(90, 8);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 28);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(15, 8);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // flpGundam
            // 
            this.flpGundam.AutoScroll = true;
            this.flpGundam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.flpGundam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpGundam.Location = new System.Drawing.Point(0, 196);
            this.flpGundam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flpGundam.Name = "flpGundam";
            this.flpGundam.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flpGundam.Size = new System.Drawing.Size(712, 235);
            this.flpGundam.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pnlFooter.Controls.Add(this.txtNgayCapNhat);
            this.pnlFooter.Controls.Add(this.lblNgayCapNhat);
            this.pnlFooter.Controls.Add(this.txtNgayTao);
            this.pnlFooter.Controls.Add(this.lblNgayTao);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 431);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(712, 57);
            this.pnlFooter.TabIndex = 4;
            // 
            // txtNgayCapNhat
            // 
            this.txtNgayCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtNgayCapNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayCapNhat.ForeColor = System.Drawing.Color.White;
            this.txtNgayCapNhat.Location = new System.Drawing.Point(488, 32);
            this.txtNgayCapNhat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayCapNhat.Name = "txtNgayCapNhat";
            this.txtNgayCapNhat.ReadOnly = true;
            this.txtNgayCapNhat.Size = new System.Drawing.Size(210, 20);
            this.txtNgayCapNhat.TabIndex = 3;
            // 
            // lblNgayCapNhat
            // 
            this.lblNgayCapNhat.AutoSize = true;
            this.lblNgayCapNhat.ForeColor = System.Drawing.Color.White;
            this.lblNgayCapNhat.Location = new System.Drawing.Point(412, 34);
            this.lblNgayCapNhat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayCapNhat.Name = "lblNgayCapNhat";
            this.lblNgayCapNhat.Size = new System.Drawing.Size(80, 13);
            this.lblNgayCapNhat.TabIndex = 2;
            this.lblNgayCapNhat.Text = "Ngày cập nhật:";
            // 
            // txtNgayTao
            // 
            this.txtNgayTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.txtNgayTao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayTao.ForeColor = System.Drawing.Color.White;
            this.txtNgayTao.Location = new System.Drawing.Point(488, 8);
            this.txtNgayTao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayTao.Name = "txtNgayTao";
            this.txtNgayTao.ReadOnly = true;
            this.txtNgayTao.Size = new System.Drawing.Size(210, 20);
            this.txtNgayTao.TabIndex = 1;
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.ForeColor = System.Drawing.Color.White;
            this.lblNgayTao.Location = new System.Drawing.Point(412, 10);
            this.lblNgayTao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(53, 13);
            this.lblNgayTao.TabIndex = 0;
            this.lblNgayTao.Text = "Ngày tạo:";
            // 
            // FrmDanhSachGundam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(712, 488);
            this.Controls.Add(this.flpGundam);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDanhSachGundam";
            this.Text = "Danh sách Gundam";
            this.Load += new System.EventHandler(this.FrmDanhSachGundam_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelected)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpGundam;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picSelected;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.TextBox txtTenGundam;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.ComboBox cboSeries;
        private System.Windows.Forms.ComboBox cboHang;
        private System.Windows.Forms.ComboBox cboGrade;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblHang;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.TextBox txtNgayTao;
        private System.Windows.Forms.Label lblNgayCapNhat;
        private System.Windows.Forms.TextBox txtNgayCapNhat;
    }
}
