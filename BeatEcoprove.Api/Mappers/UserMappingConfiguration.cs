using BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;
using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Contracts.Authentication.SignIn;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class UserMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<SignInPersonalAccountRequest, SignInPersonalAccountCommand>();
        config.NewConfig<SignInEnterpriseAccountRequest, SignInEnterpriseAccountCommand>();
    }
}