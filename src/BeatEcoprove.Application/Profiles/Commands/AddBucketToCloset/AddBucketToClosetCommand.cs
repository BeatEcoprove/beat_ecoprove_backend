using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ClothAggregator;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Commands.AddBucketToCloset;

public record AddBucketToClosetCommand
(
    Guid ProfileId,
    string Name,
    List<Guid> ClothIds
) : ICommand<ErrorOr<string>>;