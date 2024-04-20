namespace SearchingTours.Application.Models;

public class TravelAgencyModel : Interfaces.IEntity
{
    public Guid? Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? ContactInfo { get; set; }
    
    public string? Password { get; set; }
}