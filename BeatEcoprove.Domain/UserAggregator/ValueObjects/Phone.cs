using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class Phone : ValueObject
{
    private Phone(string code, string value)
    {
        Code = code;
        Value = value;
    }
    
    public string Value { get; private set; }
    public string Code { get; private set; }
    
    public static Phone Create(string code, string value)
    {
        // TODO: Add validations
        
        return new Phone(code, value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator string(Phone phone) =>  phone.Value;
}