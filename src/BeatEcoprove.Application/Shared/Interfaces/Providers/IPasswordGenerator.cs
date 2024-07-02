using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Providers;

public interface IPasswordGenerator
{
    Password GeneratePassword(int minPasswordLength, int maxPasswordLength);
}