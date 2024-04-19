using DoctorsHelp.Application.Models;
using SearchingTours.Application.Models;

namespace SearchingTours.Application.Models;

public class TravelPackageModel : IEntity
{
    public Guid? Id { get; set; }
    
    public Guid? TravelAgencyId { get; set; }
    
    public string? Name { get; set; }
    
    public int? AmountOfPackage { get; set; }
    
    public int? AmountOfPeople { get; set; }
    
    public int? Price { get; set; }
    
    public int? Rating { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public string? Description { get; set; }
    
    public TravelAgencyModel? TravelAgency { get; set; }
}