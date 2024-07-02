using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Domain.StoreAggregator.Daos;
using BeatEcoprove.Domain.StoreAggregator.Entities;

using ErrorOr;

namespace BeatEcoprove.Application.Stores.Commands.RegisterOrder;

public record RegisterOrderCommand
(
    Guid AuthId,
    Guid ProfileId,
    Guid StoreId,
    Guid OwnerId,
    Guid ClothId
) : IAuthorization, ICommand<ErrorOr<OrderDAO>>;