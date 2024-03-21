using SearchingTours.Infrastructure.Persistence.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SearchingTours.Infrastructure.Persistence.Configurations;

public class PaymentItemEntityConfiguration : IEntityTypeConfiguration<PaymentItemEntity>
{
    public void Configure(EntityTypeBuilder<PaymentItemEntity> builder)
    {
        builder.ToTable("PaymentItems"); 
        builder.HasKey(u => u.Id); 
    }
}