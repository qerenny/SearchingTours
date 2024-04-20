using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Contracts;

public interface ITravelPackageService
{
    TravelPackageEntity AddTravelPackage(string name, Guid travelAgencyId, int amountOfPeople, int amountOfPackage, string destination, decimal price, string description, DateTime startDate, DateTime endDate, int rating);

    TravelPackageEntity? GetTravelPackage(Guid id);

    TravelPackageEntity? UpdateTravelPackage(Guid id, Dictionary<string, string> data);

    bool DeleteTravelPackage(Guid id);
}