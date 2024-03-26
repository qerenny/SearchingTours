using SearchingTours.Application.Models.User;

namespace SearchingTours.Application.Contracts.ServicesInterfaces;

public interface IUserService
{
    void RegisterNewUser(UserModel userModel);
    UserModel? GetUser(int userId);
    void DeleteUser(int userId);
    string? GetUsername(int userId);
    void UpdateUsername(int userId, string newUsername);
    string? GetEmail(int userId);
    void UpdateEmail(int userId, string newEmail);
    string? GetCity(int userId);
    void UpdateCity(int userId, string newCity);
    string? GetPhone(int userId);
    void UpdatePhone(int userId, string newPhone);
    void UpdatePassword(int userId, string newPassword);
}