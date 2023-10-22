using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class PostalCode : ValueObject
{
    private PostalCode(string value) => Value = value;
    
    public string Value { get; private set; }
    
    public static PostalCode Create(string value)
    {
        // TODO: Add validations
        
        return new PostalCode(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator string(PostalCode postalCode) =>  postalCode.Value;
}