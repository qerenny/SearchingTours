using System.Collections.ObjectModel;

namespace SearchingTours.Application.Abstractions.Persistence.Queries;

public class TravelPackageQuery
{
    public Collection<int> Ids { get; } = new();

    public Collection<string> Names { get; } = new();

    public Collection<int> Prices { get; } = new();

    public ushort? Limit { get; private set; }

    public ushort? Offset { get; private set; }

    public TravelPackageQuery WithId(int id)
    {
        Ids.Add(id);
        return this;
    }

    public TravelPackageQuery WithIds(IEnumerable<int> ids)
    {
        foreach (var id in ids)
            WithId(id);
        return this;
    }

    public TravelPackageQuery WithName(string name)
    {
        Names.Add(name);
        return this;
    }

    public TravelPackageQuery WithNames(IEnumerable<string> names)
    {
        foreach (var name in names)
            WithName(name);
        return this;
    }

    public TravelPackageQuery WithPrice(int price)
    {
        Prices.Add(price);
        return this;
    }

    public TravelPackageQuery WithPrices(IEnumerable<int> prices)
    {
        foreach (var price in prices)
            WithPrice(price);
        return this;
    }

    public TravelPackageQuery WithLimit(ushort limit)
    {
        Limit = limit;
        return this;
    }

    public TravelPackageQuery WithOffset(ushort offset)
    {
        Offset = offset;
        return this;
    }
}