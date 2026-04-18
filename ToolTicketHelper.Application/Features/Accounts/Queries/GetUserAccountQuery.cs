using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Domain.Entities;

namespace ToolTicketHelper.Application.Features.Accounts.Queries;

public sealed record GetUserAccountQuery(string PhoneNumber) : IQuery<UserAccount?>;
