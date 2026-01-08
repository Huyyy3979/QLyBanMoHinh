namespace QuanLyBanMoHinh.GUI
{
    partial class FrmPhieuXuat
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
            this.txtNgayXuat = new System.Windows.Forms.TextBox();
            this.lblNgayXuat = new System.Windows.Forms.Label();
            this.txtGiaXuat = new System.Windows.Forms.TextBox();
            this.lblGiaXuat = new System.Windows.Forms.Label();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.cboTenGundam = new System.Windows.Forms.ComboBox();
            this.lblTenGundam = new System.Windows.Forms.Label();
            this.cboMaGundam = new System.Windows.Forms.ComboBox();
            this.lblMaGundam = new System.Windows.Forms.Label();
            this.txtMaPX = new System.Windows.Forms.TextBox();
            this.lblMaPX = new System.Windows.Forms.Label();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXuatKho = new System.Windows.Forms.Button();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.grbActions.SuspendLayout();
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(900, 81);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Xuất kho";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.txtNgayXuat);
            this.grbInfo.Controls.Add(this.lblNgayXuat);
            this.grbInfo.Controls.Add(this.txtGiaXuat);
            this.grbInfo.Controls.Add(this.lblGiaXuat);
            this.grbInfo.Controls.Add(this.numSoLuong);
            this.grbInfo.Controls.Add(this.lblSoLuong);
            this.grbInfo.Controls.Add(this.cboTenGundam);
            this.grbInfo.Controls.Add(this.lblTenGundam);
            this.grbInfo.Controls.Add(this.cboMaGundam);
            this.grbInfo.Controls.Add(this.lblMaGundam);
            this.grbInfo.Controls.Add(this.txtMaPX);
            this.grbInfo.Controls.Add(this.lblMaPX);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(15, 98);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Size = new System.Drawing.Size(322, 260);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin phiếu xuất";
            // 
            // txtNgayXuat
            // 
            this.txtNgayXuat.Location = new System.Drawing.Point(120, 217);
            this.txtNgayXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNgayXuat.Name = "txtNgayXuat";
            this.txtNgayXuat.ReadOnly = true;
            this.txtNgayXuat.Size = new System.Drawing.Size(188, 25);
            this.txtNgayXuat.TabIndex = 11;
            // 
            // lblNgayXuat
            // 
            this.lblNgayXuat.AutoSize = true;
            this.lblNgayXuat.Location = new System.Drawing.Point(15, 219);
            this.lblNgayXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayXuat.Name = "lblNgayXuat";
            this.lblNgayXuat.Size = new System.Drawing.Size(74, 19);
            this.lblNgayXuat.TabIndex = 10;
            this.lblNgayXuat.Text = "Ngày xuất:";
            // 
            // txtGiaXuat
            // 
            this.txtGiaXuat.Location = new System.Drawing.Point(120, 180);
            this.txtGiaXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaXuat.Name = "txtGiaXuat";
            this.txtGiaXuat.Size = new System.Drawing.Size(121, 25);
            this.txtGiaXuat.TabIndex = 9;
            // 
            // lblGiaXuat
            // 
            this.lblGiaXuat.AutoSize = true;
            this.lblGiaXuat.Location = new System.Drawing.Point(15, 183);
            this.lblGiaXuat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGiaXuat.Name = "lblGiaXuat";
            this.lblGiaXuat.Size = new System.Drawing.Size(72, 19);
            this.lblGiaXuat.TabIndex = 8;
            this.lblGiaXuat.Text = "* Giá xuất:";
            // 
            // numSoLuong
            // 
            this.numSoLuong.Location = new System.Drawing.Point(120, 145);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(60, 25);
            this.numSoLuong.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 146);
            this.lblSoLuong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(76, 19);
            this.lblSoLuong.TabIndex = 6;
            this.lblSoLuong.Text = "* Số lượng:";
            // 
            // cboTenGundam
            // 
            this.cboTenGundam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTenGundam.FormattingEnabled = true;
            this.cboTenGundam.Location = new System.Drawing.Point(120, 107);
            this.cboTenGundam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTenGundam.Name = "cboTenGundam";
            this.cboTenGundam.Size = new System.Drawing.Size(188, 25);
            this.cboTenGundam.TabIndex = 5;
            this.cboTenGundam.SelectedIndexChanged += new System.EventHandler(this.cboGundam_SelectedIndexChanged);
            // 
            // lblTenGundam
            // 
            this.lblTenGundam.AutoSize = true;
            this.lblTenGundam.Location = new System.Drawing.Point(15, 110);
            this.lblTenGundam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenGundam.Name = "lblTenGundam";
            this.lblTenGundam.Size = new System.Drawing.Size(98, 19);
            this.lblTenGundam.TabIndex = 4;
            this.lblTenGundam.Text = "* Tên linh kiện:";
            // 
            // cboMaGundam
            // 
            this.cboMaGundam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaGundam.FormattingEnabled = true;
            this.cboMaGundam.Location = new System.Drawing.Point(120, 71);
            this.cboMaGundam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaGundam.Name = "cboMaGundam";
            this.cboMaGundam.Size = new System.Drawing.Size(188, 25);
            this.cboMaGundam.TabIndex = 3;
            this.cboMaGundam.SelectedIndexChanged += new System.EventHandler(this.cboGundam_SelectedIndexChanged);
            // 
            // lblMaGundam
            // 
            this.lblMaGundam.AutoSize = true;
            this.lblMaGundam.Location = new System.Drawing.Point(15, 73);
            this.lblMaGundam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaGundam.Name = "lblMaGundam";
            this.lblMaGundam.Size = new System.Drawing.Size(97, 19);
            this.lblMaGundam.TabIndex = 2;
            this.lblMaGundam.Text = "* Mã linh kiện:";
            // 
            // txtMaPX
            // 
            this.txtMaPX.Location = new System.Drawing.Point(120, 34);
            this.txtMaPX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(91, 25);
            this.txtMaPX.TabIndex = 1;
            // 
            // lblMaPX
            // 
            this.lblMaPX.AutoSize = true;
            this.lblMaPX.Location = new System.Drawing.Point(15, 37);
            this.lblMaPX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaPX.Name = "lblMaPX";
            this.lblMaPX.Size = new System.Drawing.Size(100, 19);
            this.lblMaPX.TabIndex = 0;
            this.lblMaPX.Text = "Mã phiếu xuất:";
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnLamMoi);
            this.grbActions.Controls.Add(this.btnXuatKho);
            this.grbActions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbActions.ForeColor = System.Drawing.Color.White;
            this.grbActions.Location = new System.Drawing.Point(135, 374);
            this.grbActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Name = "grbActions";
            this.grbActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Size = new System.Drawing.Size(202, 81);
            this.grbActions.TabIndex = 2;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Tác vụ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLamMoi.Location = new System.Drawing.Point(105, 32);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 32);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXuatKho
            // 
            this.btnXuatKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnXuatKho.Location = new System.Drawing.Point(15, 32);
            this.btnXuatKho.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXuatKho.Name = "btnXuatKho";
            this.btnXuatKho.Size = new System.Drawing.Size(82, 32);
            this.btnXuatKho.TabIndex = 0;
            this.btnXuatKho.Text = "Xuất kho";
            this.btnXuatKho.UseVisualStyleBackColor = false;
            this.btnXuatKho.Click += new System.EventHandler(this.btnXuatKho_Click);
            // 
            // grbList
            // 
            this.grbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbList.Controls.Add(this.dgvData);
            this.grbList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grbList.ForeColor = System.Drawing.Color.White;
            this.grbList.Location = new System.Drawing.Point(352, 98);
            this.grbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Size = new System.Drawing.Size(458, 374);
            this.grbList.TabIndex = 3;
            this.grbList.TabStop = false;
            this.grbList.Text = "Danh sách phiếu xuất";
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
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
            this.dgvData.Size = new System.Drawing.Size(454, 352);
            this.dgvData.TabIndex = 0;
            // 
            // FrmPhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(900, 569);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPhieuXuat";
            this.Text = "Xuất kho";
            this.Load += new System.EventHandler(this.FrmPhieuXuat_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.grbActions.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblMaPX;
        private System.Windows.Forms.TextBox txtMaPX;
        private System.Windows.Forms.Label lblMaGundam;
        private System.Windows.Forms.ComboBox cboMaGundam;
        private System.Windows.Forms.Label lblTenGundam;
        private System.Windows.Forms.ComboBox cboTenGundam;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Label lblGiaXuat;
        private System.Windows.Forms.TextBox txtGiaXuat;
        private System.Windows.Forms.Label lblNgayXuat;
        private System.Windows.Forms.TextBox txtNgayXuat;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnXuatKho;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblBell;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}
