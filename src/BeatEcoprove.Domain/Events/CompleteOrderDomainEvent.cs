using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Models;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Domain.Events;

public record CompleteOrderDomainEvent(StoreId Store, ProfileId Owner) : IDomainEvent;