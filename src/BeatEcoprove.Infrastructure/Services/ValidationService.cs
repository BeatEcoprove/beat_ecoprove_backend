using BeatEcoprove.Application;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Infrastructure.Services;

public class ValidationService : IValidationFieldService
{
    private readonly IAuthRepository _authRepository;
    private readonly IProfileRepository _profileRepository;
    private readonly Dictionary<string, Func<string, Task<bool>>> _fieldVerifiers;

    public ValidationService(
        IAuthRepository authRepository,
        IProfileRepository profileRepository)
    {
        _fieldVerifiers = new Dictionary<string, Func<string, Task<bool>>>
        {
            { "email", IsEmailAvailableAsync },
            { "username", IsUserNameAvailableAsync },
        };

        _authRepository = authRepository;
        _profileRepository = profileRepository;
    }

    private async Task<bool> IsEmailAvailableAsync(string validateValue)
    {
        var email = Email.Create(validateValue);

        if (email.IsError)
        {
            return false;
        }

        return !await _authRepository.ExistsUserByEmailAsync(email.Value, default);
    }

    private async Task<bool> IsUserNameAvailableAsync(string validationValue)
    {
        var userName = UserName.Create(validationValue);

        return !await _profileRepository.ExistsUserByUserNameAsync(userName, default);
    }

    public Task<bool> IsFieldAvailable(string fieldName, string value)
    {
        if (_fieldVerifiers.TryGetValue(fieldName, out var verifier))
        {
            return verifier(value);
        }

        throw new ArgumentException($"Field {fieldName} is not supported");
    }
}
