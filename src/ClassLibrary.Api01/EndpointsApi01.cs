using ClassLibrary.Api01.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;

namespace ClassLibrary.Api01;

public static class EndpointsApi01
{
    public static IEndpointRouteBuilder MapEndpointsApi01(this IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/feature/service01", (IService01 service) => service.GetMessage());
        return endpoints;
    }
}