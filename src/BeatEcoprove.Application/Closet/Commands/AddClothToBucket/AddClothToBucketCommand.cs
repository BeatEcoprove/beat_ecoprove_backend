using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.AddClothToBucket;

public record AddClothToBucketCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid BucketId,
    List<Guid> ClothToAdd
) : ICommand<ErrorOr<BucketResult>>;