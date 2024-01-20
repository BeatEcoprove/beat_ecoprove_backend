using BeatEcoprove.Application;
using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Contracts;
using BeatEcoprove.Contracts.Authentication;
using BeatEcoprove.Contracts.Authentication.SignIn;
using BeatEcoprove.Contracts.Profile;
using BeatEcoprove.Domain.ProfileAggregator.DAOS;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class ProfileMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<LoginRequest, LoginQuery>();
        config.NewConfig<ForgotPasswordRequest, ForgotPasswordCommand>();
        config.NewConfig<Profile, ProfileResponse>()
            .MapWith((src) =>
                new ProfileResponse(
                    src.Id.Value,
                    src.UserName.Value,
                    0,
                    0,
                    src.SustainabilityPoints,
                    src.AvatarUrl
                )
            );
        
        config.NewConfig<Profile, ProfileClosetResponse>()
            .MapWith((src) =>
                new ProfileClosetResponse(
                    src.Id.Value,
                    src.UserName.Value,
                    src.AvatarUrl
                )
            );

        config.NewConfig<List<ProfileDao>, MyProfilesResponse>()
            .MapWith(src => ToMyProfilesResponse(src));

        config.NewConfig<SignInPersonalAccountRequest, SignInPersonalAccountCommand>()
            .MapWith((src) => 
                new SignInPersonalAccountCommand(
                    src.Name,
                    src.BornDate,
                    src.UserName,
                    src.Gender,
                    src.CountryCode,
                    src.Phone,
                    src.PictureStream,
                    src.Email,
                    src.Password));

        config.NewConfig<SignInEnterpriseAccountRequest, SignInEnterpriseAccountCommand>()
            .MapWith((src) =>
                new SignInEnterpriseAccountCommand(
                    src.Name,
                    src.TypeOption,
                    src.Phone,
                    src.CountryCode,
                    src.Street,
                    src.Port,
                    src.Locality,
                    src.PostalCode,
                    src.UserName,
                    src.PictureStream,
                    src.Email,
                    src.Password)
                );
    }
    
    private MyProfilesResponse ToMyProfilesResponse(List<ProfileDao> profiles)
    {
        var mainProfile = 
            profiles.SingleOrDefault(profile => profile.IsNested);

        if (mainProfile is null)
        {
            throw new Exception("Main profile not found");
        }

        var nestedProfiles =
            profiles
                .Where(profile => !profile.IsNested)
                .Select(profile => profile.Profile)
                .ToList();
        
        return new MyProfilesResponse(
            mainProfile.Profile.Adapt<ProfileResponse>(),
            nestedProfiles.Adapt<List<ProfileResponse>>()
        );
    }
}