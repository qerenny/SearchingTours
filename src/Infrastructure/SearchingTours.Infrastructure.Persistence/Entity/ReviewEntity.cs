using SearchingTours.Application.Models.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Entity;

public class ReviewEntity : IEntity
{
    public Guid? Id { get; set; }
    
    public TravelPackageEntity? TravelPackageEntity { get; set; }
    
    public string? AuthorName { get; set; }
    
    public string? Text { get; set; }
    
    public int? Rating { get; set; }
}