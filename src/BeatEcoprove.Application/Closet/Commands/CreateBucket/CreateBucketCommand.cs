using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateBucket;

public record CreateBucketCommand
(
    Guid ProfileId,
    string Name,
    List<Guid> ClothIds
) : ICommand<ErrorOr<string>>;