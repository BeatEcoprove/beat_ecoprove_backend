using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.AuthAggregator.ValueObjects;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAccountService
{
    Task<ErrorOr<Auth>> CreateAccount(
        Email email, 
        Password password, 
        Profile profile, 
        Stream avatarStream, 
        CancellationToken cancellationToken);

    Task<ErrorOr<Auth>> DeleteAccount(
        AuthId authId,
        ProfileId profileId,
        CancellationToken cancellationToken);
    
    Task<ErrorOr<Auth>> CreateAccountFromProfile(
        Email email,
        Password password,
        Profile profile,
        CancellationToken cancellationToken = default);
    
    ErrorOr<Gender> GetGender(string gender);
}