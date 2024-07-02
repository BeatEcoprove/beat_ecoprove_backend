using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RegisterOrder;

internal sealed class RegisterOrderCommandHandler : ICommandHandler<RegisterOrderCommand, ErrorOr<OrderDAO>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreRepository _storeRepository;
    private readonly IClothRepository _clothRepository;
    private readonly IStoreService _storeService;
    private readonly IUnitOfWork _unitOfWork;

    public RegisterOrderCommandHandler(IProfileManager profileManager, IStoreRepository storeRepository, IClothRepository clothRepository, IStoreService storeService, IUnitOfWork unitOfWork)
    {
        _profileManager = profileManager;
        _storeRepository = storeRepository;
        _clothRepository = clothRepository;
        _storeService = storeService;
        _unitOfWork = unitOfWork;
    }

    public async Task<ErrorOr<OrderDAO>> Handle(RegisterOrderCommand request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var storeId = StoreId.Create(request.StoreId);
        var clothId = ClothId.Create(request.ClothId);
        var ownerId = ProfileId.Create(request.OwnerId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeRepository.GetByIdAsync(storeId, cancellationToken);

        if (store is null)
        {
            return Errors.Store.StoreNotFound;
        }

        var cloth = await _clothRepository.GetByIdAsync(clothId, cancellationToken);

        if (cloth is null)
        {
            return Errors.Cloth.ClothNotFound;
        }

        var order = await _storeService.RegisterOrderAsync(store, ownerId, clothId, cancellationToken);

        if (order.IsError)
        {
            return order.Errors;
        }
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var orderDao = await _storeRepository.GetOrderDaoAsync(order.Value.Id, cancellationToken);

        if (orderDao is null)
        {
            return Errors.Store.StoreNotFound;
        }

        return orderDao;
    }
}