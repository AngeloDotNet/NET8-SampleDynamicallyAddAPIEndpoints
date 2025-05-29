using ClassLibrary.Api02.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary.Api02.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddFeatureServices02(this IServiceCollection services)
    {
        services.AddSingleton<IService02, Service02>();
        return services;
    }
}