using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAccountService
{
    Task<ErrorOr<Auth>> CreateAccount(Email email, Password password, Profile profile, Stream AvatarStream, CancellationToken cancellationToken);
    ErrorOr<Gender> GetGender(string gender);
}