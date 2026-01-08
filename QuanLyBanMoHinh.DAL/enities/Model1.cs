using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanMoHinh.DAL.enities
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
            // Tự động thêm cột nếu thiếu để tránh lỗi SqlException
            try
            {
                Database.ExecuteSqlCommand(@"
                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Gundam]') AND name = 'NgayTao')
                    ALTER TABLE [Gundam] ADD [NgayTao] DATETIME NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[Gundam]') AND name = 'NgayCapNhat')
                    ALTER TABLE [Gundam] ADD [NgayCapNhat] DATETIME NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[LoaiSanPham]') AND name = 'NgayTao')
                    ALTER TABLE [LoaiSanPham] ADD [NgayTao] DATETIME NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[LoaiSanPham]') AND name = 'NgayCapNhat')
                    ALTER TABLE [LoaiSanPham] ADD [NgayCapNhat] DATETIME NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[ChiTietPhieuNhap]') AND name = 'GiaNhap')
                    ALTER TABLE [ChiTietPhieuNhap] ADD [GiaNhap] DECIMAL(18, 2) NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[ChiTietPhieuXuat]') AND name = 'GiaXuat')
                    ALTER TABLE [ChiTietPhieuXuat] ADD [GiaXuat] DECIMAL(18, 2) NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[KhachHang]') AND name = 'MatKhau')
                    ALTER TABLE [KhachHang] ADD [MatKhau] NVARCHAR(100) NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[KhachHang]') AND name = 'DiaChi')
                    ALTER TABLE [KhachHang] ADD [DiaChi] NVARCHAR(255) NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[KhachHang]') AND name = 'NgayTao')
                    ALTER TABLE [KhachHang] ADD [NgayTao] DATETIME NULL;

                    IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID(N'[KhachHang]') AND name = 'NgayCapNhat')
                    ALTER TABLE [KhachHang] ADD [NgayCapNhat] DATETIME NULL;
                ");
            }
            catch { /* Bỏ qua nếu có lỗi quyền truy cập */ }
        }

        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<ChiTietPhieuNhap> ChiTietPhieuNhaps { get; set; }
        public virtual DbSet<ChiTietPhieuXuat> ChiTietPhieuXuats { get; set; }
        public virtual DbSet<DonBan> DonBans { get; set; }
        public virtual DbSet<GradeScale> GradeScales { get; set; }
        public virtual DbSet<Gundam> Gundams { get; set; }
        public virtual DbSet<HangSanXuat> HangSanXuats { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<SeriesGundam> SeriesGundams { get; set; }
        public virtual DbSet<ThanhToan> ThanhToans { get; set; }
        public virtual DbSet<TonKho> TonKhoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDonHang>()
                .Property(e => e.DonGia)
                .HasPrecision(12, 2);

            modelBuilder.Entity<DonBan>()
                .Property(e => e.TongTien)
                .HasPrecision(14, 2);

            modelBuilder.Entity<DonBan>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.DonBan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gundam>()
                .Property(e => e.Gia)
                .HasPrecision(12, 2);

            modelBuilder.Entity<Gundam>()
                .HasMany(e => e.ChiTietDonHangs)
                .WithRequired(e => e.Gundam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gundam>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.Gundam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gundam>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.Gundam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gundam>()
                .HasOptional(e => e.TonKho)
                .WithRequired(e => e.Gundam);

            modelBuilder.Entity<PhieuNhap>()
                .HasMany(e => e.ChiTietPhieuNhaps)
                .WithRequired(e => e.PhieuNhap)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuXuat>()
                .HasMany(e => e.ChiTietPhieuXuats)
                .WithRequired(e => e.PhieuXuat)
                .WillCascadeOnDelete(false);
        }
    }
}
