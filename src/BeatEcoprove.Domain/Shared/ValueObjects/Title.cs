using ErrorOr;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Shared.ValueObjects;

public class Title : ValueObject
{
    private const int MaxLength = 100;
    private const int MinLength = 5;
    
    private Title() { }

    private Title(string value) => Value = value;

    public string Value { get; private set; } = null!;

    public static ErrorOr<Title> Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return Errors.Errors.FeedBack.TitleNotDefine;
        }

        return value.Length switch
        {
            < MinLength => Errors.Errors.FeedBack.TitleMinExceeded,
            > MaxLength => Errors.Errors.FeedBack.TitleMaxExceeded,
            _ => new Title(value)
        };
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator string(Title email) => email.Value;
}