using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Uesan.Logistica.API.Models;

public partial class LogisticaDbContext : DbContext
{
    public LogisticaDbContext()
    {
    }

    public LogisticaDbContext(DbContextOptions<LogisticaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-AMFBBFK;Database=LogisticaDB;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
