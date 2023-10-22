using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;

namespace BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, AuthenticationResult>
{
    public async Task<AuthenticationResult> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        return new AuthenticationResult(
            "AccessToken",
            "RefreshToken");
    }
}