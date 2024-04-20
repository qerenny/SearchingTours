using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Converters;

public class TravelAgencyConverter
{
    public static TravelAgencyEntity? ModelToEntity(TravelAgencyModel? model)
    {
        if (model is null)
            return null;

        return new TravelAgencyEntity
        {
            Id = model.Id,
            Name = model.Name,
            ContactInfo = model.ContactInfo,
            Password = model.Password,
        };
    }
}