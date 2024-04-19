using System.Collections.ObjectModel;

namespace SearchingTours.Application.Abstractions.Persistence.Queries;

public class ReviewQuery
{
    public Collection<int> TravelPackageIds { get; } = new();

    public Collection<int> Ratings { get; } = new();

    public ushort? Limit { get; private set; }

    public ushort? Offset { get; private set; }

    public ReviewQuery WithTravelPackageId(int travelPackageId)
    {
        TravelPackageIds.Add(travelPackageId);
        return this;
    }

    public ReviewQuery WithTravelPackageIds(IEnumerable<int> travelPackageId)
    {
        foreach (var id in travelPackageId)
            WithTravelPackageId(id);
        return this;
    }

    public ReviewQuery WithGrade(int ratings)
    {
        Ratings.Add(ratings);
        return this;
    }

    public ReviewQuery WithGrades(IEnumerable<int> ratings)
    {
        foreach (var rating in ratings)
            WithGrade(rating);
        return this;
    }

    public ReviewQuery WithLimit(ushort limit)
    {
        Limit = limit;
        return this;
    }

    public ReviewQuery WithOffset(ushort offset)
    {
        Offset = offset;
        return this;
    }
}