using ToolTicketHelper.Application.Abstractions.Persistence;
using ToolTicketHelper.Application.Abstractions.Services;
using ToolTicketHelper.Domain.Entities;
using ToolTicketHelper.Domain.Enums;

namespace ToolTicketHelper.Infraestructure.Services;

public sealed class TicketSupportRepository(IDatabaseConnectionFactory connectionFactory) : ITicketSupportRepository
{
    public Task<string> GenerateSessionTokenAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        // TODO: Implementar ejecución de SP para token de sesión.
        return Task.FromResult($"token-placeholder-{phoneNumber}");
    }

    public Task<UserAccount?> GetUserByPhoneAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        // TODO: Implementar consulta real (SP o query).
        UserAccount account = new()
        {
            PhoneNumber = phoneNumber,
            FullName = "Usuario Demo",
            Balance = 1250.40m,
            IsLocked = false,
            EnrollmentStage = "NominaN2"
        };

        return Task.FromResult<UserAccount?>(account);
    }

    public Task<IReadOnlyCollection<PaymentCard>> GetCardsByPhoneAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        IReadOnlyCollection<PaymentCard> cards =
        [
            new PaymentCard { PhoneNumber = phoneNumber, LastFourDigits = "1945", CardAlias = "Principal" },
            new PaymentCard { PhoneNumber = phoneNumber, LastFourDigits = "7788", CardAlias = "Respaldo" }
        ];

        return Task.FromResult(cards);
    }

    public Task<bool> DeleteUserAccountAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        _ = connectionFactory.CreateConnection("CoreBanking");
        // TODO: Ejecutar SP de borrado total de cuenta por número telefónico.
        return Task.FromResult(true);
    }

    public Task<bool> UnlockUserAsync(string phoneNumber, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de desbloqueo.
        return Task.FromResult(true);
    }

    public Task<bool> ResetPayrollEnrollmentAsync(string phoneNumber, PayrollLevel payrollLevel, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de reinicio por nivel de nómina.
        return Task.FromResult(true);
    }

    public Task<bool> AuthorizePayrollAsync(string phoneNumber, PayrollLevel payrollLevel, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de autorización de nómina.
        return Task.FromResult(true);
    }

    public Task<bool> AddFundsAsync(string phoneNumber, decimal amount, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de fondos.
        return Task.FromResult(true);
    }

    public Task<bool> AddCardAsync(string phoneNumber, string lastFourDigits, string alias, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de alta de tarjeta.
        return Task.FromResult(true);
    }

    public Task<bool> RemoveCardAsync(string phoneNumber, Guid cardId, CancellationToken cancellationToken = default)
    {
        // TODO: Ejecutar SP de eliminación de tarjeta.
        return Task.FromResult(true);
    }
}
