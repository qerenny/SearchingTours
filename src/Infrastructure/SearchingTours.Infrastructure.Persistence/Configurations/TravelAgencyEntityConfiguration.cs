using SearchingTours.Infrastructure.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SearchingTours.Infrastructure.Persistence.Configurations;

public class TravelAgencyEntityConfiguration : IEntityTypeConfiguration<TravelAgencyEntity>
{
    public void Configure(EntityTypeBuilder<TravelAgencyEntity> builder)
    {
        builder.ToTable("TravelAgencies"); 
        builder.HasKey(u => u.Id); 
    }
}