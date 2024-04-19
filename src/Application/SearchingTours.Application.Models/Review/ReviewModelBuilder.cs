using SearchingTours.Application.Models.TravelPackage;

namespace SearchingTours.Application.Models.Review;

public class ReviewModelBuilder
{
    private int _id;
    private TravelPackageModel _travelPackageId;
    private string _authorName;
    private string _text;
    private int _rating;

    public ReviewModelBuilder Id(int id)
    {
        _id = id;
        return this;
    }

    public ReviewModelBuilder TravelPackageId(TravelPackageModel travelPackageId)
    {
        _travelPackageId = travelPackageId;
        return this;
    }

    public ReviewModelBuilder AuthorName(string authorName)
    {
        _authorName = authorName;
        return this;
    }

    public ReviewModelBuilder Text(string text)
    {
        _text = text;
        return this;
    }

    public ReviewModelBuilder Rating(int rating)
    {
        _rating = rating;
        return this;
    }

    public ReviewModel Build()
    {
        return new ReviewModel(_id, _travelPackageId, _authorName, _text, _rating);
    }
}
