using BeatEcoprove.Domain.ClosetAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.Events;

public record MaintainClothDomainEvent(MaintenanceAction MaintenanceActivity, Profile Profile) : IDomainEvent;