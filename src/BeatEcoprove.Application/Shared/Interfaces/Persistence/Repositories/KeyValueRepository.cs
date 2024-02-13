
using StackExchange.Redis;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public class KeyValueRepository : IKeyValueRepository<string>
{
    private readonly IDatabase _database;

    public KeyValueRepository(IDatabase database)
    {
        _database = database;
    }

    public async Task AddAsync(string key, string value, TimeSpan? expirationSpan)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        await _database.StringAppendAsync(key, value.ToString());
        await _database.KeyExpireAsync(key, expirationSpan);
    }

    public async Task DeleteAsync(string key)
    {
        await _database.StringGetDeleteAsync(key);
    }

    public async Task<string?> GetAndDeleteAsync(string key)
    {
        return await _database.StringGetDeleteAsync(key);
    }

    public async Task<string?> GetAsync(string key)
    {
        return await _database.StringGetAsync(key);
    }
}
