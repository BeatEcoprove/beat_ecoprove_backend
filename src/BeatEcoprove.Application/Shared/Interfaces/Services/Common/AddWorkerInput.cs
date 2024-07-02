using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.StoreAggregator.Enumerators;

namespace BeatEcoprove.Application.Shared.Interfaces.Services.Common;

public record AddWorkerInput(
    string Name,
    Email Email,
    WorkerType Type);