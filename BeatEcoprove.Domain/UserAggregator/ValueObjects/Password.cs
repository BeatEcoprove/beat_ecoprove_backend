using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Password : ValueObject
{
    private Password() { }

    private Password(string value) => Value = value;

    public string Value { get; private set; } = null!;

    private static bool ContainsNumber(string value)
    {
        return value.Any(char.IsDigit);
    }

    private static bool ContainsCapitalLetter(string value)
    {
        return value.Any(char.IsUpper);
    }

    private static bool ContainsNonCapitalLetter(string value)
    {
        return value.Any(char.IsLower);
    }

    public static ErrorOr<Password> Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return Errors.Password.EmptyPassword;
        }

        if (value.Length < 6 || value.Length > 16)
        {
            return Errors.Password.MustBeBetween6And16;
        }

        if (!ContainsNumber(value))
        {
            return Errors.Password.MustContainAtLeastOnNumber;
        }

        if (!ContainsCapitalLetter(value))
        {
            return Errors.Password.MustContainAtLeastOnCaptialLetter;
        }

        if (!ContainsNonCapitalLetter(value))
        {
            return Errors.Password.MustContainAtLeastLetter;
        }

        return new Password(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(Password password) => password.Value;
}