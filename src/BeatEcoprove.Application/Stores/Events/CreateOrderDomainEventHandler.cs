using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.Events;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using MediatR;

namespace BeatEcoprove.Application.Stores.Events;

public class CreateOrderDomainEventHandler : INotificationHandler<CreateOrderDomainEvent>
{
    private const int RegisterOrderSustainablePoints = 30;
    
    private readonly IProfileRepository _profileRepository;
    private readonly IStoreService _storeService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGamingService _gamingService;

    public CreateOrderDomainEventHandler(
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

    public async Task Handle(CreateOrderDomainEvent notification, CancellationToken cancellationToken)
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
            RegisterOrderSustainablePoints,
            cancellationToken);

        owner.EcoScore += 100;
        _gamingService.GainXp(owner, 10);
        _gamingService.GainXp(store.Value, 10);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}