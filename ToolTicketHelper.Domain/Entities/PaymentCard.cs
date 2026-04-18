using ToolTicketHelper.Domain.Common;

namespace ToolTicketHelper.Domain.Entities;

public sealed class PaymentCard : AuditableEntity
{
    public Guid CardId { get; set; } = Guid.NewGuid();

    public required string PhoneNumber { get; set; }

    public required string LastFourDigits { get; set; }

    public string CardAlias { get; set; } = string.Empty;

    public bool IsActive { get; set; } = true;
}
