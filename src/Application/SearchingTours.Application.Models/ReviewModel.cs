using SearchingTours.Application.Models;

namespace SearchingTours.Application.Models;

public class ReviewModel : IEntity
{
    public int Id { get; set; }
    public int TravelPackageId { get; set; }
    public string Text { get; set; } = null!;
    public int Rating { get; set; }
    public string AuthorName { get; set; } = null!;
}