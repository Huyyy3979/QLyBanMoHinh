namespace QuanLyBanMoHinh.DAL.enities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GradeScale")]
    public partial class GradeScale
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GradeScale()
        {
            Gundams = new HashSet<Gundam>();
        }

        [Key]
        public int MaGrade { get; set; }

        [StringLength(50)]
        public string TenGrade { get; set; }

        [StringLength(20)]
        public string Scale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gundam> Gundams { get; set; }
    }
}
