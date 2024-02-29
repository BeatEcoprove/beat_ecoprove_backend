using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;

using ErrorOr;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class UserName : ValueObject
{
    public UserName() { }

    private UserName(string value) => Value = value;

    public string Value { get; private set; } = null!;

    public static ErrorOr<UserName> Create(string value)
    {
        // verify if is null or empty
        if (string.IsNullOrWhiteSpace(value))
        {
            return Errors.Username.InvalidUsername;
        }

        return new UserName(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(UserName userName) => userName.Value;
}