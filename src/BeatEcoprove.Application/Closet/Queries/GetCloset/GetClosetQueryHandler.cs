using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClosetAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Entities;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
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
    
    private ErrorOr<ClothSize>? GetSize(string size)
    {
        if (size.CanConvertToEnum(out ClothSize result))
        {
            return result;
        }
        
        return Errors.Filters.Size;
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

    private async Task<ErrorOr<Guid>> GetClothId(string hex, CancellationToken cancellationToken = default)
    {
        var colorId = await _colorRepository.GetByHexValueAsync(hex, cancellationToken);

        if (colorId is null)
        {
            return Errors.Color.BadHexValue;
        }

        return colorId.Value;
    }
    private async Task<ErrorOr<Guid>> GetBrandId(string brand, CancellationToken cancellationToken = default)
    {
        var brandId = await _brandRepository.GetBrandIdByNameAsync(brand, cancellationToken);

        if (brandId is null)
        {
            return Errors.Brand.ThereIsNoBrandName;
        }
        
        return brandId.Value;
    }

    public async Task<ErrorOr<MixedClothBucketList>> Handle(
        GetClosetQuery request, 
        CancellationToken cancellationToken)
    {
        ErrorOr<Guid>? colorId = null;
        ErrorOr<Guid>? brandId = null;
        
        var authId = AuthId.Create(request.AuthId);
        var profileId = ProfileId.Create(request.ProfileId);
        var size = request.Size is null ? null : GetSize(request.Size);
        var categories = request.Categories is null ? null : GetCategory(request.Categories);
        var order = request.OrderBy is null ? null : GetOrderBy(request.OrderBy);

        var result = 
            ValidateParams(size, order);
        
        if (request.Color != null)
        {
            colorId = await GetClothId(request.Color, cancellationToken);
            result = colorId?.AddValidate(result)!;
        }

        if (request.Brand != null)
        {
            brandId = await GetBrandId(request.Brand, cancellationToken);
            result = brandId?.AddValidate(result)!;
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
            nestedProfiles.Value,
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

        return new MixedClothBucketList(
            clothList.Adapt<List<ClothResult>>(), 
            bucketList);
    }

    private ErrorOr<dynamic> ValidateParams(
        ErrorOr<ClothSize>? size, 
        ErrorOr<string>? order)
    {
        if (size is not null && size.Value.IsError)
        {
            return size.Value.Errors;
        }
      
        if (order is not null && order.Value.IsError)
        {
            return order.Value.Errors;
        }

        return true;
    }
}