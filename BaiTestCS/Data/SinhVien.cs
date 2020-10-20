namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            CLASSROOM = new HashSet<CLASSROOM>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string DIACHI { get; set; }

        [StringLength(10)]
        public string NGAYSINH { get; set; }

        [StringLength(10)]
        public string PHAI { get; set; }

        [StringLength(10)]
        public string HOTEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLASSROOM> CLASSROOM { get; set; }
    }
}
