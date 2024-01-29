using BeatEcoprove.Application.Shared.Gaming;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.Events;
using MediatR;

namespace BeatEcoprove.Application.Closet.Events;

public class UseClothDomainEventHandler : INotificationHandler<UseClothDomainEvent>
{
    private readonly IGamingService _gamingService;
    private readonly IUnitOfWork _unitOfWork;

    public UseClothDomainEventHandler(IGamingService gamingService, IUnitOfWork unitOfWork)
    {
        _gamingService = gamingService;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(UseClothDomainEvent notification, CancellationToken cancellationToken)
    {
        var profile = notification.Profile;
        var cloth = notification.Cloth;

        // Add points to Cloth
        cloth.EcoScore += 8;

        // Add points to profile
        // TODO: Calculate the right amount of points and xp
        profile.SustainabilityPoints += SustainablePoints.UsePieceOfCloth;
        profile.EcoScore += cloth.EcoScore;
        _gamingService.GainXp(profile, 5);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}