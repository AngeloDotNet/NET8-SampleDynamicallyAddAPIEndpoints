using ClassLibrary.Api01.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary.Api01.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddFeatureServices01(this IServiceCollection services)
    {
        services.AddSingleton<IService01, Service01>();
        return services;
    }
}