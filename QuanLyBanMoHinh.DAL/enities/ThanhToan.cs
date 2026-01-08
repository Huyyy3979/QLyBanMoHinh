namespace QuanLyBanMoHinh.DAL.enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThanhToan")]
    public partial class ThanhToan
    {
        [Key]
        public int MaTT { get; set; }

        public int? MaDon { get; set; }

        [StringLength(50)]
        public string PhuongThuc { get; set; }

        [StringLength(50)]
        public string TrangThai { get; set; }

        public virtual DonBan DonBan { get; set; }
    }
}
