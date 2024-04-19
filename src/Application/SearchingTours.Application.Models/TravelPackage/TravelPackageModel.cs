using SearchingTours.Application.Models.TravelAgency;

namespace SearchingTours.Application.Models.TravelPackage;

public class TravelPackageModel
{
    private int Id { get; set; }
    
    private TravelAgencyModel TravelAgencyId { get; set; }
    private int AmountOfPackages { get; set; }
    
    private string Name { get; set; }
    
    private int AmountOfPeople { get; set; }
    
    private string Destination { get; set; }
    
    private decimal Price { get; set; }
    
    private string Description { get; set; }
    
    private DateTime StartDate { get; set; }
    
    private DateTime EndDate { get; set; }
    
    private double Rating { get; set; }
    
    public TravelPackageModel(int id, TravelAgencyModel travelAgencyId, int amountOfPackages, string name, int amountOfPeople, string destination, decimal price, string description, DateTime startDate, DateTime endDate, double rating)
    {
        Id = id;
        TravelAgencyId = travelAgencyId;
        AmountOfPackages = amountOfPackages;
        Name = name;
        AmountOfPeople = amountOfPeople;
        Destination = destination;
        Price = price;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Rating = rating;
    }

    public int GetId()
    {
        return Id;
    }

    public TravelAgencyModel GetTravelAgencyId()
    {
        return TravelAgencyId;
    }

    public int GetAmountOfPackages()
    {
        return AmountOfPackages;
    }

    public string GetName()
    {
        return Name;
    }

    public int GetAmountOfPeople()
    {
        return AmountOfPeople;
    }

    public string GetDestination()
    {
        return Destination;
    }

    public decimal GetPrice()
    {
        return Price;
    }

    public string GetDescription()
    {
        return Description;
    }

    public DateTime GetStartDate()
    {
        return StartDate;
    }

    public DateTime GetEndDate()
    {
        return EndDate;
    }

    public double GetRating()
    {
        return Rating;
    }
    
}
