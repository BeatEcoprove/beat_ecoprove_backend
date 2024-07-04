using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using MediatR;

namespace BeatEcoprove.Application.Stores.Events;

internal sealed class CompleteOrderDomainEventHandler : INotificationHandler<CompleteOrderDomainEvent>
{ 
    private const int CompleteOrderSustainablePoints = 25;
        
    private readonly IProfileRepository _profileRepository;
    private readonly IStoreService _storeService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGamingService _gamingService;

    public CompleteOrderDomainEventHandler(
        IProfileRepository profileRepository, 
        IStoreService storeService, 
        IUnitOfWork unitOfWork, 
        IGamingService gamingService)
    {
        _profileRepository = profileRepository;
        _storeService = storeService;
        _unitOfWork = unitOfWork;
        _gamingService = gamingService;
    }
    
    public async Task Handle(CompleteOrderDomainEvent notification, CancellationToken cancellationToken)
    {
        var storeId = StoreId.Create(notification.Store);
        var ownerId = ProfileId.Create(notification.Owner);

        var owner = await _profileRepository.GetByIdAsync(ownerId, cancellationToken);

        if (owner is null)
        {
            return;
        }

        var store = await _storeService.GetStoreAsync(storeId, owner, cancellationToken);

        if (store.IsError)
        {
            return;
        }

        await _storeService.GivePointsTo(
            store.Value,
            owner,
            CompleteOrderSustainablePoints,
            cancellationToken);
        
        owner.EcoScore += 120;
        _gamingService.GainXp(owner, 5);        
        _gamingService.GainXp(store.Value, 5);        
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}