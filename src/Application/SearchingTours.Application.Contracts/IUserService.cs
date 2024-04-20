using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Contracts;

public interface IUserService
{
    UserEntity Create(string? name, string? phone, string? email, string? password, string? city);

    UserEntity? GetUser(Guid id);

    UserEntity? Update(Guid id, Dictionary<string, string> data);

    bool Delete(Guid id);
}