using SearchingTours.Infrastructure.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SearchingTours.Infrastructure.Persistence.Configurations;

public class TravelPackageEntityConfiguration : IEntityTypeConfiguration<TravelPackageEntity>
{
    public void Configure(EntityTypeBuilder<TravelPackageEntity> builder)
    {
        builder.ToTable("TravelPackages"); 
        builder.HasKey(u => u.Id); 
    }
}