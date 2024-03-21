namespace SearchingTours.Application.Models;

public class Review(int id, TravelPackage travelPackageId, string authorName, string text, int rating)
{
    public int Id { get; set; } = id;

    public TravelPackage TravelPackageId { get; set; } = travelPackageId;

    public string AuthorName { get; set; } = authorName;

    public string Text { get; set; } = text;

    public int Rating { get; set; } = rating;
}