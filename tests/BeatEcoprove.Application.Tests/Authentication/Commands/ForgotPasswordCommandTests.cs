using System.Text.RegularExpressions;
using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Application.Shared.Interfaces.Services;
using BeatEcoprove.Domain.AuthAggregator;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.Enumerators;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ForgotPasswordCommandTests : BaseIntegrationTest
{
    private readonly Regex _expression = new(@"\d{" + @Regex.Escape(ForgotPasswordCommandHandler.ForgotCodeLength.ToString()) + @"}\b");
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IMailSender _mailSender;
    private readonly IAccountService _accountService;
    private readonly IUnitOfWork _unitOfWork;
    
    public ForgotPasswordCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _keyValueRepository = GetService<IKeyValueRepository<string>>();
        _accountService = GetService<IAccountService>();
        _jwtProvider = GetService<IJwtProvider>();
        _unitOfWork = GetService<IUnitOfWork>();
        _mailSender = GetService<IMailSender>();
    }
    
    private static async Task<Stream> GetAvatarPicture()
    {
        using HttpClient httpClient = new();
        var response = httpClient.GetAsync("https://github.com/DiogoCC7.png");

        return await response.Result.Content.ReadAsStreamAsync();
    }

    private async Task CreateUserAccount(
        string email,
        CancellationToken cancellationToken = default)
    {
        var avatarPicture = await GetAvatarPicture();
        var auth = new Faker<Auth>()
            .CustomInstantiator(f =>
                    Auth.Create(
                        Email.Create(email).Value,
                        Password.Create("Password123").Value))
            .Generate();
        
        var profile = new Faker<Consumer>()
            .CustomInstantiator(f =>
                Consumer.Create(
                    UserName.Create(f.Internet.UserName()).Value,
                    Phone.Create("+351", f.Phone.PhoneNumber("#########")).Value,
                    DateOnly.FromDateTime(f.Person.DateOfBirth),
                    Gender.Male))
            .Generate();
        
        await _accountService.CreateAccount(
            auth.Email,
            auth.Password,
            profile,
            avatarPicture,
            cancellationToken);
        
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
    
    private ForgotPasswordCommand GetSutCommand()
    {
        return new Faker<ForgotPasswordCommand>()
            .CustomInstantiator(f => new ForgotPasswordCommand(
                f.Internet.Email()))
            .Generate();
    }

    [Fact]
    public async Task ShouldNot_SendForgotEmail_WhenUserDoesNotExists()
    {
        // Arrange
        var command = GetSutCommand();

        // Act
        var result = await Sender.Send(command);

        // Assert
        Assert.True(result.IsError);
        Assert.Equal(result.FirstError.Code, Errors.User.EmailDoesNotExists.Code);
    }
    
    [Fact]
    public async Task Should_GenerateTokenAndPersistItOnMemory()
    {
        // Arrange
        var command = GetSutCommand();
        await CreateUserAccount(command.Email);

        // Act
        var result = await Sender.Send(command);

        // Assert
        var lastEmail = _mailSender.Last();
        
        Assert.False(result.IsError);
        Assert.NotNull(lastEmail);
        
        var match = _expression.Match(lastEmail.Body);
        var code = match.Value;
        
        Assert.True(match.Success);

        var forgotToken = await _keyValueRepository.GetAsync(new ForgotKey(code));
        Assert.NotNull(forgotToken);
    }
    
    [Fact]
    public async Task Should_ForgotTokenBeValid_WhenTokenIsPersisted()
    {
        // Arrange
        var command = GetSutCommand();
        await CreateUserAccount(command.Email);

        // Act
        await Sender.Send(command);
        var lastEmail = _mailSender.Last()!;
        var code = _expression.Match(lastEmail.Body).Value;
        
        var forgotToken = await _keyValueRepository.GetAsync(new ForgotKey(code));
        // Assert
        
        Assert.NotNull(forgotToken);
        var result = await _jwtProvider.ValidateTokenAsync(forgotToken);
        Assert.True(result);
    }
}
