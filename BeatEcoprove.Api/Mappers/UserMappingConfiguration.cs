using BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;
using BeatEcoprove.Contracts.Authentication.SignIn;
using Mapster;

namespace BeatEcoprove.Api.Mappers;

public class UserMappingConfiguration : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<SignInPersonalAccountRequest, SignInPersonalAccountCommand>();
    }
}