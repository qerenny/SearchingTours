namespace SearchingTours.Presentation.Http.Requests;

public class TravelPackagePost
{
    public Guid TravelAgencyId { get; set; }
    
    public int AmountOfPackages { get; set; }
    
    public string? Name { get; set; }
    
    public int AmountOfPeople { get; set; }
    
    public string? Destination { get; set; }
    
    public decimal Price { get; set; }
    
    public string? Description { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }
    
    public int Rating { get; set; }
}