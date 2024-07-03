using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOrderById;

internal sealed class GetOrderByIdQueryHandler : IQueryHandler<GetOrderByIdQuery, ErrorOr<OrderDAO>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreRepository _storeRepository;
    private readonly IStoreService _storeService;

    public GetOrderByIdQueryHandler(
        IProfileManager profileManager, 
        IStoreRepository storeRepository, 
        IStoreService storeService)
    {
        _profileManager = profileManager;
        _storeRepository = storeRepository;
        _storeService = storeService;
    }

    public async Task<ErrorOr<OrderDAO>> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var orderId = OrderId.Create(request.OrderId);
        var storeId = StoreId.Create(request.StoreId);

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var store = await _storeService.GetStoreAsync(
            storeId,
            profile.Value,
            cancellationToken);

        if (store.IsError)
        {
            return store.Errors;
        }

        var order = await _storeRepository.GetOrderDaoAsync(orderId, cancellationToken);

        if (order is null)
        {
            return Errors.Order.NotFound;
        }

        return order;
    }
}