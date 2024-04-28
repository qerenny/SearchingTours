using SearchingTours.Application.Models.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Entity;

public class TravelPackageEntity : IEntity
{
    public Guid? Id { get; set; }
    
    public string? Name { get; set; }
    
    public int? AmountOfPeople { get; set; }
    
    public int? AmountOfPackage { get; set; }
    
    public string? Destination { get; set; }
    
    public decimal? Price { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public double? Rating { get; set; }
    
    public TravelAgencyEntity? TravelAgencyEntity { get; set; }

}