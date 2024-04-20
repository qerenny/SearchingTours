using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Converters;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Application.Contracts.Services;

public class TravelAgencyService : ITravelAgencyService
{
    private readonly ITravelAgencyRepository _travelAgencyRepository;

    public TravelAgencyService(ITravelAgencyRepository repository)
    {
        _travelAgencyRepository = repository;
    }

    public TravelAgencyEntity AddTravelAgency(string? name, string? contactInfo, string? password)
    {
        var travelAgency = new TravelAgencyEntity
        {
            Id = Guid.NewGuid(),
            Name = name,
            Password = password,
            ContactInfo = contactInfo,
        };
        _travelAgencyRepository.AddTravelAgency(travelAgency);
        return travelAgency;
    }

    public TravelAgencyEntity? GetTravelAgency(Guid id)
    {
        TravelAgencyModel? travelAgencyModel = _travelAgencyRepository.GetTravelAgency(id);

        return TravelAgencyConverter.ModelToEntity(travelAgencyModel);
    }

    public TravelAgencyEntity? UpdateTravelAgency(Guid id, Dictionary<string, string> data)
    {
        TravelAgencyModel? toUpdate = _travelAgencyRepository.GetTravelAgency(id);

        if (toUpdate is null)
            throw new Exception("No such user");

        foreach (KeyValuePair<string, string> entry in data)
        {
            switch (entry.Key)
            {
                case "name":
                    toUpdate.Name = entry.Value;
                    break;
                case "contactInfo":
                    toUpdate.ContactInfo = entry.Value;
                    break;
            }
        }

        TravelAgencyEntity? travelAgency = TravelAgencyConverter.ModelToEntity(toUpdate);

        if (travelAgency is null)
            return null;

        _travelAgencyRepository.UpdateTravelAgency(travelAgency);

        return TravelAgencyConverter.ModelToEntity(toUpdate);
    }

    public bool DeleteTravelAgency(Guid id)
    {
        return _travelAgencyRepository.DeleteTravelAgency(new TravelAgencyEntity { Id = id });
    }
}