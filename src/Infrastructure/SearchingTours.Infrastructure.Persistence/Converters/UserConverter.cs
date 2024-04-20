using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Entity;

namespace SearchingTours.Infrastructure.Persistence.Converters;

public class UserConverter
{
    public static UserEntity? UserModelToUser(UserModel? userModel)
    {
        if (userModel is null)
            return null;

        return new UserEntity
        {
            Id = userModel.Id,
            Username = userModel.Username,
            Phone = userModel.Phone,
            Email = userModel.Email,
            Password = userModel.Password,
            City = userModel.City,
        };
    }
}