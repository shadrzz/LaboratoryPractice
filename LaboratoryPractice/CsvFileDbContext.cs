using System;
using System.Collections.Generic;
using LaboratoryPractice.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratoryPractice;

public partial class CsvFileDbContext : DbContext
{
    public CsvFileDbContext()
    {
    }

    public CsvFileDbContext(DbContextOptions<CsvFileDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Info> Infos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost;Database=CSV_FILE_DB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Info>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Info");

            entity.Property(e => e.AccessDate).HasMaxLength(255);
            entity.Property(e => e.AccessMode).HasMaxLength(255);
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
