namespace SearchingTours.Infrastructure.Persistence.Entity;

public class ReviewEntity(int id, TravelPackageEntity travelPackageId, string authorName, string text, int rating)
{
    public int Id { get; set; } = id;
    public TravelPackageEntity TravelPackageId { get; set; } = travelPackageId;
    public string AuthorName { get; set; } = authorName;
    public string Text { get; set; } = text;
    public int Rating { get; set; } = rating;
}