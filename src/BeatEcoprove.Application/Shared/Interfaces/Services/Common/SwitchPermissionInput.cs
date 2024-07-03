using BeatEcoprove.Domain.StoreAggregator.Enumerators;
using BeatEcoprove.Domain.StoreAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Services.Common;

public record SwitchPermissionInput
(
    WorkerId WorkerId,
    WorkerType WorkerType
);