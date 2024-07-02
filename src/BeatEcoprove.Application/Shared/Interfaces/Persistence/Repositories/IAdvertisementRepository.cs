using BeatEcoprove.Domain.AdvertisementAggregator;
using BeatEcoprove.Domain.AdvertisementAggregator.ValueObjects;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IAdvertisementRepository : IRepository<Advertisement, AdvertisementId> { }