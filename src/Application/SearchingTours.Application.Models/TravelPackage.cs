namespace SearchingTours.Application.Models;

public class TravelPackage(
    int id,
    TravelAgency travelAgencyId,
    int amountOfPackages,
    string name,
    int amountOfPeople,
    string destination,
    decimal price,
    string description,
    DateTime startDate,
    DateTime endDate,
    double rating)
{
    public int Id { get; set; } = id;

    public TravelAgency TravelAgencyId { get; set; } = travelAgencyId;

    public int AmountOfPackages { get; set; } = amountOfPackages;

    public string Name { get; set; } = name;

    public int AmountOfPeople { get; set; } = amountOfPeople;

    public string Destination { get; set; } = destination;

    public decimal Price { get; set; } = price;

    public string Description { get; set; } = description;

    public DateTime StartDate { get; set; } = startDate;

    public DateTime EndDate { get; set; } = endDate;

    public double Rating { get; set; } = rating;
}