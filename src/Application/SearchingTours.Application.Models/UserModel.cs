using SearchingTours.Application.Models;

namespace SearchingTours.Application.Models;

public class UserModel : IEntity
{
    public int Id { get; set; }
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public string City { get; set; } = null!;
    public string Phone { get; set; } = null!;
}