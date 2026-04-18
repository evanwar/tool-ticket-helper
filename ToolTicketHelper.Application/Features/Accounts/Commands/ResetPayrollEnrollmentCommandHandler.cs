using ToolTicketHelper.Application.Abstractions.Cqrs;
using ToolTicketHelper.Application.Abstractions.Services;
using ToolTicketHelper.Application.Common;

namespace ToolTicketHelper.Application.Features.Accounts.Commands;

public sealed class ResetPayrollEnrollmentCommandHandler(ITicketSupportRepository repository)
    : ICommandHandler<ResetPayrollEnrollmentCommand, OperationResult>
{
    public async Task<OperationResult> HandleAsync(ResetPayrollEnrollmentCommand command, CancellationToken cancellationToken = default)
    {
        var reset = await repository.ResetPayrollEnrollmentAsync(command.PhoneNumber, command.PayrollLevel, cancellationToken);
        return reset
            ? OperationResult.Ok($"Flujo de nómina {command.PayrollLevel} reiniciado correctamente.")
            : OperationResult.Fail("No se pudo reiniciar el flujo de nómina.");
    }
}
