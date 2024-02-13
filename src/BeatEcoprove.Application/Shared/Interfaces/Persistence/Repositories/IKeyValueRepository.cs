namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public interface IKeyValueRepository<TValue>
{
    Task AddAsync(string key, TValue value, TimeSpan? expirationSpan = null);
    Task<TValue?> GetAsync(string key);
    Task<TValue?> GetAndDeleteAsync(string key);
    Task DeleteAsync(string key);
}
