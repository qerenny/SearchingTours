using SearchingTours.Application.Models.User;

namespace SearchingTours.Application.Abstractions.Persistence.Repositories.Interfaces;

public interface IUserRepository
{
    Task<UserModel?> FindUserById(int userId); 
    Task CreateUser(UserModel userModel); 
    Task UpdateUserInfo(UserModel userModel); 
    Task DeleteUser(UserModel userModel); 
}