
using BeatEcoprove.Domain.Shared.Models;

using StackExchange.Redis;

namespace BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;

public class KeyValueRepository : IKeyValueRepository<string>
{
    private readonly IDatabase _database;

    public KeyValueRepository(IDatabase database)
    {
        _database = database;
    }

    public async Task AddAsync(Key key, string value, TimeSpan? expirationSpan = null)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value));
        }

        await _database.StringAppendAsync(key.Value, value.ToString());
        await _database.KeyExpireAsync(key.Value, expirationSpan ?? TimeSpan.FromDays(7));
    }

    public async Task DeleteAsync(Key key)
    {
        await _database.StringGetDeleteAsync(key.Value);
    }

    public async Task<string?> GetAndDeleteAsync(Key key)
    {
        return await _database.StringGetDeleteAsync(key.Value);
    }

    public async Task<string?> GetAsync(Key key)
    {
        return await _database.StringGetAsync(key.Value);
    }
}