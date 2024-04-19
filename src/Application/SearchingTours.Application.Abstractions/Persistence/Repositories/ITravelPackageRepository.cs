using SearchingTours.Application.Abstractions.Persistence.Queries;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Abstractions.Persistence.Repositories;

public interface ITravelPackageRepository : IBaseRepository<TravelPackageEntity>
{
    IAsyncEnumerable<TravelPackageEntity> GetListByQuery(TravelPackageQuery query);
}