using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MIP;

public partial class MipContext : DbContext
{
    public MipContext()
    {
    }

    public MipContext(DbContextOptions<MipContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MedicalImage> MedicalImages { get; set; }

    public virtual DbSet<Prediction> Predictions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ADIL-PC\\SQLEXPRESS;Database=MIP;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MedicalImage>(entity =>
        {
            entity.HasKey(e => e.ImageId);
        });

        modelBuilder.Entity<Prediction>(entity =>
        {
            entity.HasIndex(e => e.ImageId, "IX_Predictions_ImageId");

            entity.HasOne(d => d.Image).WithMany(p => p.Predictions).HasForeignKey(d => d.ImageId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
