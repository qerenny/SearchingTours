namespace SearchingTours.Application.Models;

public class CartItem(int id, Cart cart, TravelPackage travelPackage, int amount)
{
    public int Id { get; set; } = id;

    public Cart Cart { get; set; } = cart;

    public TravelPackage TravelPackage { get; set; } = travelPackage;

    public int Amount { get; set; } = amount;
}