namespace SearchingTours.Infrastructure.Persistence.Entity;

public class CartItemEntity(int id, CartEntity cart, TravelPackageEntity travelPackage, int amount)
{
    public int Id { get; set; } = id;
    public CartEntity Cart { get; set; } = cart;
    public TravelPackageEntity TravelPackage { get; set; } = travelPackage;
    public int Amount { get; set; } = amount;
}