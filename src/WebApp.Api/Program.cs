using ClassLibrary.Api01;
using ClassLibrary.Api01.Extensions;
using ClassLibrary.Api02;
using ClassLibrary.Api02.Extensions;

namespace WebApp.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddFeatureServices01();
        builder.Services.AddFeatureServices02();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.MapEndpointsApi01();

        app.MapEndpointsApi02();
        app.Run();
    }
}
