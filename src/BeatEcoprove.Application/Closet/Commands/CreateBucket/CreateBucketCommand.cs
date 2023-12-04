using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.CreateBucket;

public record CreateBucketCommand
(
    Guid AuthId,
    Guid ProfileId,
    string Name,
    List<Guid> ClothIds
) : ICommand<ErrorOr<BucketResult>>, IAuthorization;
