using Microsoft.Extensions.DependencyInjection;

// using SearchingTours.Application.Contracts;
namespace SearchingTours.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        // collection.AddScoped<ITravelPackageService, TravelPackageService>();
        // collection.AddScoped<IReviewService, ReviewService>();
        // collection.AddScoped<ITravelAgencyService, TravelAgencyService>();
        // collection.AddScoped<IUserService, UserService>();
        return collection;
    }
}