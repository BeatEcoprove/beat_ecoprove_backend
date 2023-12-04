using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Extensions;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateCloth;

public class CreateClothCommandHandler : ICommandHandler<CreateClothCommand, ErrorOr<ClothResult>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IColorRepository _colorRepository;
    private readonly IProfileManager _profileManager;
    private readonly IClosetService _closetService;
    private readonly IBrandRepository _brandRepository;

    public CreateClothCommandHandler(
        IUnitOfWork unitOfWork,
        IColorRepository colorRepository, 
        IProfileManager profileManager, 
        IClosetService closetService, 
        IBrandRepository brandRepository)
    {
        _unitOfWork = unitOfWork;
        _colorRepository = colorRepository;
        _profileManager = profileManager;
        _closetService = closetService;
        _brandRepository = brandRepository;
    }

    public async Task<ErrorOr<ClothResult>> Handle(
        CreateClothCommand request,
        CancellationToken cancellationToken)
    {
        var profile = await _profileManager.GetProfileAsync(request.AuthId, request.ProfileId, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var colorId = await _colorRepository.GetByHexValueAsync(request.Color, cancellationToken);

        if (colorId is null)
        {
            return Errors.Color.BadHexValue;
        }
        
        var brandId = await _brandRepository.GetBrandIdByNameAsync(request.Brand, cancellationToken);

        if (brandId is null)
        {
            return Errors.Brand.ThereIsNoBrandName;
        }

        var clothType = _closetService.GetClothType(request.ClothType);
        var clothSize = _closetService.GetClothSize(request.ClothSize);

        var shouldBeValidTypes = clothType.AddValidate(clothSize);
        
        if (shouldBeValidTypes.IsError)
        {
            return shouldBeValidTypes.Errors;
        }
        
        var cloth = Cloth.Create
        (
            request.Name.Capitalize(),
            clothType.Value,
            clothSize.Value,
            brandId,
            colorId
        );

        if (cloth.IsError)
        {
            return cloth.Errors;
        }

        var clothResult = await _closetService.AddClothToCloset(
            profile.Value, 
            cloth.Value, 
            request.Brand,
            request.Color, 
            request.ClothAvatar, 
            cancellationToken);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return clothResult;
    }
}