using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Events;

public record CreateClothDomainEvent(Profile Profile, Cloth Cloth) : IDomainEvent;