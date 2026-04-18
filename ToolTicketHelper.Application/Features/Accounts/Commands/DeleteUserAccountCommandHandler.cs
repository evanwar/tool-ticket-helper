using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Application.Abstractions.Services;
using ToolTicketHelper.Application.Common;

namespace ToolTicketHelper.Application.Features.Accounts.Commands;

public sealed class DeleteUserAccountCommandHandler(ITicketSupportRepository repository)
    : ICommandHandler<DeleteUserAccountCommand, OperationResult>
{
    public async Task<OperationResult> HandleAsync(DeleteUserAccountCommand command, CancellationToken cancellationToken = default)
    {
        var deleted = await repository.DeleteUserAccountAsync(command.PhoneNumber, cancellationToken);
        return deleted
            ? OperationResult.Ok("Cuenta eliminada correctamente.")
            : OperationResult.Fail("No se pudo eliminar la cuenta.");
    }
}
