using SearchingTours.Application.Models.Payment;
using SearchingTours.Application.Models.TravelPackage;

namespace SearchingTours.Application.Models.PaymentItem;

public class PaymentItemModel
{
    private int Id { get; set; }
    private PaymentModel Payment { get; set; }
    private TravelPackageModel TravelPackage { get; set; }
    private int Amount { get; set; }

    public PaymentItemModel(int id, PaymentModel payment, TravelPackageModel travelPackage, int amount)
    {
        Id = id;
        Payment = payment;
        TravelPackage = travelPackage;
        Amount = amount;
    }

    public static PaymentItemModelBuilder Builder()
    {
        return new PaymentItemModelBuilder();
    }

    public int GetId()
    {
        return Id;
    }

    public PaymentModel GetPayment()
    {
        return Payment;
    }

    public TravelPackageModel GetTravelPackage()
    {
        return TravelPackage;
    }

    public int GetAmount()
    {
        return Amount;
    }
}