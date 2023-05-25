using Datenbank.Models;
using Microsoft.EntityFrameworkCore;

namespace Datenbank;

public class LagerverwaltungDBContext : DbContext
{
    public DbSet<Item> Item { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<FormFactor> FormFactor { get; set; }
    public DbSet<CableType> CableType { get; set; }

    static readonly string connectionString = "Server=localhost; User ID=root; Password=Chance2015 ;Database=Lagersoftware";

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasSequence<int>("ItemIds");

        modelBuilder.Entity<Item>()
            .UseTpcMappingStrategy()
            .Property(e => e.ID).HasDefaultValueSql("(NEXT VALUE FOR ItemIds)");
        modelBuilder.Entity<Cable>().ToTable("Cable");
        modelBuilder.Entity<Display>().ToTable("Display");
        modelBuilder.Entity<NetworkDevice>().ToTable("NetworkDevice");
        modelBuilder.Entity<Other>().ToTable("Other");
        modelBuilder.Entity<PC>().ToTable("PC");
        modelBuilder.Entity<StorageDevice>().ToTable("StorageDevice");
    }
}
