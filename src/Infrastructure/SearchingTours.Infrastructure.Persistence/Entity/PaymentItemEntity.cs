namespace SearchingTours.Infrastructure.Persistence.Entity;

public class PaymentItemEntity(int id, PaymentEntity payment, TravelPackageEntity travelPackage, int amount)
{
    public int Id { get; set; } = id;
    public PaymentEntity Payment { get; set; } = payment;
    public TravelPackageEntity TravelPackage { get; set; } = travelPackage;
    public int Amount { get; set; } = amount;
}