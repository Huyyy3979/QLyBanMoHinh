namespace QuanLyBanMoHinh.GUI
{
    partial class CategoryCardControl
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
            this.lblTenLoai = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTenLoai
            // 
            this.lblTenLoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenLoai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTenLoai.ForeColor = System.Drawing.Color.White;
            this.lblTenLoai.Location = new System.Drawing.Point(0, 0);
            this.lblTenLoai.Name = "lblTenLoai";
            this.lblTenLoai.Size = new System.Drawing.Size(200, 60);
            this.lblTenLoai.TabIndex = 0;
            this.lblTenLoai.Text = "Tên Loại";
            this.lblTenLoai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTenLoai.Click += new System.EventHandler(this.Content_Click);
            // 
            // CategoryCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.lblTenLoai);
            this.Name = "CategoryCardControl";
            this.Size = new System.Drawing.Size(200, 60);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTenLoai;
    }
}
