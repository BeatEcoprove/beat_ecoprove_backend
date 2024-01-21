using BeatEcoprove.Application.Shared.Gaming;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.Events;
using MediatR;

namespace BeatEcoprove.Application.Closet.Events;

public class CreateClothDomainEventHandler : INotificationHandler<CreateClothDomainEvent>
{
    private readonly IGamingService _gamingService;
    private readonly IUnitOfWork _unitOfWork;

    public CreateClothDomainEventHandler(
        IUnitOfWork unitOfWork, 
        IGamingService gamingService)
    {
        _unitOfWork = unitOfWork;
        _gamingService = gamingService;
    }

    public async Task Handle(CreateClothDomainEvent notification, CancellationToken cancellationToken)
    {
        var profile = notification.Profile;
        var cloth = notification.Cloth;
        
        // Add points to Cloth
        cloth.EcoScore += 100;
        
        // Add points to profile
        profile.SustainabilityPoints += SustainablePoints.InsertPieceOfCloth;
        profile.EcoScore += cloth.EcoScore;
        _gamingService.GainXp(profile, 2500);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}