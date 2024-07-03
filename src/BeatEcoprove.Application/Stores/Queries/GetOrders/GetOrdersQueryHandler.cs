using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetOrders;

internal sealed class GetOrdersQueryHandler : IQueryHandler<GetOrdersQuery, ErrorOr<List<OrderDAO>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IStoreRepository _storeRepository;
    private readonly IColorRepository _colorRepository;
    private readonly IBrandRepository _brandRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;

    public GetOrdersQueryHandler(
        IProfileManager profileManager, 
        IStoreService storeService, 
        IStoreRepository storeRepository, 
        IColorRepository colorRepository, 
        IBrandRepository brandRepository, 
        IMaintenanceServiceRepository maintenanceServiceRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _storeRepository = storeRepository;
        _colorRepository = colorRepository;
        _brandRepository = brandRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
    }
    
    private ErrorOr<dynamic> ValidateParams(ErrorOr<string>? order)
    {
        if (order is not null && order.Value.IsError)
        {
            return order.Value.Errors;
        }

        return true;
    }

    public async Task<ErrorOr<List<OrderDAO>>> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        ErrorOr<List<Guid>>? serviceId = null;
        ErrorOr<List<Guid>>? colorId = null;
        ErrorOr<List<Guid>>? brandId = null;

        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        
        var result =
            ValidateParams("asc");        

        if (request.Services != null)
        {
            serviceId = await GetMaintenanceId(request.Services, cancellationToken);

            if (serviceId.Value.IsError)
            {
                result = serviceId.Value.Errors;
            }
        }
        
        if (request.Color != null)
        {
            colorId = await GetColorId(request.Color, cancellationToken);

            if (colorId.Value.IsError)
            {
                result = colorId.Value.Errors;
            }
        }

        if (request.Brand != null)
        {
            brandId = await GetBrandId(request.Brand, cancellationToken);

            if (brandId.Value.IsError)
            {
                result = brandId.Value.Errors;
            }
        }

        if (result.IsError)
        {
            return result.Errors;
        }

        var profile = await _profileManager.GetProfileAsync(authId, profileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }
        
        var storeIds = await GetStoreId(request.StoreIds, profile.Value, cancellationToken);

        if (storeIds.IsError)
        {
            return storeIds.Errors;
        }
        
        var orders = await _storeRepository.GetOrderDaosAsync(
            storeIds.Value,
            request.Search,
            serviceId?.Value,
            colorId?.Value,
            brandId?.Value,
            request.IsDone,
            request.Page,
            request.PageSize,
            cancellationToken
        );

        return orders;
    }
    
    private async Task<ErrorOr<List<Guid>>> GetColorId(string hexs, CancellationToken cancellationToken = default)
    {
        List<Guid> colorIds = new();

        foreach (var hex in hexs.Split(','))
        {
            var colorId = await _colorRepository.GetByHexValueAsync(hex, cancellationToken);

            if (colorId is null)
            {
                return Errors.Color.BadHexValue;
            }

            colorIds.Add(colorId.Value);
        }

        return colorIds;
    }
    
    private async Task<ErrorOr<List<Guid>>> GetMaintenanceId(string services, CancellationToken cancellationToken = default)
    {
        List<Guid> serviceIds = new();

        foreach (var title in services.Split(','))
        {
            var service = await _maintenanceServiceRepository.GetMaintenanceServiceByName(title, cancellationToken);

            if (service is null)
            {
                return Errors.MaintenanceService.NotFound;
            }

            serviceIds.Add(service.Id);
        }

        return serviceIds;
    }
    private async Task<ErrorOr<List<Guid>>> GetBrandId(string brands, CancellationToken cancellationToken = default)
    {
        List<Guid> brandIds = new();

        foreach (var brand in brands.Split(','))
        {
            var brandId = await _brandRepository.GetBrandIdByNameAsync(brand, cancellationToken);

            if (brandId is null)
            {
                return Errors.Brand.ThereIsNoBrandName;
            }

            brandIds.Add(brandId.Value);
        }

        return brandIds;
    }
    private async Task<ErrorOr<List<StoreId>>> GetStoreId(string storeIds, Profile profile, CancellationToken cancellationToken = default)
    {
        List<StoreId> ids = new();

        try
        {
            foreach (var store in storeIds.Split(','))
            {
                var storeId = StoreId.Create(Guid.Parse(store));
                var foundStore = await _storeService.GetStoreAsync(storeId, profile, cancellationToken);

                if (foundStore.IsError)
                {
                    return foundStore.Errors;
                }

                ids.Add(foundStore.Value.Id);
            }

            return ids;
        }
        catch (Exception e)
        {
            return Errors.Store.StoreNotFound;
        }
    }
}