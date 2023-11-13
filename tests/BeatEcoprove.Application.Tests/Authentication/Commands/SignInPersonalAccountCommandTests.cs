﻿using BeatEcoprove.Application.Authentication.Commands.SignInPersonalAccount;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;
using NSubstitute;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class SignInPersonalAccountCommandTests
{
    private readonly IAuthRepository _authRepository = Substitute.For<IAuthRepository>();
    private readonly IProfileRepository _profileRepository = Substitute.For<IProfileRepository>();
    private readonly IUnitOfWork _unitOfWork = Substitute.For<IUnitOfWork>();
    private readonly IJwtProvider _jwtProvider = Substitute.For<IJwtProvider>();
    private readonly IPasswordProvider _passwordProvider = Substitute.For<IPasswordProvider>();
    private readonly IFileStorageProvider _fileStorageProvider = Substitute.For<IFileStorageProvider>();

    private readonly SignInPersonalAccountCommandHandler _sut;

    public SignInPersonalAccountCommandTests()
    {
        _sut = new SignInPersonalAccountCommandHandler(
            _authRepository,
            _profileRepository,
            _unitOfWork,
            _jwtProvider,
            _passwordProvider,
            _fileStorageProvider);
    }

    private async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

       return await response.Result.Content.ReadAsStreamAsync();
    }

    private async Task<SignInPersonalAccountCommand> GetSutCommand()
    {
        var avatarPicture = await GetAvatarPicture();

        // Arrange
        return new Faker<SignInPersonalAccountCommand>()
            .CustomInstantiator(f => new SignInPersonalAccountCommand(
                f.Person.FullName,
                DateOnly.FromDateTime(f.Person.DateOfBirth),
                f.Internet.UserName(),
                "Male",
                "+351",
                "914953124",
                avatarPicture,
                f.Internet.Email(),
                "Password12"))
            .Generate();
    }

    // TODO: Validate if user exists should return error
    [Fact]
    public async Task ShouldNot_SignInPersonalAccount_WhenUserAlreadyExists()
    {
        // Arrange
        var command = await GetSutCommand();

        _authRepository.ExistsUserByEmailAsync(
            Email.Create(command.Email).Value,
            default).Returns(true);

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailAlreadyExists.Code);
    }

    [Fact]
    public async Task ShouldNot_SignInPersonalAccount_WhenUserNameAlreadyUsed()
    {
        // Arrange
        var command = await GetSutCommand();

        _profileRepository.ExistsUserByUserNameAsync(
            UserName.Create(command.UserName),
            default).Returns(true);

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.UserNameAlreadyExists.Code);
    }

    [Fact]
    public async Task Should_ReturnAuthTokens_WhenUserSignInPersonalAccount()
    {
        var command = await GetSutCommand();

        // Act
        var result = await _sut.Handle(command, default);

        // Assert
        Assert.False(result.IsError);
        await _authRepository.Received(1).AddAsync(Arg.Any<Auth>(), default);
    }
}