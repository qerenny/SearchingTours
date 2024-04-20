namespace SearchingTours.Application.Models;

public class TravelPackageModel : Interfaces.IEntity
{
    public Guid? Id { get; set; }
    
    public Guid? TravelAgencyId { get; set; }
    
    public string? Name { get; set; }
    
    public int? AmountOfPackage { get; set; }
    
    public int? AmountOfPeople { get; set; }
    
    public string? Destination { get; set; }
    
    public decimal? Price { get; set; }
    
    public double? Rating { get; set; }
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    public string? Description { get; set; }
    
    public TravelAgencyModel? TravelAgency { get; set; }
}