using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace webCalculator.Models.ProjectModels;

public partial class ECommerceDatabaseContext : DbContext
{
    public ECommerceDatabaseContext()
    {
    }

    public ECommerceDatabaseContext(DbContextOptions<ECommerceDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ProductData> Proddta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-BQB64CV;Initial Catalog=e-commerce_database;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductData>(entity =>
        {
            entity.HasKey(e => e.ProdId).HasName("PK__proddta__042785E5DFABBAB9");

            entity.ToTable("proddta");

            entity.Property(e => e.ProdId).ValueGeneratedNever();
            entity.Property(e => e.ProdBrand)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProdCategory)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProdDescription)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.ProdPrice).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ProdTitle)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
