using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Application.Common;
using ToolTicketHelper.Domain.Enums;

namespace ToolTicketHelper.Application.Features.Accounts.Commands;

public sealed record ResetPayrollEnrollmentCommand(string PhoneNumber, PayrollLevel PayrollLevel)
    : ICommand<OperationResult>;
