namespace BaiTestCS.Models.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_SanPham()
        {
            tbl_ChiTiet = new HashSet<tbl_ChiTiet>();
        }

        [Key]
        [StringLength(50)]
        public string MaSanPham { get; set; }

        public string TenSP { get; set; }

        public int? MaL { get; set; }

        public int? MaSX { get; set; }

        public double? Gia { get; set; }

        public string GhiChu { get; set; }

        public string Hinh { get; set; }

        public int? SoLuongSP { get; set; }

        public double? TongTienSP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ChiTiet> tbl_ChiTiet { get; set; }

        public virtual tbl_Loai tbl_Loai { get; set; }

        public virtual tbl_NhaSanXuat tbl_NhaSanXuat { get; set; }
    }
}
