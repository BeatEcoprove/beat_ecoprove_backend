using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.DAOs;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;
using Mapster;

namespace BeatEcoprove.Application.Closet.Queries.GetCloset;

internal sealed class GetClosetQueryHandler : IQueryHandler<GetClosetQuery, ErrorOr<MixedClothBucketList>>
{
    private readonly IProfileManager _profileManager;
    private readonly IProfileRepository _profileRepository;
    private readonly IColorRepository _colorRepository;
    private readonly IBrandRepository _brandRepository;

    public GetClosetQueryHandler(
        IProfileManager profileManager, 
        IProfileRepository profileRepository, 
        IColorRepository colorRepository, 
        IBrandRepository brandRepository)
    {
        _profileManager = profileManager;
        _profileRepository = profileRepository;
        _colorRepository = colorRepository;
        _brandRepository = brandRepository;
    }

    private ErrorOr<List<ClothType>>? GetCategory(string categories)
    {
        List<ClothType> clothTypes = new();
        
        foreach (var category in categories.Split(','))
        {
            if (!category.CanConvertToEnum(out ClothType result))
            {
                return Errors.Filters.Category;
            }

            clothTypes.Add(result);
        }

        return clothTypes;
    }
    
    private ErrorOr<List<ClothSize>>? GetSize(string size)
    {
        List<ClothSize> clothSizes = new();
        
        
        foreach (var category in size.Split(','))
        {
            if (!category.CanConvertToEnum(out ClothSize result))
            {
                return Errors.Filters.Category;
            }

            clothSizes.Add(result);
        }

        return clothSizes;
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

    public async Task<ErrorOr<MixedClothBucketList>> Handle(
        GetClosetQuery request, 
        CancellationToken cancellationToken)
    {
        ErrorOr<List<Guid>>? colorId = null;
        ErrorOr<List<Guid>>? brandId = null;
        
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var size = request.Size is null ? null : GetSize(request.Size);
        var categories = request.Categories is null ? null : GetCategory(request.Categories);
        var order = request.OrderBy is null ? null : GetOrderBy(request.OrderBy);

        var result = 
            ValidateParams(order);
        
        if (size is not null && size.Value.IsError)
        {
            result = size.Value.Errors;
        }
        
        if (categories is not null && categories.Value.IsError)
        {
            result = categories.Value.Errors;
        }
        
        if (request.Color != null)
        {
            colorId = await GetClothId(request.Color, cancellationToken);
            
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

        var nestedProfiles = await
            _profileManager.GetNestedProfileIds(authId, profile.Value.Id, cancellationToken);
        
        if (nestedProfiles.IsError)
        {
            return nestedProfiles.Errors;
        }
        
        var clothList = await _profileRepository.GetClosetCloth(
            profile.Value.Id,
            nestedProfiles.Value,
            request.Search?.ToLower(),
            categories?.Value,
            size?.Value,
            colorId?.Value,
            brandId?.Value,
            order?.Value,
            request.SortBy,
            request.PageSize,
            request.Page,
            cancellationToken);
        
        var bucketList = await _profileRepository.GetBucketCloth(
            profile.Value.Id, 
            clothList.Select(cloth => cloth.Id).ToList(),
            cancellationToken);
        
        var mapList = clothList.Select((cloth) =>
        {
            if (cloth is ClothDaoWithProfile clothDao)
            {
                return clothDao.Adapt<ClothResultExtension>();
            }
            
            return cloth.Adapt<ClothResult>();
        }).ToList();

        return new MixedClothBucketList(
            mapList, 
            bucketList);
    }

    private ErrorOr<dynamic> ValidateParams(ErrorOr<string>? order)
    {
        if (order is not null && order.Value.IsError)
        {
            return order.Value.Errors;
        }

        return true;
    }
}