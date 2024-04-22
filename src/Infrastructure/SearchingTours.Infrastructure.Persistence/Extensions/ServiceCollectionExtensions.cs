using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Repositories;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace SearchingTours.Infrastructure.Persistence.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));
        
        collection.AddScoped<ITravelPackageRepository, TravelPackageRepository>();
        collection.AddScoped<IReviewRepository, ReviewRepository>();
        collection.AddScoped<ITravelAgencyRepository, TravelAgencyRepository>();
        collection.AddScoped<IUserRepository, UserRepository>();
        return collection;
    }
}