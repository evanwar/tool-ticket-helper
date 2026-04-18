using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Application.Common;

namespace ToolTicketHelper.Application.Features.Accounts.Commands;

public sealed record DeleteUserAccountCommand(string PhoneNumber) : ICommand<OperationResult>;
