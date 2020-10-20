namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        public string DiaChi { get; set; }

        [StringLength(500)]
        public string TenSV { get; set; }

        [StringLength(500)]
        public string NgaySinh { get; set; }

        [StringLength(500)]
        public string GioiTinh { get; set; }

        [Column("IdKhoa")]
        public int KhoaId { get; set; }
        public Khoa Khoa { get; set; }
    }
}
