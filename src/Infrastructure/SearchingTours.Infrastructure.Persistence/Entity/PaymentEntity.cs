namespace SearchingTours.Application.Models;

public class PaymentEntity(int id, UserEntity user, string paymentMethod, DateTime paymentDate, PaymentStatusEntity status)
{
    public int Id { get; set; } = id;

    public UserEntity User { get; set; } = user;

    public string PaymentMethod { get; set; } = paymentMethod;

    public DateTime PaymentDate { get; set; } = paymentDate;

    public PaymentStatusEntity Status { get; set; } = status;
}