using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.Shared.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Colors.Queries;

public record GetColorsQuery : IQuery<ErrorOr<List<Color>>>;