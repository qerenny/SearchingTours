namespace SearchingTours.Application.Models;

public class PaymentItem(int id, Payment payment, TravelPackage travelPackage, int amount)
{
    public int Id { get; set; } = id;

    public Payment Payment { get; set; } = payment;

    public TravelPackage TravelPackage { get; set; } = travelPackage;

    public int Amount { get; set; } = amount;
}