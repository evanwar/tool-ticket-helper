using Microsoft.Extensions.DependencyInjection;
using ToolTicketHelper.Application.Abstractions.Persistence;
using ToolTicketHelper.Application.Abstractions.Services;
using ToolTicketHelper.Infraestructure.Configuration;
using ToolTicketHelper.Infraestructure.Persistence;
using ToolTicketHelper.Infraestructure.Services;

namespace ToolTicketHelper.Infraestructure;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddToolTicketInfrastructure(
        this IServiceCollection services,
        Action<DatabaseConnectionOptions> configureConnections)
    {
        services.Configure(configureConnections);
        services.AddScoped<IDatabaseConnectionFactory, DatabaseConnectionFactory>();
        services.AddScoped<ITicketSupportRepository, TicketSupportRepository>();

        return services;
    }
}
