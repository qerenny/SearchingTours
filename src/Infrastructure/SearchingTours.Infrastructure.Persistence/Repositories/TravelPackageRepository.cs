using Microsoft.EntityFrameworkCore;
using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Repositories;

public class TravelPackageRepository : BaseRepository<TravelPackageEntity, TravelPackageModel>, ITravelPackageRepository
{
    public TravelPackageRepository(ApplicationDbContext context) : base(context)
    {
    }

    protected override DbSet<TravelPackageModel> DbSet => ((ApplicationDbContext)Context).TravelPackages;

    public TravelPackageModel? GetTravelPackage(Guid id)
    {
        return GetEntry(new TravelPackageEntity { Id = id })?.Entity;
    }

    public void AddTravelPackage(TravelPackageEntity travelPackage)
    {
        Add(travelPackage);
    }

    public void UpdateTravelPackage(TravelPackageEntity travelPackage)
    {
        Update(travelPackage);
    }

    public bool DeleteTravelPackage(TravelPackageEntity travelPackage)
    {
        Remove(travelPackage);
        return true; 
    }

    protected override TravelPackageModel MapFrom(TravelPackageEntity entity)
    {
        return new TravelPackageModel
        {
            Id = entity.Id,
            Name = entity.Name,
            AmountOfPackage = entity.AmountOfPackage,
            AmountOfPeople = entity.AmountOfPeople,
            Destination = entity.Destination,
            Price = entity.Price,
            Rating = entity.Rating,
            StartDate = entity.StartDate,
            EndDate = entity.EndDate,
            Description = entity.Description,
            TravelAgencyId = entity.TravelAgencyEntity?.Id ?? Guid.Empty,
        };
    }

    protected override bool Equal(TravelPackageEntity entity, TravelPackageModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(TravelPackageModel model, TravelPackageEntity entity)
    {
        model.Name = entity.Name;
        model.AmountOfPackage = entity.AmountOfPackage;
        model.AmountOfPeople = entity.AmountOfPeople;
        model.Destination = entity.Destination;
        model.Price = entity.Price;
        model.Rating = entity.Rating;
        model.StartDate = entity.StartDate;
        model.EndDate = entity.EndDate;
        model.Description = entity.Description;
        model.TravelAgencyId = entity.TravelAgencyEntity?.Id ?? Guid.Empty;
    }
}