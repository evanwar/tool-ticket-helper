using System.Data;

namespace ToolTicketHelper.Application.Abstractions.Persistence;

public interface IDatabaseConnectionFactory
{
    IDbConnection CreateConnection(string databaseKey);
}
