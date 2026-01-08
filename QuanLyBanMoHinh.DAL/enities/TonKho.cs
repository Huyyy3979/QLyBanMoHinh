namespace QuanLyBanMoHinh.DAL.enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TonKho")]
    public partial class TonKho
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGundam { get; set; }

        public int? SoLuongTon { get; set; }

        public virtual Gundam Gundam { get; set; }
    }
}
