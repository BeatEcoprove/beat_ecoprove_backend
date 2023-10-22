using BeatEcoprove.Api;
using BeatEcoprove.Api.Controllers;
using BeatEcoprove.Application;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services
    .AddPresentation()
    .AddApplication();

var app = builder.Build();

app.MapAuthenticationEndpoints();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();