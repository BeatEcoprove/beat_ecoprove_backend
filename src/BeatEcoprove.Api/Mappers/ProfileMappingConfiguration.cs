using BeatEcoprove.Application;
using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Contracts;
using BeatEcoprove.Contracts.Authentication;
using BeatEcoprove.Contracts.Authentication.SignIn;
using BeatEcoprove.Contracts.Profile;
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
                    src.UserName.Value,
                    0,
                    0,
                    src.SustainabilityPoints,
                    src.AvatarUrl
                )
            );

        config.NewConfig<SignInPersonalAccountRequest, SignInPersonalAccountCommand>()
            .MapWith((source) =>
                new SignInPersonalAccountCommand(
                    source.Name,
                    source.BornDate,
                    source.UserName,
                    source.Gender,
                    source.CountryCode,
                    source.Phone,
                    source.AvatarPicture.OpenReadStream(),
                    source.Email,
                    source.Password));

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
                    src.AvatarPicture.OpenReadStream(),
                    src.Email,
                    src.Password)
                );
    }
}