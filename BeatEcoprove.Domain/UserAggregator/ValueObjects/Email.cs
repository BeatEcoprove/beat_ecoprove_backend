using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Email : ValueObject
{
    private Email(string value) => Value = value;
    
    public string Value { get; private set; }
    
    public static Email Create(string value)
    {
        // TODO: Add validations
        
        return new Email(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator string(Email email) =>  email.Value;
}