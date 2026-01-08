namespace QuanLyBanMoHinh.GUI
{
    partial class GundamCardControl
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
            this.picHinh = new System.Windows.Forms.PictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.pnlBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // picHinh
            // 
            this.picHinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHinh.Location = new System.Drawing.Point(0, 0);
            this.picHinh.Name = "picHinh";
            this.picHinh.Size = new System.Drawing.Size(180, 180);
            this.picHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHinh.Padding = new System.Windows.Forms.Padding(5);
            this.picHinh.TabIndex = 0;
            this.picHinh.TabStop = false;
            this.picHinh.Click += new System.EventHandler(this.Content_Click);
            // 
            // lblTen
            // 
            this.lblTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTen.ForeColor = System.Drawing.Color.White;
            this.lblTen.Location = new System.Drawing.Point(5, 5);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(170, 45);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên Gundam";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTen.Click += new System.EventHandler(this.Content_Click);
            // 
            // lblGia
            // 
            this.lblGia.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblGia.Location = new System.Drawing.Point(5, 50);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(170, 25);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "0đ";
            this.lblGia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGia.Click += new System.EventHandler(this.Content_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.lblGia);
            this.pnlBottom.Controls.Add(this.lblTen);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 180);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Padding = new System.Windows.Forms.Padding(5);
            this.pnlBottom.Size = new System.Drawing.Size(180, 100);
            this.pnlBottom.TabIndex = 3;
            this.pnlBottom.Click += new System.EventHandler(this.Content_Click);
            // 
            // GundamCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.picHinh);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "GundamCardControl";
            this.Size = new System.Drawing.Size(180, 280);
            this.Click += new System.EventHandler(this.Content_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picHinh)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHinh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Panel pnlBottom;
    }
}
