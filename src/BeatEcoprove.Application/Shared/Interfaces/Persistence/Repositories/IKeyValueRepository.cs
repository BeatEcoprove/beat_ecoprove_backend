using BeatEcoprove.Domain.Shared.Models;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
public interface IKeyValueRepository<TValue>
{
    Task AddAsync(Key key, TValue value, TimeSpan? expirationSpan = null);
    Task<TValue?> GetAsync(Key key);
    Task<TValue?> GetAndDeleteAsync(Key key);
    Task DeleteAsync(Key key);
}
