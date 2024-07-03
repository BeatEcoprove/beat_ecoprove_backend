using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.PostRating;

public record PostRatingCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    double Rating
) : IAuthorization, ICommand<ErrorOr<RatingDao>>;