namespace QuanLyBanMoHinh.DAL.enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietPhieuXuat")]
    public partial class ChiTietPhieuXuat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPX { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGundam { get; set; }

        public int? SoLuong { get; set; }

        public decimal? GiaXuat { get; set; }

        public virtual Gundam Gundam { get; set; }

        public virtual PhieuXuat PhieuXuat { get; set; }
    }
}
