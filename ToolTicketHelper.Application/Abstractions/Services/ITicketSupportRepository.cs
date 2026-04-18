using ToolTicketHelper.Domain.Entities;
using ToolTicketHelper.Domain.Enums;

namespace ToolTicketHelper.Application.Abstractions.Services;

public interface ITicketSupportRepository
{
    Task<string> GenerateSessionTokenAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<UserAccount?> GetUserByPhoneAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<IReadOnlyCollection<PaymentCard>> GetCardsByPhoneAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<bool> DeleteUserAccountAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<bool> UnlockUserAsync(string phoneNumber, CancellationToken cancellationToken = default);

    Task<bool> ResetPayrollEnrollmentAsync(string phoneNumber, PayrollLevel payrollLevel, CancellationToken cancellationToken = default);

    Task<bool> AuthorizePayrollAsync(string phoneNumber, PayrollLevel payrollLevel, CancellationToken cancellationToken = default);

    Task<bool> AddFundsAsync(string phoneNumber, decimal amount, CancellationToken cancellationToken = default);

    Task<bool> AddCardAsync(string phoneNumber, string lastFourDigits, string alias, CancellationToken cancellationToken = default);

    Task<bool> RemoveCardAsync(string phoneNumber, Guid cardId, CancellationToken cancellationToken = default);
}
