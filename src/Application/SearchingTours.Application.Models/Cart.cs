namespace SearchingTours.Application.Models;

public class Cart(User user)
{
    public int Id { get; set; }
    
    public User User { get; set; } = user;
}