namespace SearchingTours.Application.Models.TravelAgency;

public class TravelAgencyModel
{
    private int Id { get; set; }

    private string Name { get; set; }

    private string Password { get; set; }

    private string ContactInfo { get; set; }
    
    public TravelAgencyModel(int id, string name, string password, string contactInfo)
    {
        Id = id;
        Name = name;
        Password = password;
        ContactInfo = contactInfo;
    }

    public static TravelAgencyModelBuilder Builder()
    {
        return new TravelAgencyModelBuilder();
    }

    public int GetId()
    {
        return Id;
    }
    
    public string GetName()
    {
        return Name;
    }
    
    public string GetPassword()
    {
        return Password;
    }
    
    public string GetContactInfo()
    {
        return ContactInfo;
    }
}