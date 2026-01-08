namespace QuanLyBanMoHinh.GUI
{
    partial class FrmDoanhThu
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

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.numYear = new System.Windows.Forms.NumericUpDown();
            this.lblFilterDay = new System.Windows.Forms.Label();
            this.lblFilterMonth = new System.Windows.Forms.Label();
            this.lblFilterYear = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlToday = new System.Windows.Forms.Panel();
            this.lblTodayVal = new System.Windows.Forms.Label();
            this.lblTodayTitle = new System.Windows.Forms.Label();
            this.pnlMonth = new System.Windows.Forms.Panel();
            this.lblMonthVal = new System.Windows.Forms.Label();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.lblYearVal = new System.Windows.Forms.Label();
            this.lblYearTitle = new System.Windows.Forms.Label();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.pnlHeader.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).BeginInit();
            this.pnlCards.SuspendLayout();
            this.pnlToday.SuspendLayout();
            this.pnlMonth.SuspendLayout();
            this.pnlYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1000, 60);
            this.pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO DOANH THU CHI TIẾT";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.lblFilterYear);
            this.pnlFilters.Controls.Add(this.lblFilterMonth);
            this.pnlFilters.Controls.Add(this.lblFilterDay);
            this.pnlFilters.Controls.Add(this.numYear);
            this.pnlFilters.Controls.Add(this.cboMonth);
            this.pnlFilters.Controls.Add(this.dtpDay);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Location = new System.Drawing.Point(0, 60);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(1000, 70);
            this.pnlFilters.TabIndex = 1;
            // 
            // dtpDay
            // 
            this.dtpDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDay.Location = new System.Drawing.Point(100, 25);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(150, 22);
            this.dtpDay.TabIndex = 0;
            this.dtpDay.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // cboMonth
            // 
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(350, 25);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(120, 24);
            this.cboMonth.TabIndex = 1;
            this.cboMonth.SelectedIndexChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // numYear
            // 
            this.numYear.Location = new System.Drawing.Point(550, 25);
            this.numYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            this.numYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            this.numYear.Name = "numYear";
            this.numYear.Size = new System.Drawing.Size(100, 22);
            this.numYear.TabIndex = 2;
            this.numYear.Value = new decimal(new int[] { 2024, 0, 0, 0 });
            this.numYear.ValueChanged += new System.EventHandler(this.Filter_Changed);
            // 
            // lblFilterDay
            // 
            this.lblFilterDay.AutoSize = true;
            this.lblFilterDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterDay.Location = new System.Drawing.Point(20, 26);
            this.lblFilterDay.Name = "lblFilterDay";
            this.lblFilterDay.Size = new System.Drawing.Size(74, 20);
            this.lblFilterDay.TabIndex = 3;
            this.lblFilterDay.Text = "Theo ngày:";
            // 
            // lblFilterMonth
            // 
            this.lblFilterMonth.AutoSize = true;
            this.lblFilterMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterMonth.Location = new System.Drawing.Point(265, 26);
            this.lblFilterMonth.Name = "lblFilterMonth";
            this.lblFilterMonth.Size = new System.Drawing.Size(81, 20);
            this.lblFilterMonth.TabIndex = 4;
            this.lblFilterMonth.Text = "Theo tháng:";
            // 
            // lblFilterYear
            // 
            this.lblFilterYear.AutoSize = true;
            this.lblFilterYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterYear.Location = new System.Drawing.Point(475, 26);
            this.lblFilterYear.Name = "lblFilterYear";
            this.lblFilterYear.Size = new System.Drawing.Size(74, 20);
            this.lblFilterYear.TabIndex = 5;
            this.lblFilterYear.Text = "Theo năm:";
            // 
            // pnlCards
            // 
            this.pnlCards.Controls.Add(this.pnlYear);
            this.pnlCards.Controls.Add(this.pnlMonth);
            this.pnlCards.Controls.Add(this.pnlToday);
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Location = new System.Drawing.Point(0, 130);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCards.Size = new System.Drawing.Size(1000, 140);
            this.pnlCards.TabIndex = 2;
            // 
            // pnlToday
            // 
            this.pnlToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.pnlToday.Controls.Add(this.lblTodayVal);
            this.pnlToday.Controls.Add(this.lblTodayTitle);
            this.pnlToday.Location = new System.Drawing.Point(20, 20);
            this.pnlToday.Name = "pnlToday";
            this.pnlToday.Size = new System.Drawing.Size(300, 100);
            this.pnlToday.TabIndex = 0;
            // 
            // lblTodayVal
            // 
            this.lblTodayVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTodayVal.ForeColor = System.Drawing.Color.White;
            this.lblTodayVal.Location = new System.Drawing.Point(0, 45);
            this.lblTodayVal.Name = "lblTodayVal";
            this.lblTodayVal.Size = new System.Drawing.Size(300, 45);
            this.lblTodayVal.TabIndex = 1;
            this.lblTodayVal.Text = "0 VND";
            this.lblTodayVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTodayTitle
            // 
            this.lblTodayTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTodayTitle.ForeColor = System.Drawing.Color.White;
            this.lblTodayTitle.Location = new System.Drawing.Point(0, 10);
            this.lblTodayTitle.Name = "lblTodayTitle";
            this.lblTodayTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTodayTitle.TabIndex = 0;
            this.lblTodayTitle.Text = "HÔM NAY";
            this.lblTodayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMonth
            // 
            this.pnlMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pnlMonth.Controls.Add(this.lblMonthVal);
            this.pnlMonth.Controls.Add(this.lblMonthTitle);
            this.pnlMonth.Location = new System.Drawing.Point(340, 20);
            this.pnlMonth.Name = "pnlMonth";
            this.pnlMonth.Size = new System.Drawing.Size(300, 100);
            this.pnlMonth.TabIndex = 1;
            // 
            // lblMonthVal
            // 
            this.lblMonthVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMonthVal.ForeColor = System.Drawing.Color.White;
            this.lblMonthVal.Location = new System.Drawing.Point(0, 45);
            this.lblMonthVal.Name = "lblMonthVal";
            this.lblMonthVal.Size = new System.Drawing.Size(300, 45);
            this.lblMonthVal.TabIndex = 1;
            this.lblMonthVal.Text = "0 VND";
            this.lblMonthVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMonthTitle
            // 
            this.lblMonthTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMonthTitle.ForeColor = System.Drawing.Color.White;
            this.lblMonthTitle.Location = new System.Drawing.Point(0, 10);
            this.lblMonthTitle.Name = "lblMonthTitle";
            this.lblMonthTitle.Size = new System.Drawing.Size(300, 30);
            this.lblMonthTitle.TabIndex = 0;
            this.lblMonthTitle.Text = "THÁNG NÀY";
            this.lblMonthTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlYear
            // 
            this.pnlYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.pnlYear.Controls.Add(this.lblYearVal);
            this.pnlYear.Controls.Add(this.lblYearTitle);
            this.pnlYear.Location = new System.Drawing.Point(660, 20);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(300, 100);
            this.pnlYear.TabIndex = 2;
            // 
            // lblYearVal
            // 
            this.lblYearVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblYearVal.ForeColor = System.Drawing.Color.White;
            this.lblYearVal.Location = new System.Drawing.Point(0, 45);
            this.lblYearVal.Name = "lblYearVal";
            this.lblYearVal.Size = new System.Drawing.Size(300, 45);
            this.lblYearVal.TabIndex = 1;
            this.lblYearVal.Text = "0 VND";
            this.lblYearVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYearTitle
            // 
            this.lblYearTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYearTitle.ForeColor = System.Drawing.Color.White;
            this.lblYearTitle.Location = new System.Drawing.Point(0, 10);
            this.lblYearTitle.Name = "lblYearTitle";
            this.lblYearTitle.Size = new System.Drawing.Size(300, 30);
            this.lblYearTitle.TabIndex = 0;
            this.lblYearTitle.Text = "NĂM NAY";
            this.lblYearTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.BackgroundColor = System.Drawing.Color.White;
            this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 270);
            this.dgvData.Name = "dgvData";
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(1000, 375);
            this.dgvData.TabIndex = 3;
            // 
            // FrmDoanhThu
            // 
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDoanhThu";
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.FrmDoanhThu_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYear)).EndInit();
            this.pnlCards.ResumeLayout(false);
            this.pnlToday.ResumeLayout(false);
            this.pnlMonth.ResumeLayout(false);
            this.pnlYear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.NumericUpDown numYear;
        private System.Windows.Forms.Label lblFilterDay;
        private System.Windows.Forms.Label lblFilterMonth;
        private System.Windows.Forms.Label lblFilterYear;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlToday;
        private System.Windows.Forms.Label lblTodayVal;
        private System.Windows.Forms.Label lblTodayTitle;
        private System.Windows.Forms.Panel pnlMonth;
        private System.Windows.Forms.Label lblMonthVal;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.Label lblYearVal;
        private System.Windows.Forms.Label lblYearTitle;
        private System.Windows.Forms.DataGridView dgvData;
    }
}
