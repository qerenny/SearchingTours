using SearchingTours.Application.Models.Interfaces;

namespace SearchingTours.Application.Models;

public class ReviewModel : IEntity
{
    public Guid? Id { get; set; }
    
    public Guid? TravelPackageId { get; set; }
    
    public string? Text { get; set; } = null!;
    
    public int? Rating { get; set; }
    
    public string? AuthorName { get; set; } = null!;

    public TravelPackageModel? TravelPackage { get; set; }
}