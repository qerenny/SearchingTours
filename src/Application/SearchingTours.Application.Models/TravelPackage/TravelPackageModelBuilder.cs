using SearchingTours.Application.Models.TravelAgency;

namespace SearchingTours.Application.Models.TravelPackage;

public class TravelPackageModelBuilder
{
    private int _id;
    private TravelAgencyModel? _travelAgencyId;
    private int _amountOfPackages;
    private string? _name;
    private int _amountOfPeople;
    private string? _destination;
    private decimal _price;
    private string? _description;
    private DateTime _startDate;
    private DateTime _endDate;
    private double _rating;

    public TravelPackageModelBuilder Id(int id)
    {
        _id = id;
        return this;
    }
    
    public TravelPackageModelBuilder TravelAgencyId(TravelAgencyModel travelAgencyId)
    {
        _travelAgencyId = travelAgencyId;
        return this;
    }
    
    public TravelPackageModelBuilder AmountOfPackages(int amountOfPackages)
    {
        _amountOfPackages = amountOfPackages;
        return this;
    }
    
    public TravelPackageModelBuilder Name(string name)
    {
        _name = name;
        return this;
    }
    
    public TravelPackageModelBuilder AmountOfPeople(int amountOfPeople)
    {
        _amountOfPeople = amountOfPeople;
        return this;
    }
    
    public TravelPackageModelBuilder Destination(string destination)
    {
        _destination = destination;
        return this;
    }
    
    public TravelPackageModelBuilder Price(decimal price)
    {
        _price = price;
        return this;
    }
    
    public TravelPackageModelBuilder Description(string description)
    {
        _description = description;
        return this;
    }
    
    public TravelPackageModelBuilder StartDate(DateTime startDate)
    {
        _startDate = startDate;
        return this;
    }
    
    public TravelPackageModelBuilder EndDate(DateTime endDate)
    {
        _endDate = endDate;
        return this;
    }
    
    public TravelPackageModelBuilder Rating(double rating)
    {
        _rating = rating;
        return this;
    }

    public TravelPackageModel Build()
    {
        return new TravelPackageModel(_id, _travelAgencyId!, _amountOfPackages, _name!, _amountOfPeople, _destination!,
            _price, _description!, _startDate, _endDate, _rating);
    }
}