using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ClosetAggregator.ValueObjects;

public class MaintenanceActionId : EntityId<Guid>
{
    private MaintenanceActionId() { }
    private MaintenanceActionId(Guid id) => Value = id;

    public override Guid Value { get; protected set; }

    public static MaintenanceActionId CreateUnique() => new(Guid.NewGuid());

    public static MaintenanceActionId Create(Guid id) => new(id);
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(MaintenanceActionId self) => self.Value;
}