namespace SearchingTours.Application.Models;

public class User(int id, string username, string email, string password, string city, string phone)
{
    public int Id { get; set; } = id;

    public string Username { get; set; } = username;

    public string Email { get; set; } = email;

    public string Password { get; set; } = password;

    public string City { get; set; } = city;

    public string Phone { get; set; } = phone;
}