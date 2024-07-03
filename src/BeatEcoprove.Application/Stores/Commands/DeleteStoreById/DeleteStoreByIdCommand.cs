using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.DeleteStoreById;

public record DeleteStoreByIdCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId
) : IAuthorization, ICommand<ErrorOr<Store>>;