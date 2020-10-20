namespace BaiTestCS.Models.SQL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLDongHo : DbContext
    {
        public QLDongHo()
            : base("name=QLDongHo")
        {
        }

        public virtual DbSet<tbl_ChiTiet> tbl_ChiTiet { get; set; }
        public virtual DbSet<tbl_HoaDon> tbl_HoaDon { get; set; }
        public virtual DbSet<tbl_KhachHang> tbl_KhachHang { get; set; }
        public virtual DbSet<tbl_Loai> tbl_Loai { get; set; }
        public virtual DbSet<tbl_NhaSanXuat> tbl_NhaSanXuat { get; set; }
        public virtual DbSet<tbl_SanPham> tbl_SanPham { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tbl_HoaDon>()
                .HasMany(e => e.tbl_ChiTiet)
                .WithRequired(e => e.tbl_HoaDon)
                .HasForeignKey(e => e.MaHD)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tbl_KhachHang>()
                .HasMany(e => e.tbl_HoaDon)
                .WithOptional(e => e.tbl_KhachHang)
                .HasForeignKey(e => e.MaKH);

            modelBuilder.Entity<tbl_Loai>()
                .HasMany(e => e.tbl_SanPham)
                .WithOptional(e => e.tbl_Loai)
                .HasForeignKey(e => e.MaL);

            modelBuilder.Entity<tbl_NhaSanXuat>()
                .HasMany(e => e.tbl_SanPham)
                .WithOptional(e => e.tbl_NhaSanXuat)
                .HasForeignKey(e => e.MaSX);

            modelBuilder.Entity<tbl_SanPham>()
                .HasMany(e => e.tbl_ChiTiet)
                .WithRequired(e => e.tbl_SanPham)
                .HasForeignKey(e => e.MaSP)
                .WillCascadeOnDelete(false);
        }
    }
}
