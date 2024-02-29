using BeatEcoprove.Domain.Events;

using MediatR;

namespace BeatEcoprove.Application.Cloths.Events;

public class MaintainClothDomainEventHandler : INotificationHandler<MaintainClothDomainEvent>
{

    public Task Handle(MaintainClothDomainEvent notification, CancellationToken cancellationToken)
    {
        var profile = notification.Profile;
        var action = notification.MaintenanceActivity;

        profile.SustainabilityPoints += action.SustainablePoints;
        profile.EcoScore += action.EcoScore;

        return Task.CompletedTask;
    }
}