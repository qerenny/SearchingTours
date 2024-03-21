using SearchingTours.Infrastructure.Persistence.Configurations;
using SearchingTours.Infrastructure.Persistence.Entity;
using Microsoft.EntityFrameworkCore;

namespace SearchingTours.Infrastructure.Persistence.Contexts;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() { }
    public ApplicationDbContext(DbContextOptions options) : base(options) { }
    
    public required DbSet<UserEntity> Users { get; set; }
    public required DbSet<TravelPackageEntity> TravelPackages { get; set; }
    public required DbSet<TravelAgencyEntity> TravelAgencies { get; set; }
    public required DbSet<ReviewEntity> Reviews { get; set; }
    public required DbSet<PaymentItemEntity> PaymentItems { get; set; }
    public required DbSet<PaymentEntity> Payments { get; set; }
    public required DbSet<CartItemEntity> CartItems { get; set; }
    public required DbSet<CartEntity> Carts { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        modelBuilder.ApplyConfiguration(new UserEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TravelPackageEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TravelAgencyEntityConfiguration());
        modelBuilder.ApplyConfiguration(new ReviewEntityConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentItemEntityConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CartItemEntityConfiguration());
        modelBuilder.ApplyConfiguration(new CartEntityConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}