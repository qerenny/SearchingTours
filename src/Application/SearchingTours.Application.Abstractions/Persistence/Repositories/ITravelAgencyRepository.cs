using SearchingTours.Application.Abstractions.Persistence.Queries;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Abstractions.Persistence.Repositories;

public interface ITravelAgencyRepository : IBaseRepository<TravelAgencyEntity>
{
    IAsyncEnumerable<TravelAgencyEntity> GetListByQuery(TravelAgencyQuery query);
}