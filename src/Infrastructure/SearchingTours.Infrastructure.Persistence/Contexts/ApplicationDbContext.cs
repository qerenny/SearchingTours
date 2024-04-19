using Microsoft.EntityFrameworkCore;
using SearchingTours.Application.Models;

namespace SearchingTours.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
    public required DbSet<UserModel> Users { get; set; }
    
    public required DbSet<TravelPackageModel> TravelPackages { get; set; }
    
    public required DbSet<TravelAgencyModel> TravelAgencies { get; set; }
    
    public required DbSet<ReviewModel> Reviews { get; set; }
    
    // public required DbSet<CartItemEntity> CartItems { get; set; }
    //
    // public required DbSet<CartEntity> Carts { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        // base.OnModelCreating(modelBuilder);
    }
}