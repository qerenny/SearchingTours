using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;



public interface ITravelPackageRepository
{
    void AddTravelPackage(TravelPackageEntity travelPackage);

    TravelPackageModel? GetTravelPackage(Guid id);

    void UpdateTravelPackage(TravelPackageEntity travelPackage);

    bool DeleteTravelPackage(TravelPackageEntity travelPackage);
}