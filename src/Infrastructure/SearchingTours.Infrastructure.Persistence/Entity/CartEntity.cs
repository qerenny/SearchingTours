namespace SearchingTours.Application.Models;

public class CartEntity(UserEntity user)
{
    public int Id { get; set; }
    
    public UserEntity User { get; set; } = user;
}