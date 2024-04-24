using Microsoft.EntityFrameworkCore;
using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Repositories;

public class ReviewRepository : BaseRepository<ReviewEntity, ReviewModel>, IReviewRepository
{
    public ReviewRepository(ApplicationDbContext context) : base(context)
    {
    }

    public ReviewModel? GetReview(Guid id)
    {
        return GetEntry(new ReviewEntity { Id = id })?.Entity;
    }

    public void UpdateReview(ReviewEntity review)
    {
        Update(review);
    }

    public bool Delete(ReviewEntity review)
    {
        Remove(review);
        return true;
    }
    
    public void AddReview(ReviewEntity review)
    {
        Add(review);
    }

    protected override DbSet<ReviewModel> DbSet => ((ApplicationDbContext)Context).Reviews;

    protected override ReviewModel MapFrom(ReviewEntity entity)
    {
        return new ReviewModel
        {
            Id = entity.Id,
            TravelPackageId = entity.TravelPackageEntity?.Id ?? Guid.Empty,
            Text = entity.Text,
            Rating = entity.Rating,
            AuthorName = entity.AuthorName,
        };
    }
    
    protected override bool Equal(ReviewEntity entity, ReviewModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(ReviewModel model, ReviewEntity entity)
    {
        model.TravelPackageId = entity.TravelPackageEntity?.Id ?? Guid.Empty;
        model.Text = entity.Text;
        model.Rating = entity.Rating;
        model.AuthorName = entity.AuthorName;
    }
}