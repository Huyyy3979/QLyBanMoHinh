namespace QuanLyBanMoHinh.DAL.enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeriesGundam")]
    public partial class SeriesGundam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SeriesGundam()
        {
            Gundams = new HashSet<Gundam>();
        }

        [Key]
        public int MaSeries { get; set; }

        [Required]
        [StringLength(100)]
        public string TenSeries { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundam> Gundams { get; set; }
    }
}
