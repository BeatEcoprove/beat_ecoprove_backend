using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.ClosetAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.Shared.Errors;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateCloth;

public class CreateClothCommandHandler : ICommandHandler<CreateClothCommand, ErrorOr<Cloth>>
{
    private readonly IClothRepository _clothRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IFileStorageProvider _fileStorageProvider;
    private readonly IColorRepository _colorRepository;
    private readonly IProfileManager _profileManager;

    public CreateClothCommandHandler(
        IClothRepository clothRepository,
        IUnitOfWork unitOfWork,
        IFileStorageProvider fileStorageProvider,
        IColorRepository colorRepository, IProfileManager profileManager)
    {
        _clothRepository = clothRepository;
        _unitOfWork = unitOfWork;
        _fileStorageProvider = fileStorageProvider;
        _colorRepository = colorRepository;
        _profileManager = profileManager;
    }

    public async Task<ErrorOr<Cloth>> Handle(
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
        
        var cloth = Cloth.Create
        (
            request.Name,
            GarmentType.Male,
            GarmentSize.S,
            request.Brand,
            colorId
        );

        var clothPicture = profile.Value.Id.Value.ToString() + "-" + cloth.Id.Value.ToString();
        var clothPictureUrl = await _fileStorageProvider
            .UploadFileAsync(Buckets.ClothBucket, clothPicture, request.ClothAvatar, cancellationToken);

        cloth.SetClothPicture(clothPictureUrl);

        profile.Value.AddCloth(cloth);

        await _clothRepository.AddAsync(cloth, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return cloth;
    }
}