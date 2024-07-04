using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Application.Shared.Interfaces.Services.Common;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.StoreAggregator;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Queries.GetAllStores;

internal sealed class GetAllStoresQueryHandler : IQueryHandler<GetAllStoresQuery, ErrorOr<List<Order>>>
{
    private readonly IProfileManager _profileManager;
    private readonly IStoreService _storeService;
    private readonly IBrandRepository _brandRepository;
    private readonly IColorRepository _colorRepository;
    private readonly IMaintenanceServiceRepository _maintenanceServiceRepository;

    public GetAllStoresQueryHandler(IProfileManager profileManager, IStoreService storeService, IBrandRepository brandRepository, IColorRepository colorRepository, IMaintenanceServiceRepository maintenanceServiceRepository)
    {
        _profileManager = profileManager;
        _storeService = storeService;
        _brandRepository = brandRepository;
        _colorRepository = colorRepository;
        _maintenanceServiceRepository = maintenanceServiceRepository;
    }

    private async Task<ErrorOr<List<Guid>>> GetServiceId(string services, CancellationToken cancellationToken = default)
    {
        List<Guid> serviceIds = new();

        foreach (var service in services.Split(','))
        {
            var serviceId =
                await _maintenanceServiceRepository.GetMaintenanceServiceByName(service, cancellationToken);

            if (serviceId is null)
            {
                return Errors.MaintenanceService.NotFound;
            }

            serviceIds.Add(serviceId.Id);
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
    
    
    private async Task<ErrorOr<List<Guid>>> GetClothId(string hexs, CancellationToken cancellationToken = default)
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

    private ErrorOr<dynamic> ValidateParams(ErrorOr<string>? order)
    {
        if (order is not null && order.Value.IsError)
        {
            return order.Value.Errors;
        }

        return true;
    }
    
    
    private ErrorOr<string>? GetOrderBy(string orderBy)
    {
        return orderBy switch
        {
            "size" => "size",
            "color" => "color",
            "brand" => "brand",
            _ => Errors.Filters.Order,
        };
    }

    public async Task<ErrorOr<List<Order>>> Handle(GetAllStoresQuery request, CancellationToken cancellationToken)
    {
        ErrorOr<List<Guid>>? colorId = null;
        ErrorOr<List<Guid>>? brandId = null;
        ErrorOr<List<Guid>>? serviceId = null;
        
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var order = request.OrderBy is null ? null : GetOrderBy(request.OrderBy);
        var result = ValidateParams(order);
        
        if (request.Color != null)
        {
            colorId = await GetClothId(request.Color, cancellationToken);

            if (colorId.Value.IsError)
            {
                result = colorId.Value.Errors;
            }
        }
        
        if (request.Services != null)
        {
            serviceId = await GetServiceId(request.Services, cancellationToken);

            if (serviceId.Value.IsError)
            {
                result = serviceId.Value.Errors;
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
        
        var stores = await _storeService.GetAllStoresAsync(
            profile.Value.Id,
            new GetAllStoreInput(
                serviceId?.Value,
                colorId?.Value,
                brandId?.Value,
                request.Search,
                request.OrderBy,
                request.Page,
                request.PageSize
            ),
            cancellationToken
        );

        return stores;
    }
}