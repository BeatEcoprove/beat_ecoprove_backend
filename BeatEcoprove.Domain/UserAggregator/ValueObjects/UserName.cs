using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class UserName : ValueObject
{
    private UserName(string value) => Value = value;
    
    public string Value { get; private set; }
    
    public static UserName Create(string value)
    {
        return new UserName(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator string(UserName userName) =>  userName.Value;
}