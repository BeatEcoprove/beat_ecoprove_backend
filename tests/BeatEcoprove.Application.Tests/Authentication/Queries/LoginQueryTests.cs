using BeatEcoprove.Application.Authentication.Queries.Login;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;
using NSubstitute;

namespace BeatEcoprove.Application.Tests;

public class LoginQueryTests
{
    private readonly IAuthRepository _authRepository = Substitute.For<IAuthRepository>();
    private readonly IProfileRepository _profileRepository = Substitute.For<IProfileRepository>();
    private readonly IJwtProvider _jwtProvider = Substitute.For<IJwtProvider>();
    private readonly IPasswordProvider _passwordProvider = Substitute.For<IPasswordProvider>();

    private readonly LoginQueryHandler _sut;

    public LoginQueryTests()
    {
        _sut = new LoginQueryHandler(
            _authRepository,
            _profileRepository,
            _jwtProvider,
            _passwordProvider
        );
    }

    private LoginQuery GetSutQuery()
    {
        // Arrange
        return new Faker<LoginQuery>()
            .CustomInstantiator(f => new LoginQuery(
                f.Internet.Email(),
                "Password12"))
            .Generate();
    }

    private Auth GetAuth(string fakeEmail)
    {
        Email email = Email.Create(fakeEmail).Value;
        var password = Password.Create("Password12").Value;

        return Auth.Create(email, password);
    }

    private Organization GetProfile(AuthId authId)
    {
        var address = Address.Create(
              "Rua da Liberdade",
              12,
              "Porto",
              PostalCode.Create("4000-001").Value
              ).Value;

        return new Faker<Organization>()
            .CustomInstantiator(f => Organization.Create(
                authId,
                UserName.Create(f.Person.UserName),
                Phone.Create("+351", "915682123").Value,
                "https://github.com/DiogoCC7.png",
                address
                ))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_Login_UserDoesNotExists()
    {
        Email email;

        // Arrange
        var query = GetSutQuery();

        email = Email.Create(query.Email).Value;

        _authRepository.GetAuthByEmail(email, default)
            .Returns(null as Auth);

        // Act
        var result = await _sut.Handle(query, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }

    [Fact]
    public async Task ShouldNot_Login_ProfileDoesNotExists()
    {
        // Arrange
        var query = GetSutQuery();
        Auth auth = GetAuth(query.Email);

        _authRepository.GetAuthByEmail(auth.Email, default)
           .Returns(auth);

        _profileRepository.GetProfileByAuthId(
            Arg.Any<AuthId>(), default)
            .Returns(null as Profile);

        // Act
        var result = await _sut.Handle(query, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.ProfileDoesNotExists.Code);
    }

    [Fact]
    public async Task ShouldNot_Login_IncorrectCredentials()
    {
        // Arrange
        var query = GetSutQuery();
        Auth auth = GetAuth(query.Email);

        _authRepository.GetAuthByEmail(auth.Email, default)
           .Returns(auth);

        _profileRepository.GetProfileByAuthId(
            auth.Id, default)
            .Returns(GetProfile(auth.Id));

        _passwordProvider.VerifyPassword(
            query.Password, auth.Password)
            .Returns(false);

        // Act
        var result = await _sut.Handle(query, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.BadCredentials.Code);
    }

    [Fact]
    public async Task Should_GenerateTokens_WhenLoginCorrectly()
    {
        // Arrange
        var query = GetSutQuery();
        Auth auth = GetAuth(query.Email);

        _authRepository.GetAuthByEmail(auth.Email, default)
           .Returns(auth);

        _profileRepository.GetProfileByAuthId(
            auth.Id, default)
            .Returns(GetProfile(auth.Id));

        _passwordProvider.VerifyPassword(
            query.Password, auth.Password)
            .Returns(true);

        // Act
        var result = await _sut.Handle(query, default);

        // Assert
        Assert.False(result.IsError);
        Assert.NotNull(result.Value.AccessToken);
        Assert.NotNull(result.Value.RefreshToken);
    }
}
