using SearchingTours.Application.Models.TravelPackage;

namespace SearchingTours.Application.Models.Review;

public class ReviewModel
{
    private int Id { get; set; }
    private TravelPackageModel TravelPackageId { get; set; }
    private string AuthorName { get; set; }
    private string Text { get; set; }
    private int Rating { get; set; }

    public ReviewModel(int id, TravelPackageModel travelPackageId, string authorName, string text, int rating)
    {
        Id = id;
        TravelPackageId = travelPackageId;
        AuthorName = authorName;
        Text = text;
        Rating = rating;
    }

    public static ReviewModelBuilder Builder()
    {
        return new ReviewModelBuilder();
    }

    public int GetId()
    {
        return Id;
    }

    public TravelPackageModel GetTravelPackageId()
    {
        return TravelPackageId;
    }

    public string GetAuthorName()
    {
        return AuthorName;
    }

    public string GetText()
    {
        return Text;
    }

    public int GetRating()
    {
        return Rating;
    }
}