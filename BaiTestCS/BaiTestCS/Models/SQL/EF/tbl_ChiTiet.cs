namespace BaiTestCS.Models.SQL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string MaSP { get; set; }

        public int? SoLuongMua { get; set; }

        public double? TongTienMua { get; set; }

        public virtual tbl_HoaDon tbl_HoaDon { get; set; }

        public virtual tbl_SanPham tbl_SanPham { get; set; }
    }
}
