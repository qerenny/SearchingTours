namespace SearchingTours.Infrastructure.Persistence.Entity;

public class TravelPackageEntity
{
    public int Id { get; set; }
    public TravelAgencyEntity TravelAgencyId { get; set; }
    public int AmountOfPackages { get; set; }
    public string Name { get; set; }
    public int AmountOfPeople { get; set; }
    public string Destination { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double Rating { get; set; }
}