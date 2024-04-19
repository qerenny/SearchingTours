namespace SearchingTours.Application.Models.User;

public class UserModelBuilder
{
    private int _id;
    private string? _username;
    private string? _email;
    private string? _password;
    private string? _city;
    private string? _phone;
    
    public UserModelBuilder Id(int id)
    {
        _id = id;
        return this;
    }

    public UserModelBuilder Username(string username)
    {
        _username = username;
        return this;
    }

    public UserModelBuilder Email(string email)
    {
        _email = email;
        return this;
    }

    public UserModelBuilder Password(string password)
    {
        _password = password;
        return this;
    }

    public UserModelBuilder City(string city)
    {
        _city = city;
        return this;
    }
    
    public UserModelBuilder Phone(string phone)
    {
        _phone = phone;
        return this;
    }

    public UserModel Build()
    {
        return new UserModel(_id, _username!, _email!, _password!, _city!, _phone!);
    }
}