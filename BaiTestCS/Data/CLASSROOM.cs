namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CLASSROOM")]
    public partial class CLASSROOM
    {
        [Key]
        public int IDKHOA { get; set; }

        public string CLASS { get; set; }

        public string ROOM { get; set; }

        public int? ID { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
