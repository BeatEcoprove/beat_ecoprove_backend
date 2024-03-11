using BeatEcoprove.Api;
using BeatEcoprove.Application;
using BeatEcoprove.Infrastructure;

using DotNetEnv;

Env.Load($"../../.env");
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration)
    .AddSwagger();

var app = builder
    .Build();

app.SetupConfiguration();
app.Run();

public abstract partial class Program { }