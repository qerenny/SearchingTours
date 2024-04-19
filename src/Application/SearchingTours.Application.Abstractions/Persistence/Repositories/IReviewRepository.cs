using SearchingTours.Application.Abstractions.Persistence.Queries;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Abstractions.Persistence.Repositories;

public interface IReviewRepository : IBaseRepository<ReviewEntity>
{
    IAsyncEnumerable<ReviewEntity> GetListByQuery(ReviewQuery query);
}