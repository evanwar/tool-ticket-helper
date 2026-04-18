using ToolTicketHelper.Domain.Common;

namespace ToolTicketHelper.Domain.Entities;

public sealed class UserAccount : AuditableEntity
{
    public required string PhoneNumber { get; set; }

    public string FullName { get; set; } = string.Empty;

    public decimal Balance { get; set; }

    public bool IsLocked { get; set; }

    public bool IsDeleted { get; set; }

    public string EnrollmentStage { get; set; } = "Pending";
}
