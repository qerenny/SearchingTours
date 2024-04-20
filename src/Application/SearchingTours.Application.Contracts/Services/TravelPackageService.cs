using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Converters;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Application.Contracts.Services;

public class TravelPackageService : ITravelPackageService
{
    private readonly ITravelPackageRepository _travelPackageRepository;
    private readonly ITravelAgencyRepository _travelAgencyRepository;

    public TravelPackageService(ITravelPackageRepository repository, ITravelAgencyRepository travelAgencyRepository)
    {
        _travelPackageRepository = repository;
        _travelAgencyRepository = travelAgencyRepository;
    }

    public TravelPackageEntity AddTravelPackage(string name, Guid travelAgencyId, int amountOfPeople, int amountOfPackage, string destination, decimal price, string description, DateTime startDate, DateTime endDate, int rating)
    {
        TravelAgencyEntity? travelAgency = TravelAgencyConverter.ModelToEntity(_travelAgencyRepository.GetTravelAgency(travelAgencyId));
        
        if (travelAgency is null)
            throw new Exception("travelPackage doesnt exist");

        var travelPackage = new TravelPackageEntity
        {
            Id = Guid.NewGuid(),
            Name = name, 
            AmountOfPackage = amountOfPeople, 
            AmountOfPeople = amountOfPackage, 
            Destination = destination, 
            Price = price, 
            TravelAgencyEntity = travelAgency,
            Description = description, 
            StartDate = startDate, 
            EndDate = endDate, 
            Rating = rating,
        };
        _travelPackageRepository.AddTravelPackage(travelPackage);
        return travelPackage;
    }

    public TravelPackageEntity? GetTravelPackage(Guid id)
    {
        var model = _travelPackageRepository.GetTravelPackage(id);

        return TravelPackageConverter.ModelToEntity(model);
    }

    public TravelPackageEntity? UpdateTravelPackage(Guid id, Dictionary<string, string> data)
    {
        TravelPackageModel? toUpdate = _travelPackageRepository.GetTravelPackage(id);

        if (toUpdate is null)
            throw new Exception("No such user");

        foreach (var entry in data)
        {
            switch (entry.Key)
            {
                case "name":
                    toUpdate.Name = entry.Value;
                    break;
                case "destination":
                    toUpdate.Destination = entry.Value;
                    break;
                case "description":
                    toUpdate.Description = entry.Value;
                    break;
                case "travelAgencyId":
                    Guid travelAgencyId;
                    if (Guid.TryParse(entry.Value, out travelAgencyId))
                        toUpdate.TravelAgencyId = travelAgencyId;
                    break;
                case "amountOfPackage":
                    int amountOfPackage;
                    if (int.TryParse(entry.Value, out amountOfPackage))
                        toUpdate.AmountOfPackage = amountOfPackage;
                    break;
                case "amountOfPeople":
                    int amountOfPeople;
                    if (int.TryParse(entry.Value, out amountOfPeople))
                        toUpdate.AmountOfPeople = amountOfPeople;
                    break;
                case "price":
                    int price;
                    if (int.TryParse(entry.Value, out price))
                        toUpdate.Price = price;
                    break;
                case "rating":
                    int grade;
                    if (int.TryParse(entry.Value, out grade))
                        toUpdate.Rating = grade;
                    break;
                case "dateStart":
                    toUpdate.StartDate = new DateTime(Convert.ToInt32(entry.Value));
                    break;
                case "dateEnd":
                    toUpdate.EndDate = new DateTime(Convert.ToInt32(entry.Value));
                    break;
            }
        }

        var travelPackage = TravelPackageConverter.ModelToEntity(toUpdate);

        if (travelPackage is null)
            return null;

        _travelPackageRepository.UpdateTravelPackage(travelPackage);

        return TravelPackageConverter.ModelToEntity(toUpdate);
    }

    public bool DeleteTravelPackage(Guid id)
    {
        return _travelPackageRepository.DeleteTravelPackage(new TravelPackageEntity { Id = id });
    }
}