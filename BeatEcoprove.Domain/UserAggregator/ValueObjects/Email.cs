using System.Text.RegularExpressions;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Email : ValueObject
{
    private const string EmailRegexPattern = @"^[\w-]+(\.[\w-]+)*@[\w-]+(\.[\w-]+)+$";

    private Email() { }

    private Email(string value) => Value = value;

    public string Value { get; private set; } = null!;

    public static ErrorOr<Email> Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return Errors.Email.EmptyEmail;
        }

        if (!Regex.IsMatch(value, EmailRegexPattern))
        {
            return Errors.Email.InvalidEmail;
        }

        return new Email(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(Email email) => email.Value;
}