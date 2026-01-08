namespace QuanLyBanMoHinh.GUI
{
    partial class FrmThanhToan
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
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtPhuongThuc = new System.Windows.Forms.TextBox();
            this.lblPhuongThuc = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.lblMaTT = new System.Windows.Forms.Label();
            this.grbActions = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbList = new System.Windows.Forms.GroupBox();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.grbInfo.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(750, 81);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(712, 8);
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
            this.lblMinimize.Location = new System.Drawing.Point(682, 8);
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
            this.lblBell.Location = new System.Drawing.Point(645, 8);
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
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(750, 81);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thanh toán";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.btnLamMoi);
            this.grbInfo.Controls.Add(this.txtPhuongThuc);
            this.grbInfo.Controls.Add(this.lblPhuongThuc);
            this.grbInfo.Controls.Add(this.txtMaTT);
            this.grbInfo.Controls.Add(this.lblMaTT);
            this.grbInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbInfo.ForeColor = System.Drawing.Color.White;
            this.grbInfo.Location = new System.Drawing.Point(15, 98);
            this.grbInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbInfo.Size = new System.Drawing.Size(322, 162);
            this.grbInfo.TabIndex = 1;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Thông tin phương thức";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnLamMoi.Location = new System.Drawing.Point(225, 114);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 28);
            this.btnLamMoi.TabIndex = 4;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtPhuongThuc
            // 
            this.txtPhuongThuc.Location = new System.Drawing.Point(112, 75);
            this.txtPhuongThuc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPhuongThuc.Name = "txtPhuongThuc";
            this.txtPhuongThuc.Size = new System.Drawing.Size(188, 23);
            this.txtPhuongThuc.TabIndex = 3;
            // 
            // lblPhuongThuc
            // 
            this.lblPhuongThuc.AutoSize = true;
            this.lblPhuongThuc.Location = new System.Drawing.Point(15, 77);
            this.lblPhuongThuc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhuongThuc.Name = "lblPhuongThuc";
            this.lblPhuongThuc.Size = new System.Drawing.Size(97, 15);
            this.lblPhuongThuc.TabIndex = 2;
            this.lblPhuongThuc.Text = "* Tên thanh toán:";
            // 
            // txtMaTT
            // 
            this.txtMaTT.Location = new System.Drawing.Point(112, 34);
            this.txtMaTT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(76, 23);
            this.txtMaTT.TabIndex = 1;
            // 
            // lblMaTT
            // 
            this.lblMaTT.AutoSize = true;
            this.lblMaTT.Location = new System.Drawing.Point(15, 37);
            this.lblMaTT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaTT.Name = "lblMaTT";
            this.lblMaTT.Size = new System.Drawing.Size(96, 15);
            this.lblMaTT.TabIndex = 0;
            this.lblMaTT.Text = "* Mã thanh toán:";
            // 
            // grbActions
            // 
            this.grbActions.Controls.Add(this.btnXoa);
            this.grbActions.Controls.Add(this.btnSua);
            this.grbActions.Controls.Add(this.btnThem);
            this.grbActions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbActions.ForeColor = System.Drawing.Color.White;
            this.grbActions.Location = new System.Drawing.Point(15, 268);
            this.grbActions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Name = "grbActions";
            this.grbActions.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbActions.Size = new System.Drawing.Size(322, 81);
            this.grbActions.TabIndex = 2;
            this.grbActions.TabStop = false;
            this.grbActions.Text = "Tác vụ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoa.Location = new System.Drawing.Point(195, 32);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSua.Location = new System.Drawing.Point(105, 32);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 28);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnThem.Location = new System.Drawing.Point(15, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbList
            // 
            this.grbList.Controls.Add(this.dgvData);
            this.grbList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grbList.ForeColor = System.Drawing.Color.White;
            this.grbList.Location = new System.Drawing.Point(352, 98);
            this.grbList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Name = "grbList";
            this.grbList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbList.Size = new System.Drawing.Size(382, 374);
            this.grbList.TabIndex = 3;
            this.grbList.TabStop = false;
            this.grbList.Text = "Danh sách phương thức thanh toán";
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
            this.dgvData.Location = new System.Drawing.Point(2, 18);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvData.Size = new System.Drawing.Size(378, 354);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
            // 
            // FrmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.grbList);
            this.Controls.Add(this.grbActions);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThanhToan";
            this.Text = "Phương thức thanh toán";
            this.Load += new System.EventHandler(this.FrmThanhToan_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grbActions.ResumeLayout(false);
            this.grbList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label lblMaTT;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label lblPhuongThuc;
        private System.Windows.Forms.TextBox txtPhuongThuc;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grbActions;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.GroupBox grbList;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.Label lblBell;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
    }
}
