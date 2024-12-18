using MarcasAutos.Api.Services;

namespace MarcasAutos.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddApi(this IServiceCollection services)
    {

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddScoped<IMarcasService, MarcasService>();

        return services;
    }
}
