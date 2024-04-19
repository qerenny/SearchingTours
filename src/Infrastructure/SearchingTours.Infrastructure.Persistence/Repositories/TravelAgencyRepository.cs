using Microsoft.EntityFrameworkCore;
using SearchingTours.Application.Models;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Entity;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Repositories;

public class TravelAgencyRepository : BaseRepository<TravelAgencyEntity, TravelAgencyModel>, ITravelAgencyRepository
{
    public TravelAgencyRepository(ApplicationDbContext context) : base(context)
    {
    }

    public TravelAgencyModel? GetTravelAgency(Guid id)
    {
        return GetEntry(new TravelAgencyEntity { Id = id })?.Entity;
    }

    public void AddTravelAgency(TravelAgencyEntity travelAgency)
    {
        Add(travelAgency);
    }

    public void UpdateTravelAgency(TravelAgencyEntity travelAgency)
    {
        Update(travelAgency);
    }

    public bool DeleteTravelAgency(TravelAgencyEntity travelAgency)
    {
        Remove(travelAgency);
        return true;
    }

    protected override DbSet<TravelAgencyModel> DbSet => ((ApplicationDbContext)Context).TravelAgencies;

    protected override TravelAgencyModel MapFrom(TravelAgencyEntity entity)
    {
        return new TravelAgencyModel
        {
            Id = entity.Id,
            Name = entity.Name,
            ContactInfo = entity.ContactInfo,
            Password = entity.Password,
        };
    }

    protected override bool Equal(TravelAgencyEntity entity, TravelAgencyModel model)
    {
        return entity.Id == model.Id;
    }

    protected override void UpdateModel(TravelAgencyModel model, TravelAgencyEntity entity)
    {
        model.Id = entity.Id;
        model.Name = entity.Name;
        model.ContactInfo = entity.ContactInfo;
        model.Password = entity.Password;
    }
}