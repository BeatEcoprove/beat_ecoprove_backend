using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.ClothAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Cloths;
using ErrorOr;

namespace BeatEcoprove.Application.Profiles.Queries;

public record GetClosetQuery
(
    string UserEmail
) : IQuery<ErrorOr<List<Cloth>>>;