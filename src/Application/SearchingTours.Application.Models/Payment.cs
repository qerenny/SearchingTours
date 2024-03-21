namespace SearchingTours.Application.Models;

public class Payment(int id, User user, string paymentMethod, DateTime paymentDate, PaymentStatus status)
{
    public int Id { get; set; } = id;

    public User User { get; set; } = user;

    public string PaymentMethod { get; set; } = paymentMethod;

    public DateTime PaymentDate { get; set; } = paymentDate;

    public PaymentStatus Status { get; set; } = status;
}