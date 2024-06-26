﻿using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;

using ErrorOr;

namespace BeatEcoprove.Application.Closet.Commands.RemoveClothFromBucket;

public record RemoveClothFromBucketCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid BucketId,
    List<Guid> ClothToRemove
) : ICommand<ErrorOr<BucketResult>>, IAuthorization;