using BeatEcoprove.Application.Shared;
using BeatEcoprove.Domain.Shared.Entities;
using ErrorOr;

namespace BeatEcoprove.Application.Brands.Queries;

public record GetAllBrandsQuery : IQuery<ErrorOr<List<Brand>>>;