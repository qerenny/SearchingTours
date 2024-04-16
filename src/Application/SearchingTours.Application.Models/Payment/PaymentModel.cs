using SearchingTours.Application.Models.User;

namespace SearchingTours.Application.Models.Payment;

public class PaymentModel
{
    private int Id { get; set; }
    private UserModel User { get; set; }
    private string PaymentMethod { get; set; }
    private DateTime PaymentDate { get; set; }
    private Status Status { get; set; }
    
    public PaymentModel(int id, UserModel user, string paymentMethod, DateTime paymentDate, Status status)
    {
        Id = id;
        User = user;
        PaymentMethod = paymentMethod;
        PaymentDate = paymentDate;
        Status = status;
    }

    public static PaymentModelBuilder Builder()
    {
        return new PaymentModelBuilder();
    }

    public int GetId() => Id;
    public UserModel GetUser() => User;
    public string GetPaymentMethod() => PaymentMethod;
    public DateTime GetPaymentDate() => PaymentDate;
    public Status GetStatus() => Status;
}
