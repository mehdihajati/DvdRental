using DataLayer.Mapping;
using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace DataLayer;

public class DVdDbContext : DbContext
{
    public DVdDbContext(DbContextOptions<DVdDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new ActorMap());
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DVdDbContext).Assembly);
        modelBuilder.HasDefaultSchema("Retntal");
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Film> FilmList { get; set; }
    public DbSet<Film_actor> Film_Actors { get; set; }
    public DbSet<Film_category> Film_Categories { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Rental> Rentals { get; set; }
    public DbSet<Staff> Staffs { get; set; }
    public DbSet<Store> Stores { get; set; }
}
