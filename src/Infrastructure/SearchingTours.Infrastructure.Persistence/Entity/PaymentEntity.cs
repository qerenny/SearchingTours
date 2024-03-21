namespace SearchingTours.Infrastructure.Persistence.Entity;

public class PaymentEntity(int id, UserEntity user, string paymentMethod, DateTime paymentDate, Status status)
{
    public int Id { get; set; } = id;
    public UserEntity User { get; set; } = user;
    public string PaymentMethod { get; set; } = paymentMethod;
    public DateTime PaymentDate { get; set; } = paymentDate;
    public Status Status { get; set; } = status;
}

public enum Status 
{
    Paid,
    Canceled, 
    PaidPartiauly,
}