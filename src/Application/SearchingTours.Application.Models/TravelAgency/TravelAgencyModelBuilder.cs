namespace SearchingTours.Application.Models.TravelAgency;

public class TravelAgencyModelBuilder
{
    private int _id;
    private string? _name;
    private string? _password;
    private string? _contactInfo;

    public TravelAgencyModelBuilder Id(int id)
    {
        _id = id;
        return this;
    }
    
    public TravelAgencyModelBuilder Name(string name)
    {
        _name = name;
        return this;
    }
    
    public TravelAgencyModelBuilder Password(string password)
    {
        _password = password;
        return this;
    }
    
    public TravelAgencyModelBuilder ContactInfo(string contactInfo)
    {
        _contactInfo = contactInfo;
        return this;
    }

    public TravelAgencyModel Build()
    {
        return new TravelAgencyModel(_id, _name!, _password!, _contactInfo!);
    }
}