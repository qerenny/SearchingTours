namespace SearchingTours.Application.Models;

public class TravelAgencyEntity(int id, string name, string password, string contactInfo)
{
    public int Id { get; set; } = id;

    public string Name { get; set; } = name;

    public string Password { get; set; } = password;

    public string ContactInfo { get; set; } = contactInfo;
}