namespace SearchingTours.Presentation.Http.Requests;

public class ReviewPost
{
    public Guid TravelPackageId { get; set; }
    
    public string? AuthorName { get; set; }
    
    public string? Text { get; set; }
    
    public int? Rating { get; set; }
}