using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;

public record SignInEnterpriseAccountCommand
(
    string Name,
    string TypeOption,
    string Phone,
    string CountryCode,
    string Street,
    int Port,
    string Locality,
    string PostalCode,
    string UserName,
    string AvatarUrl,
    string Email,
    string Password
) : ICommand<ErrorOr<AuthenticationResult>>;