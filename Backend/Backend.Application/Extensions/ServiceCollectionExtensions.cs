using Backend.Application.Services;
using Backend.Application.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace Backend.Application.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection collection)
    {
        collection.AddScoped<IPostService, PostService>();

        return collection;
    }
}