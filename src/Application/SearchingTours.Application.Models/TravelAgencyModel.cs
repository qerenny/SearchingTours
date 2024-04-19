using SearchingTours.Application.Models;

namespace SearchingTours.Application.Models;

public class TravelAgencyModel : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ContactInfo { get; set; } = null!;
    public string Password { get; set; } = null!;
}