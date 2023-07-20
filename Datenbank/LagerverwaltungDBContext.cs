using Datenbank.Models;
using Microsoft.EntityFrameworkCore;

namespace Datenbank;

public class LagerverwaltungDBContext : DbContext
{
    public DbSet<Item> Item => Set<Item>();
    public DbSet<Location> Location => Set<Location>();
    public DbSet<FormFactor> FormFactor => Set<FormFactor>();
    public DbSet<CableType> CableType => Set<CableType>();
    public DbSet<Cable> Cable => Set<Cable>();
    public DbSet<Display> Display => Set<Display>();
    public DbSet<Other> Other => Set<Other>();
    public DbSet<ScreenSize> ScreenSize => Set<ScreenSize>();
    public DbSet<Manufacturer>  Manufacturer => Set<Manufacturer>();
    public DbSet<NetworkDevice> NetworkDevice => Set<NetworkDevice>();
    public DbSet<NetworkDeviceType> NetworkDeviceType => Set<NetworkDeviceType>();
    public DbSet<PeripheralType> PeripheralType => Set<PeripheralType>();
    public DbSet<Peripheral> Peripheral => Set<Peripheral>();
    public DbSet<StorageDevice> StorageDevice => Set<StorageDevice>();
    public DbSet<PC> PC => Set<PC>();


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
        modelBuilder.Entity<Peripheral>().ToTable("Peripheral");
        modelBuilder.Entity<StorageDevice>().ToTable("StorageDevice");
    }
}
