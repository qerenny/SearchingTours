using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Converters;

public class ReviewConverter
{
    public static ReviewEntity? ModelToEntity(ReviewModel? model)
    {
        if (model is null)
            return null;

        return new ReviewEntity
        {
            Id = model.Id,
            Text = model.Text,
            AuthorName = model.AuthorName,
            TravelPackageEntity = TravelPackageConverter.ModelToEntity(model.TravelPackage),
            Rating = model.Rating,
        };
    }
}