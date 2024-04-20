using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

public interface IUserRepository
{
    void Add(UserEntity user);

    UserModel? GetUser(Guid id);

    void UpdateUser(UserEntity user);

    bool Delete(UserEntity user);
}