using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Domain.ProfileAggregator.ValueObjects;

public record ForgotKey(string Code)
    : Key(Code);