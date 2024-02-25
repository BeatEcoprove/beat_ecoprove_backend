using BeatEcoprove.Infrastructure.Persistence;
using BeatEcoprove.Infrastructure.Persistence.Shared;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace BeatEcoprove.Application.Tests;

public abstract class BaseIntegrationTest : IClassFixture<IntegrationWebApplicationFactory>
{
    protected readonly ISender Sender;
    protected readonly BeatEcoproveDbContext DbContext;

    protected BaseIntegrationTest(IntegrationWebApplicationFactory factory)
    {
        var scope = factory.Services.CreateScope();
        
        Sender = scope.ServiceProvider.GetRequiredService<ISender>();
        DbContext = scope.ServiceProvider.GetRequiredService<BeatEcoproveDbContext>();
    }
}