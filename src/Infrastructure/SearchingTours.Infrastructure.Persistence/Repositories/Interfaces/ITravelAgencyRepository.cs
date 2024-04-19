using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

public interface ITravelAgencyRepository
{
    void AddTravelAgency(TravelAgencyEntity travelAgency);

    TravelAgencyModel? GetTravelAgency(Guid id);

    void UpdateTravelAgency(TravelAgencyEntity travelAgency);

    bool DeleteTravelAgency(TravelAgencyEntity travelAgency);
}