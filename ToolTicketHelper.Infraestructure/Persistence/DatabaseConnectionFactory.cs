using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using ToolTicketHelper.Application.Abstractions.Persistence;
using ToolTicketHelper.Infraestructure.Configuration;

namespace ToolTicketHelper.Infraestructure.Persistence;

public sealed class DatabaseConnectionFactory(IOptions<DatabaseConnectionOptions> options) : IDatabaseConnectionFactory
{
    private readonly IReadOnlyDictionary<string, string> _connections = options.Value.Connections;

    public IDbConnection CreateConnection(string databaseKey)
    {
        if (!_connections.TryGetValue(databaseKey, out var connectionString) || string.IsNullOrWhiteSpace(connectionString))
        {
            throw new InvalidOperationException($"No se encontró la conexión para la llave '{databaseKey}'.");
        }

        return new SqlConnection(connectionString);
    }
}
