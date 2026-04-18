namespace ToolTicketHelper.Infraestructure.Configuration;

public sealed class DatabaseConnectionOptions
{
    public Dictionary<string, string> Connections { get; init; } = new(StringComparer.OrdinalIgnoreCase);
}
