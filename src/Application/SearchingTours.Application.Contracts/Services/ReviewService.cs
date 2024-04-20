using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Converters;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Application.Contracts.Services;

public class ReviewService : IReviewService
{
    private readonly IReviewRepository _reviewRepository;
    private readonly ITravelPackageRepository _travelPackageRepository;

    public ReviewService(IReviewRepository repository, ITravelPackageRepository travelPackageRepository)
    {
        _reviewRepository = repository;
        _travelPackageRepository = travelPackageRepository;
    }

    public ReviewEntity AddReview(Guid travelPackageId, string authorName, string text, int rating)
    {
        TravelPackageEntity? travelPackage = TravelPackageConverter.ModelToEntity(_travelPackageRepository.GetTravelPackage(travelPackageId));
        
        if (travelPackage is null)
            throw new Exception("travelPackage doesnt exist");

        var review = new ReviewEntity
        {
            Id = Guid.NewGuid(),
            TravelPackageEntity = travelPackage, 
            AuthorName = authorName, 
            Text = text, 
            Rating = rating,
        };
        _reviewRepository.AddReview(review);
        return review;
    }

    public ReviewEntity? GetReview(Guid id)
    {
        var model = _reviewRepository.GetReview(id);

        return ReviewConverter.ModelToEntity(model);
    }

    public ReviewEntity? UpdateReview(Guid id, Dictionary<string, string> data)
    {
        ReviewModel? toUpdate = _reviewRepository.GetReview(id);

        if (toUpdate is null)
            throw new Exception("No such user");

        foreach (var entry in data)
        {
            switch (entry.Key)
            {
                case "text":
                    toUpdate.Text = entry.Value;
                    break;
                case "travelPackageId":
                    Guid travelPackageId;
                    if (Guid.TryParse(entry.Value, out travelPackageId))
                        toUpdate.TravelPackageId = travelPackageId;
                    break;
                case "rating":
                    int grade;
                    if (int.TryParse(entry.Value, out grade))
                        toUpdate.Rating = grade;
                    break;
                case "authorName":
                    toUpdate.AuthorName = entry.Value;
                    break;
            }
        }

        var review = ReviewConverter.ModelToEntity(toUpdate);

        if (review is null)
            return null;

        _reviewRepository.UpdateReview(review);

        return ReviewConverter.ModelToEntity(toUpdate);
    }

    public bool Delete(Guid id)
    {
        return _reviewRepository.Delete(new ReviewEntity { Id = id });
    }
}