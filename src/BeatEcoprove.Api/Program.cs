using BeatEcoprove.Api;
using BeatEcoprove.Application;
using BeatEcoprove.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder
    .Build();

app.SetupConfiguration();
app.Run();