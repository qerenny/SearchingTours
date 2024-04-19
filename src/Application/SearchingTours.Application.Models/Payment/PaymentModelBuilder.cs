using SearchingTours.Application.Models.User;

namespace SearchingTours.Application.Models.Payment;

public class PaymentModelBuilder
{
    private int _id;
    private UserModel? _user;
    private string? _paymentMethod;
    private DateTime _paymentDate;
    private Status _status;

    public PaymentModelBuilder Id(int id)
    {
        _id = id;
        return this;
    }

    public PaymentModelBuilder User(UserModel user)
    {
        _user = user;
        return this;
    }

    public PaymentModelBuilder PaymentMethod(string paymentMethod)
    {
        _paymentMethod = paymentMethod;
        return this;
    }

    public PaymentModelBuilder PaymentDate(DateTime paymentDate)
    {
        _paymentDate = paymentDate;
        return this;
    }

    public PaymentModelBuilder Status(Status status)
    {
        _status = status;
        return this;
    }

    public PaymentModel Build()
    {
        return new PaymentModel(_id, _user!, _paymentMethod!, _paymentDate, _status);
    }
}
