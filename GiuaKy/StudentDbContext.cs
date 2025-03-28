using GiuaKy.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace GiuaKy
{


    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Sinhvien> SinhViens { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<DiemThi> DiemThis { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiemThi>()
                .HasKey(dt => new { dt.MaSV, dt.MaMH });

            modelBuilder.Entity<DiemThi>()
                .HasOne(dt => dt.SinhVien)
                .WithMany(sv => sv.DiemThis)
                .HasForeignKey(dt => dt.MaSV);

            modelBuilder.Entity<DiemThi>()
                .HasOne(dt => dt.MonHoc)
                .WithMany(mh => mh.DiemThis)
                .HasForeignKey(dt => dt.MaMH);
        }
    }
}