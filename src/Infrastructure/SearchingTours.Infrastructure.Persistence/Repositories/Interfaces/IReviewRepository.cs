using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

public interface IReviewRepository
{
    void AddReview(ReviewEntity review);

    ReviewModel? GetReview(Guid id);

    void UpdateReview(ReviewEntity review);

    bool Delete(ReviewEntity review);
}