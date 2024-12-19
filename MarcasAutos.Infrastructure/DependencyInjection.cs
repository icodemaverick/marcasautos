using MarcasAutos.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarcasAutos.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {        
        var connectionString = configuration["DB_CONNECTION_STRING"] ?? throw new NullReferenceException("DB_CONNECTION_STRING");

        services.AddDbContext<MarcasAutosDbContext>(options => options.UseNpgsql(connectionString));

        return services;
    }
}
