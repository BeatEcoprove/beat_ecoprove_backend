using System.Windows.Input;

using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.AdvertisementAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RemoveAdvert;

public record RemoveAdvertCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid AdvertId
) : IAuthorization, ICommand<ErrorOr<Advertisement>>;