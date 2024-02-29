using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication;

public abstract class AuthenticationBaseTests : BaseIntegrationTest
{
    protected const string DefaultPassword = "Password1";
    protected const string NewDefaultPassword = "NewPassword1";
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;

    protected AuthenticationBaseTests(
        IntegrationWebApplicationFactory factory) : base(factory)
    {
        _accountService = GetService<IAccountService>();
        _unitOfWork = GetService<IUnitOfWork>();
    }

    protected static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

        return await response.Result.Content.ReadAsStreamAsync();
    }

    protected (Auth, TProfile) GetAuth<TProfile>(
        string? email = null,
        string password = DefaultPassword,
        string? username = null)
        where TProfile : Profile
    {
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                Auth.Create(
                    Email.Create(email ?? f.Internet.Email()).Value,
                    Password.Create(password).Value))
            .Generate();

        var profile = new Faker<TProfile>()
            .CustomInstantiator(f =>
            {
                if (typeof(TProfile) == typeof(Consumer))
                    return (Consumer.Create(
                        UserName.Create(username ?? f.Internet.UserName()).Value,
                        Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                        DateOnly.FromDateTime(f.Person.DateOfBirth),
                        Gender.Male) as TProfile)!;

                return (Organization.Create(
                    UserName.Create(username ?? f.Internet.UserName()).Value,
                    Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                    Address.Create(
                        "",
                        1,
                        "",
                        PostalCode.Create(f.Address.ZipCode("####-###")).Value).Value) as TProfile)!;
            })
            .Generate();

        return (auth, profile);
    }

    protected async Task CreateUserAccount<TProfile>(
        string? email = null,
        string password = DefaultPassword,
        string? username = null,
        CancellationToken cancellationToken = default)
        where TProfile : Profile
    {
        var avatarPicture = await GetAvatarPicture();
        var (auth, profile) = GetAuth<TProfile>(email, password, username);

        await _accountService.CreateAccount(
            auth.Email,
            auth.Password,
            profile,
            avatarPicture,
            cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}