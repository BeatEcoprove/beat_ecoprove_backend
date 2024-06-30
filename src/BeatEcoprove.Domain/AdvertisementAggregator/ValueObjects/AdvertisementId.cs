using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;

public class AdvertisementId : AggregateRootId<Guid>
{
    private AdvertisementId() { }

    private AdvertisementId(Guid id) => Value = id;

    public sealed override Guid Value { get; protected set; }

    public static AdvertisementId CreateUnique() => new(Guid.NewGuid());

    public static AdvertisementId Create(Guid id) => new(id);

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }

    public static implicit operator Guid(AdvertisementId self) => self.Value;
}