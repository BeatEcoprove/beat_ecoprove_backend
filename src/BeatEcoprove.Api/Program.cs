using BeatEcoprove.Api;
using BeatEcoprove.Api.Controllers;
using BeatEcoprove.Api.Middlewares;
using BeatEcoprove.Application;
using BeatEcoprove.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services
    .AddPresentation()
    .AddApplication()
    .AddInfrastructure(builder.Configuration);

var app = builder.Build();

app.UseCors(policyBuilder => policyBuilder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<ProfileCheckerMiddleware>();

app.Run();