using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.CompleteOrder;

public record CompleteOrderCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    Guid OrderId,
    Guid OwnerId
) : IAuthorization, ICommand<ErrorOr<OrderDAO>>;