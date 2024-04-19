using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SearchingTours.Infrastructure.Persistence.Contexts;
using SearchingTours.Infrastructure.Persistence.Repositories.Interfaces;

namespace SearchingTours.Infrastructure.Persistence.Extensions;

using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.Extensions.DependencyInjection;
using SearchingTours.Application.Abstractions.Persistence;
using SearchingTours.Infrastructure.Persistence.Migrations;
using SearchingTours.Infrastructure.Persistence.Plugins;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructurePersistence(this IServiceCollection collection, IConfiguration configuration)
    {
        // collection.AddPlatformPostgres(builder => builder.BindConfiguration("Infrastructure:Persistence:Postgres"));
        // collection.AddSingleton<IDataSourcePlugin, MappingPlugin>();
        //
        // collection.AddPlatformMigrations(typeof(IAssemblyMarker).Assembly);
        // collection.AddHostedService<MigrationRunnerService>();
        //
        // TODO: add repositories
        // collection.AddScoped<IPersistenceContext, PersistenceContext>();
        collection.AddDbContext<ApplicationDbContext>(options =>
            options.UseNpgsql(configuration.GetSection("Infrastructure:Persistence:Postgres:ConnectionString").Value));
        
        collection.AddScoped<ITravelPackageRepository, TravelPackage>();
        collection.AddScoped<IReviewRepository, ReviewRepository>();
        collection.AddScoped<ITravelAgencyRepository, TravelAgencyRepository>();
        collection.AddScoped<IUserRepository, UserRepository>();
        return collection;
    }
}