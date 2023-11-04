using System.Text.RegularExpressions;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Models;
using ErrorOr;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public class PostalCode : ValueObject
{
    private const string PostalCodeRegexPattern = @"^\d{4}(-\d{3})?$";

    private PostalCode() { }

    private PostalCode(string value) => Value = value;

    public string Value { get; private set; } = null!;

    public static ErrorOr<PostalCode> Create(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return Errors.PostalCode.EmptyPostalCode;
        }

        if (!Regex.IsMatch(value, PostalCodeRegexPattern))
        {
            return Errors.PostalCode.InvalidPostalCode;
        }

        return new PostalCode(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(PostalCode postalCode) => postalCode.Value;
}