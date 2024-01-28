using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class Phone : ValueObject
{
    private Phone() { }

    private Phone(string code, string value)
    {
        Code = code;
        Value = value;
    }

    public string Value { get; private set; } = null!;
    public string Code { get; private set; } = null!;

    public static ErrorOr<Phone> Create(string code, string value)
    {
        if (ShouldNotBeNull(code, value))
        {
            return Errors.Phone.EmptyPhone;
        }

        if (!ValidateCountryCode(code))
        {
            return Errors.Phone.InvalidPhone;
        }

        if (ShouldHaveLength(value, 9))
        {
            return Errors.Phone.MustBeNineLegth;
        }

        return new Phone(code, value);
    }

    private static bool ValidateCountryCode(string code)
    {
        return code.Contains("+") && code.Length != 4;
    }

    private static bool ShouldHaveLength(string value, int length)
    {
        return value.Length != length;
    }

    private static bool ShouldNotBeNull(string code, string value)
    {
        return string.IsNullOrEmpty(code) || string.IsNullOrEmpty(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(Phone phone) => phone.Value;
}