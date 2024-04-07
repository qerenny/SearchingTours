using SearchingTours.Application.Contracts.ServicesInterfaces;
using SearchingTours.Application.Models.User;
using SearchingTours.Infrastructure.Persistence.Repositories;

namespace SearchingTours.Application.Services;

public class UserService : IUserService
{
    private readonly UserRepository _userRepository;

    public UserService(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async void RegisterNewUser(UserModel userModel)
    {
        await _userRepository.CreateUser(userModel);
    }

    public UserModel? GetUser(int userId)
    {
        return _userRepository.FindUserById(userId).Result;
    }

    public async void DeleteUser(int userId)
    {
        var userModel = _userRepository.FindUserById(userId);
        await _userRepository.DeleteUser(await userModel ?? throw new InvalidOperationException());
    }

    public string? GetUsername(int userId)
    {
        return _userRepository.FindUserById(userId).Result?.GetUsername();
    }

    public async void UpdateUsername(int userId, string newUsername)
    {
        var userModel = _userRepository.FindUserById(userId).Result;
        if (userModel != null)
        {
            var newUserModel = UserModel.Builder()
                .Id(userModel.GetId())
                .Username(newUsername)
                .Email(userModel.GetEmail())
                .Phone(userModel.GetPhone())
                .City(userModel.GetCity())
                .Password(userModel.GetPassword())
                .Build();
            await _userRepository.UpdateUserInfo(newUserModel);
        }
    }

    public string? GetEmail(int userId)
    {
        return _userRepository.FindUserById(userId).Result?.GetUsername();
    }

    public async void UpdateEmail(int userId, string newEmail)
    {
        var userModel = _userRepository.FindUserById(userId).Result;
        if (userModel != null)
        {
            var newUserModel = UserModel.Builder()
                .Id(userModel.GetId())
                .Username(userModel.GetEmail())
                .Email(newEmail)
                .Phone(userModel.GetPhone())
                .City(userModel.GetCity())
                .Password(userModel.GetPassword())
                .Build();
            await _userRepository.UpdateUserInfo(newUserModel);
        }
    }
    
    public string? GetCity(int userId)
    {
        return _userRepository.FindUserById(userId).Result?.GetUsername();
    }

    public async void UpdateCity(int userId, string newCity)
    {
        var userModel = _userRepository.FindUserById(userId).Result;
        if (userModel != null)
        {
            var newUserModel = UserModel.Builder()
                .Id(userModel.GetId())
                .Username(userModel.GetEmail())
                .Email(userModel.GetEmail())
                .Phone(userModel.GetPhone())
                .City(newCity)
                .Password(userModel.GetPassword())
                .Build();
            await _userRepository.UpdateUserInfo(newUserModel);
        }
    }
    
    public string? GetPhone(int userId)
    {
        return _userRepository.FindUserById(userId).Result?.GetUsername();
    }

    public async void UpdatePhone(int userId, string newPhone)
    {
        var userModel = _userRepository.FindUserById(userId).Result;
        if (userModel != null)
        {
            var newUserModel = UserModel.Builder()
                .Id(userModel.GetId())
                .Username(userModel.GetEmail())
                .Email(userModel.GetEmail())
                .Phone(newPhone)
                .City(userModel.GetCity())
                .Password(userModel.GetPassword())
                .Build();
            await _userRepository.UpdateUserInfo(newUserModel);
        }
    }

    public async void UpdatePassword(int userId, string newPassword)
    {
        var userModel = _userRepository.FindUserById(userId).Result;
        if (userModel != null)
        {
            var newUserModel = UserModel.Builder()
                .Id(userModel.GetId())
                .Username(userModel.GetEmail())
                .Email(userModel.GetEmail())
                .Phone(userModel.GetPhone())
                .City(userModel.GetCity())
                .Password(newPassword)
                .Build();
            await _userRepository.UpdateUserInfo(newUserModel);
        }
    }
}