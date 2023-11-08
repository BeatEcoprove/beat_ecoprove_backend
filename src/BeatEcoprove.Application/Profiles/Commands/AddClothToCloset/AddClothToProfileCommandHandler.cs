using ErrorOr;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;

namespace BeatEcoprove.Application.Profiles.Commands.AddClothToCloset;

public class AddClothToProfileCommandHandler : ICommandHandler<AddClothToProfileCommand, ErrorOr<Cloth>>
{
    private readonly IClothRepository _clothRepository;
    private readonly IAuthorizationFacade _authorizationFacade;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IProfileRepository _profileRepository;

    public AddClothToProfileCommandHandler(
        IClothRepository clothRepository, 
        IAuthorizationFacade authorizationFacade, 
        IUnitOfWork unitOfWork, 
        IProfileRepository profileRepository)
    {
        _clothRepository = clothRepository;
        _authorizationFacade = authorizationFacade;
        _unitOfWork = unitOfWork;
        _profileRepository = profileRepository;
    }

    private async Task<ErrorOr<Profile>> GetProfileAsync(string email, Guid profileIdValue, CancellationToken cancellationToken)
    {
        var profileId = ProfileId.Create(profileIdValue);

        var profileError = await _authorizationFacade.GetAuthProfileByEmailAsync(email, cancellationToken);

        if (profileError.IsError)
        {
            return profileError.Errors;
        }

        var profile = profileError.Value;

        if (profile.Id == profileId)
        {
            return profile;
        }
        
        profile = await _profileRepository.GetByIdAsync(profileId, cancellationToken);
        
        if (profile is null)
        {
            return Errors.User.ProfileDoesNotExists;
        }

        return profile;
    }

    public async Task<ErrorOr<Cloth>> Handle(
        AddClothToProfileCommand request, 
        CancellationToken cancellationToken)
    {
        var profile = await GetProfileAsync(request.Email, request.Profile, cancellationToken);

        if (profile.IsError)
        {
            return profile.Errors;
        }

        var cloth = Cloth.Create
        (
            request.Name,
            GarmentType.Male,
            GarmentSize.S,
            request.Brand,
            request.Color,
            "https://github.com/DiogoCC7.png"
        );
        
        profile.Value.AddCloth(cloth);
        
        await _clothRepository.AddAsync(cloth, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return cloth;
    }
}