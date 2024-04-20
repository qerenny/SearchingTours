using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Application.Contracts;

public interface IUserService
{
    UserEntity Register(string name, string phone, string email, string password, string city);

    UserEntity? GetUser(Guid id);

    UserEntity? UpdateUser(Guid id, Dictionary<string, string> data);

    bool DeleteUser(Guid id);
}