using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AdvertisementAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.CreateAdd;

public record CreateAddCommand
(
    Guid AuthId,
    Guid ProfileId,
    string Title,
    string Description,
    DateOnly BeginAt,
    DateOnly EndAt,
    Stream Picture,
    string Type,
    int Quantity = 0
) : IAuthorization, ICommand<ErrorOr<Advertisement>>;