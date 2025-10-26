using Microsoft.EntityFrameworkCore;
using OMB.Domain.Entities;

namespace OMB.DataAccessLayer;

public partial class OMBContext : DbContext
{
    public OMBContext()
    { }
    public OMBContext(DbContextOptions<OMBContext> options):base(options)
    { }

    public virtual DbSet<Owner> Owners { get; set; } = null!;
    public virtual DbSet<Owner> Customer { get; set; } = null!;
   
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(x => x.Id);
            entity.ToTable("Omi_Owner", "dbo");
            entity.HasIndex(e => e.Id, "ClusteredIndex-20221009-030404")
            .IsUnique()
            .IsClustered();
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.BusinessName).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(10);
            entity.Property(e => e.DisplayName).HasMaxLength(5);
        });
        OnModelCreatingPartial(modelBuilder);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
    { }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
