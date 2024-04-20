using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Converters;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Application.Contracts.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public UserEntity Register(string name, string phone, string city, string email, string password)
    {
        var user = new UserEntity
        {
            Id = Guid.NewGuid(),
            Username = name,
            City = city,
            Password = password,
            Phone = phone,
            Email = email,
        };
        _userRepository.Add(user);
        return user;
    }

    public UserEntity? GetUser(Guid id)
    {
        var userModel = _userRepository.GetUser(id);

        return UserConverter.UserModelToUser(userModel);
    }

    public UserEntity? UpdateUser(Guid id, Dictionary<string, string> data)
    {
        UserModel? userToUpdate = _userRepository.GetUser(id);

        if (userToUpdate is null)
            throw new Exception("No such user");

        foreach (var entry in data)
        {
            switch (entry.Key)
            {
                case "username":
                    userToUpdate.Username = entry.Value;
                    break;
                case "city":
                    userToUpdate.City = entry.Value;
                    break;
                case "phone":
                    userToUpdate.Phone = entry.Value;
                    break;
                case "email":
                    userToUpdate.Email = entry.Value;
                    break;
            }
        }

        var user = UserConverter.UserModelToUser(userToUpdate);

        if (user is null)
            return null;

        _userRepository.UpdateUser(user);

        return UserConverter.UserModelToUser(userToUpdate);
    }

    public bool DeleteUser(Guid id)
    {
        return _userRepository.Delete(new UserEntity { Id = id });
    }
}