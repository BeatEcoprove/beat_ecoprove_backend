using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Application.Tests;

[Collection("Test Collection")]
public abstract class BaseIntegrationTest : IClassFixture<IntegrationWebApplicationFactory>, IAsyncLifetime
{
    private readonly IServiceScope _scope;
    protected readonly ISender Sender;
    private readonly Func<Task> _resetDatabase;

    protected BaseIntegrationTest(IntegrationWebApplicationFactory factory)
    {
        _scope = factory.Services.CreateScope();
        
        Sender = _scope.ServiceProvider.GetRequiredService<ISender>();
        _resetDatabase = factory.ResetDatabaseAsync;
    }

    protected TService GetService<TService>() 
        where TService : notnull
    {
        return _scope.ServiceProvider.GetRequiredService<TService>();
    }

    public Task InitializeAsync() => Task.CompletedTask;

    public Task DisposeAsync() => _resetDatabase();
}