using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Contracts;

public interface ITravelAgencyService
{
    TravelAgencyEntity AddTravelAgency(string? name, string? contactInfo, string? password);

    TravelAgencyEntity? GetTravelAgency(Guid id);

    TravelAgencyEntity? UpdateTravelAgency(Guid id, Dictionary<string, string> data);

    bool DeleteTravelAgency(Guid id);
}