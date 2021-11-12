using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace MobileShop.Models
{
    public partial class MobileShopContext : DbContext
    {
        public MobileShopContext()
        {
        }

        public MobileShopContext(DbContextOptions<MobileShopContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Anh> Anhs { get; set; }
        public virtual DbSet<Chitietdonhang> Chitietdonhangs { get; set; }
        public virtual DbSet<Donhang> Donhangs { get; set; }
        public virtual DbSet<Giohang> Giohangs { get; set; }
        public virtual DbSet<Hangsanxuat> Hangsanxuats { get; set; }
        public virtual DbSet<Nguoidung> Nguoidungs { get; set; }
        public virtual DbSet<PhanQuyen> PhanQuyens { get; set; }
        public virtual DbSet<Sanpham> Sanphams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DB"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Vietnamese_CI_AS");

            modelBuilder.Entity<Anh>(entity =>
            {
                entity.HasKey(e => e.Maanh);

                entity.ToTable("Anh");

                entity.Property(e => e.Url)
                    .IsUnicode(false)
                    .HasColumnName("URL");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany(p => p.Anhs)
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Anh_Sanpham");
            });

            modelBuilder.Entity<Chitietdonhang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chitietdonhang");

                entity.Property(e => e.Dongia).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Thanhtien).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MadonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Madon)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chitietdonhang_Donhang");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Chitietdonhang_Sanpham");
            });

            modelBuilder.Entity<Donhang>(entity =>
            {
                entity.HasKey(e => e.Madon);

                entity.ToTable("Donhang");

                entity.Property(e => e.Ngaydat).HasColumnType("datetime");

                entity.Property(e => e.Nguoinhan).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasMaxLength(15);

                entity.HasOne(d => d.MaNguoidungNavigation)
                    .WithMany(p => p.Donhangs)
                    .HasForeignKey(d => d.MaNguoidung)
                    .HasConstraintName("FK_Donhang_Khachhang");
            });

            modelBuilder.Entity<Giohang>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Giohang");

                entity.Property(e => e.Dongia).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.MaNguoiDungNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.MaNguoiDung)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giohang_Nguoidung");

                entity.HasOne(d => d.MaspNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Masp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Giohang_Sanpham");
            });

            modelBuilder.Entity<Hangsanxuat>(entity =>
            {
                entity.HasKey(e => e.Mahang);

                entity.ToTable("Hangsanxuat");

                entity.Property(e => e.Tenhang)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Nguoidung>(entity =>
            {
                entity.HasKey(e => e.MaNguoiDung)
                    .HasName("PK_Khachhang");

                entity.ToTable("Nguoidung");

                entity.Property(e => e.Diachi).HasMaxLength(100);

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Idquyen)
                    .HasColumnName("IDQuyen")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdquyenNavigation)
                    .WithMany(p => p.Nguoidungs)
                    .HasForeignKey(d => d.Idquyen)
                    .HasConstraintName("FK_Nguoidung_Nguoidung");
            });

            modelBuilder.Entity<PhanQuyen>(entity =>
            {
                entity.HasKey(e => e.Idquyen);

                entity.ToTable("PhanQuyen");

                entity.Property(e => e.Idquyen).HasColumnName("IDQuyen");

                entity.Property(e => e.TenQuyen).HasMaxLength(20);
            });

            modelBuilder.Entity<Sanpham>(entity =>
            {
                entity.HasKey(e => e.Masp);

                entity.ToTable("Sanpham");

                entity.Property(e => e.Chip).HasMaxLength(50);

                entity.Property(e => e.Dophangiai).HasMaxLength(50);

                entity.Property(e => e.Dosangtoida).HasMaxLength(50);

                entity.Property(e => e.Dungluongpin).HasMaxLength(50);

                entity.Property(e => e.Giatien).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Hedieuhanh).HasMaxLength(50);

                entity.Property(e => e.Kichthuoc).HasMaxLength(50);

                entity.Property(e => e.Manhinh).HasMaxLength(50);

                entity.Property(e => e.Mota).HasColumnType("ntext");

                entity.Property(e => e.Tensp).HasMaxLength(50);

                entity.HasOne(d => d.MahangNavigation)
                    .WithMany(p => p.Sanphams)
                    .HasForeignKey(d => d.Mahang)
                    .HasConstraintName("FK_Sanpham_Hangsanxuat");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
