using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.UserAggregator.ValueObjects;

public class UserId : AggregateRootId<Guid>
{ 
    private UserId() { }
    
    private UserId(Guid id) => Value = id;
   
    public sealed override Guid Value { get; protected set; }
    
    public static UserId CreateUnique() => new(Guid.NewGuid());
    
    public static UserId Create(Guid id) => new(id);
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator Guid(UserId self) => self.Value;
}