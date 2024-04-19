using SearchingTours.Application.Abstractions.Persistence.Queries;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Abstractions.Persistence.Repositories;

public interface IUserRepository : IBaseRepository<UserEntity>
{
    IAsyncEnumerable<UserEntity> GetListByQuery(UserQuery query);
}