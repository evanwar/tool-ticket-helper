namespace ToolTicketHelper.Services;

public sealed class GlobalPhoneState
{
    private string _phoneNumber = string.Empty;

    public event Action? Changed;

    public string PhoneNumber => _phoneNumber;

    public bool HasPhoneNumber => _phoneNumber.Length == 10;

    public void SetPhoneNumber(string phoneNumber)
    {
        var sanitized = new string(phoneNumber.Where(char.IsDigit).Take(10).ToArray());

        if (_phoneNumber == sanitized)
        {
            return;
        }

        _phoneNumber = sanitized;
        Changed?.Invoke();
    }

    public void Clear()
    {
        if (_phoneNumber.Length == 0)
        {
            return;
        }

        _phoneNumber = string.Empty;
        Changed?.Invoke();
    }
}
