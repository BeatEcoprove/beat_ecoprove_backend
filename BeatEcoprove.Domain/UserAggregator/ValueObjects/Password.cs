using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Password : ValueObject
{
    private Password(string value) => Value = value;
    
    public string Value { get; private set; }
    
    public static Password Create(string value)
    {
        // TODO: Add validations
        
        return new Password(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator string(Password password) =>  password.Value;
}