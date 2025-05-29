using ClassLibrary.Api02.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace ClassLibrary.Api02;

public static class EndpointsApi02
{
    public static IEndpointRouteBuilder MapEndpointsApi02(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/feature/service02", (IService02 service) => service.GetMessage());
        return endpoints;
    }
}
