using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.CompleteOrder;

internal sealed class CompleteOrderCommandHandler : ICommandHandler<CompleteOrderCommand, ErrorOr<OrderDAO>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CompleteOrderCommandHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IStoreRepository storeRepository,
        IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<OrderDAO>> Handle(CompleteOrderCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);
        var orderId = OrderId.Create(request.OrderId);
        var ownerId = ProfileId.Create(request.OwnerId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeRepository.GetByIdAsync(
            storeId, 
            cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        var shouldComplete = await _storeService.CompleteOrderAsync(
            store,
            orderId,
            ownerId,
            cancellationToken);

        if (shouldComplete.IsError)
        {
            return shouldComplete.Errors;
        }

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var orderDao = await _storeRepository.GetOrderDaoAsync(orderId, cancellationToken);

        if (orderDao is null)
        {
            return Errors.Order.NotFound;
        }
        
        return orderDao;
    }
}