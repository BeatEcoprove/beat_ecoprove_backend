using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Services;

public interface IAccountService
{
    Task<Auth> CreateAccount(Email email, Password password, Profile profile, Stream AvatarStream, CancellationToken cancellationToken);
}