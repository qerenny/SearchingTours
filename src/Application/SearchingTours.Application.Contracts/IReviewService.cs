using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Contracts;

public interface IReviewService
{
    ReviewEntity AddReview(Guid travelPackageId, string? authorName, string? text, int? rating);

    ReviewEntity? GetReview(Guid id);

    ReviewEntity? UpdateReview(Guid id, Dictionary<string, string> data);

    bool Delete(Guid id);
}