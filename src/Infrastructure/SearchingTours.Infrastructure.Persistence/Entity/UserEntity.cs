using SearchingTours.Application.Models.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Entity;

public class UserEntity : IEntity
{
    public Guid? Id { get; set; }
    public string? Username { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? City { get; set; }
    public string? Phone { get; set; }
}