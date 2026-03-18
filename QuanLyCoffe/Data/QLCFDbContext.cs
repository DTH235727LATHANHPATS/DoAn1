using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace QuanLyCoffe.Data
{
    public class QLCFDbContext : DbContext
    {
        public DbSet<LoaiSanPham> LoaiSanPham { get; set; }
        public DbSet<SanPham> SanPham { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<Ban> Ban { get; set; }
        public DbSet<PhanCongNhanVien> PhanCongNhanVien { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public DbSet<NhaCungCap> NhaCungCap { get; set; }
        public DbSet<NguyenLieu> NguyenLieu { get; set; }
        public DbSet<PhieuNhap> PhieuNhap { get; set; }
        public DbSet<ChiTietPhieuNhap> ChiTietPhieuNhap { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["QLCFConnection"].ConnectionString
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SanPham>()
                .Property(p => p.Gia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<HoaDon>()
                .Property(p => p.TongTien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<PhieuNhap>()
                .Property(p => p.TongTien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(p => p.DonGia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietHoaDon>()
                .Property(p => p.ThanhTien)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(p => p.DonGia)
                .HasPrecision(18, 2);

            modelBuilder.Entity<ChiTietPhieuNhap>()
                .Property(p => p.ThanhTien)
                .HasPrecision(18, 2);

            // SỬA LỖI CASCADE
            modelBuilder.Entity<ChiTietPhieuNhap>()
                .HasOne(ct => ct.PhieuNhap)
                .WithMany(p => p.ChiTietPhieuNhap)
                .HasForeignKey(ct => ct.PhieuNhapID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ChiTietHoaDon>()
                .HasOne(ct => ct.HoaDon)
                .WithMany(h => h.ChiTietHoaDon)
                .HasForeignKey(ct => ct.HoaDonID)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
