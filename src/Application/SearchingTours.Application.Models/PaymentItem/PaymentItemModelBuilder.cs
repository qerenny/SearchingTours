using SearchingTours.Application.Models.Payment;
using SearchingTours.Application.Models.TravelPackage;

namespace SearchingTours.Application.Models.PaymentItem;

public class PaymentItemModelBuilder
{
    private int _id;
    private PaymentModel? _payment;
    private TravelPackageModel? _travelPackage;
    private int _amount;

    public PaymentItemModelBuilder SetId(int id)
    {
        _id = id;
        return this;
    }

    public PaymentItemModelBuilder SetPayment(PaymentModel payment)
    {
        _payment = payment;
        return this;
    }

    public PaymentItemModelBuilder SetTravelPackage(TravelPackageModel travelPackage)
    {
        _travelPackage = travelPackage;
        return this;
    }

    public PaymentItemModelBuilder SetAmount(int amount)
    {
        _amount = amount;
        return this;
    }

    public PaymentItemModel Build()
    {
        return new PaymentItemModel(_id, _payment!, _travelPackage!, _amount);
    }
}