namespace Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Khoa")]
    public partial class Khoa
    {
        public int Id { get; set; }

        [StringLength(500)]
        [Required]
        public string Ten { get; set; }

        //public virtual ICollection<Student> Students { get; set; }
    }
}
