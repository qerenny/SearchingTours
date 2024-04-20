using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Converters;

public class TravelPackageConverter
{
    public static TravelPackageEntity? ModelToEntity(TravelPackageModel? model)
    {
        if (model is null)
            return null;

        return new TravelPackageEntity
        {
            Id = model.Id,
            AmountOfPackage = model.AmountOfPackage,
            AmountOfPeople = model.AmountOfPeople,
            Destination = model.Destination,
            Price = model.Price,
            Rating = model.Rating,
            StartDate = model.StartDate,
            EndDate = model.EndDate,
            Description = model.Description,
            TravelAgencyEntity = TravelAgencyConverter.ModelToEntity(model.TravelAgency),
        };
    }
}