namespace BeatEcoprove.Application.Shared.Interfaces.Websockets;

public interface IConnectionManager<TKey, TValue>
{
    void Add(TKey key, TValue? value = default);
    Task CloseAsync(TKey key, CancellationToken cancellation = default);
    TValue? Get(TKey key);
}