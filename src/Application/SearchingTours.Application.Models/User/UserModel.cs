namespace SearchingTours.Application.Models.User;

public class UserModel
{
    private int Id { get; set; }
    private string Username { get; set; }
    private string Email { get; set; }
    private string Password { get; set; }
    private string City { get; set; }
    private string Phone { get; set; }

    public UserModel(int id, string username, string email, string password, string city, string phone)
    {
        Id = id;
        Username = username;
        Email = email;
        Password = password;
        City = city;
        Phone = phone;
    }

    public static UserModelBuilder Builder()
    {
        return new UserModelBuilder();
    }

    public int GetId()
    {
        return Id;
    }

    public string GetUsername()
    {
        return Username;
    }

    public string GetEmail()
    {
        return Email;
    }

    public string GetPassword()
    {
        return Password;
    }

    public string GetCity()
    {
        return City;
    }
    
    public string GetPhone()
    {
        return Phone;
    }
}