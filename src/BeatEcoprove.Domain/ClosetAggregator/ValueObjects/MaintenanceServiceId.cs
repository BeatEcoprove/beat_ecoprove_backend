using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class MaintenanceServiceId : EntityId<Guid>
{
    private MaintenanceServiceId() { }
    private MaintenanceServiceId(Guid id) => Value = id;

    public override Guid Value { get; protected set; }

    public static MaintenanceServiceId CreateUnique() => new(Guid.NewGuid());

    public static MaintenanceServiceId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
    
    public static implicit operator Guid(MaintenanceServiceId id) => id.Value;
}