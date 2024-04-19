using System.Collections.ObjectModel;

namespace SearchingTours.Application.Abstractions.Persistence.Queries;

public class TravelAgencyQuery
{
    public Collection<int> Ids { get; } = new();

    public Collection<string> Names { get; } = new();

    public Collection<string> ContactInfos { get; } = new();

    public ushort? Limit { get; private set; }

    public ushort? Offset { get; private set; }

    public TravelAgencyQuery WithId(int id)
    {
        Ids.Add(id);
        return this;
    }

    public TravelAgencyQuery WithIds(IEnumerable<int> ids)
    {
        foreach (var id in ids)
            WithId(id);
        return this;
    }

    public TravelAgencyQuery WithName(string name)
    {
        Names.Add(name);
        return this;
    }

    public TravelAgencyQuery WithNames(IEnumerable<string> names)
    {
        foreach (var name in names)
            WithName(name);
        return this;
    }

    public TravelAgencyQuery WithContactInfo(string contactInfo)
    {
        ContactInfos.Add(contactInfo);
        return this;
    }

    public TravelAgencyQuery WithContactInfos(IEnumerable<string> contactInfos)
    {
        foreach (var contactInfo in contactInfos)
            WithContactInfo(contactInfo);
        return this;
    }

    public TravelAgencyQuery WithLimit(ushort limit)
    {
        Limit = limit;
        return this;
    }

    public TravelAgencyQuery WithOffset(ushort offset)
    {
        Offset = offset;
        return this;
    }
}