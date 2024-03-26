using SearchingTours.Application.Abstractions.Persistence.Repositories.Interfaces;
using SearchingTours.Application.Models.User;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Utils;
using Microsoft.EntityFrameworkCore;

namespace SearchingTours.Infrastructure.Persistence.Repositories;

public class UserRepository(ApplicationDbContext context) : IUserRepository
{
    public async Task<UserModel?> FindUserById(int userId)
    {
        var userEntity = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);
        return userEntity != null ? MapEntityToModel(userEntity) : null;
    }

    public async Task CreateUser(UserModel userModel)
    {
        var newUserEntity = new UserEntity
        {
            Id = Generator.GenerateRandomId(),
            Username = userModel.GetUsername(),
            Email = userModel.GetEmail(),
            City = userModel.GetCity(),
            Phone = userModel.GetPhone(),
            Password = userModel.GetPassword()
        };

        context.Users.Add(newUserEntity);
        await context.SaveChangesAsync();
    }

    public async Task UpdateUserInfo(UserModel userModel)
    {
        var userEntityToUpdate = MapModelToEntity(userModel);
        context.Entry(userEntityToUpdate).State = EntityState.Modified;
        await context.SaveChangesAsync();
    }

    public async Task DeleteUser(UserModel userModel)
    {
        var userEntityToDelete = MapModelToEntity(userModel);
        context.Users.Remove(await userEntityToDelete);
        await context.SaveChangesAsync();
    }

    private UserModel MapEntityToModel(UserEntity user)
    {
        return UserModel.Builder()
            .Id(user.Id)
            .Username(user.Username)
            .Email(user.Email)
            .Phone(user.Phone)
            .City(user.City)
            .Build();
    }

    private Task<UserEntity> MapModelToEntity(UserModel userModel)
    {
        return Task.FromResult(new UserEntity
        {
            Username = userModel.GetUsername(),
            Email = userModel.GetEmail(),
            Phone = userModel.GetPhone(),
            City = userModel.GetCity(),
            Password = userModel.GetPassword(),
            Id = userModel.GetId()
        });
    }
}