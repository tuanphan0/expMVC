namespace Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QlSinhVienData : DbContext
    {
        public QlSinhVienData()
            : base("name=QlSinhVienData")
        {
        }

        public virtual DbSet<CLASSROOM> CLASSROOM { get; set; }
        public virtual DbSet<Khoa> Khoa { get; set; }
        public virtual DbSet<SinhVien> SinhVien { get; set; }

        public virtual DbSet<Student> Student { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVien>()
                .Property(e => e.DIACHI)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.NGAYSINH)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.PHAI)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.HOTEN)
                .IsFixedLength();
        }
    }
}
