using SearchingTours.Application.Models;

namespace SearchingTours.Infrastructure.Persistence.Entity;

public class TravelAgencyEntity : IEntity
{
    public Guid? Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Password { get; set; }
    
    public string? ContactInfo { get; set; }
}