using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Application.Abstractions.Services;
using ToolTicketHelper.Domain.Entities;

namespace ToolTicketHelper.Application.Features.Accounts.Queries;

public sealed class GetUserAccountQueryHandler(ITicketSupportRepository repository)
    : IQueryHandler<GetUserAccountQuery, UserAccount?>
{
    public Task<UserAccount?> HandleAsync(GetUserAccountQuery query, CancellationToken cancellationToken = default)
        => repository.GetUserByPhoneAsync(query.PhoneNumber, cancellationToken);
}
