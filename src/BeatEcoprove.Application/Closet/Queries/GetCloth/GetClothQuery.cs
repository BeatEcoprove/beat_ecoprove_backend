﻿using BeatEcoprove.Application.Closet.Common;
using BeatEcoprove.Application.Shared;
using ErrorOr;

namespace BeatEcoprove.Application.Closet.Queries.GetCloth;

public record GetClothQuery
(
    Guid AuthId,
    Guid ProfileId,
    Guid ClothId
) : IQuery<ErrorOr<ClothResult>>;