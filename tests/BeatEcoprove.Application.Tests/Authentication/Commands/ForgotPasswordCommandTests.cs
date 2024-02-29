using System.Text.RegularExpressions;
using BeatEcoprove.Application.Authentication.Commands.ForgotPassword;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Domain.ProfileAggregator.Entities.Profiles;
using BeatEcoprove.Domain.ProfileAggregator.ValueObjects;
using BeatEcoprove.Domain.Shared.Errors;
using Bogus;

namespace BeatEcoprove.Application.Tests.Authentication.Commands;

public class ForgotPasswordCommandTests : AuthenticationBaseTests
{
    private readonly Regex _expression = new(@"\d{" + @Regex.Escape(ForgotPasswordCommandHandler.ForgotCodeLength.ToString()) + @"}\b");
    private readonly IKeyValueRepository<string> _keyValueRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IMailSender _mailSender;
    
    public ForgotPasswordCommandTests
        (IntegrationWebApplicationFactory factory) : base(factory)
    {
        _keyValueRepository = GetService<IKeyValueRepository<string>>();
        _jwtProvider = GetService<IJwtProvider>();
        _mailSender = GetService<IMailSender>();
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
        await CreateUserAccount<Consumer>(command.Email);

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
        await CreateUserAccount<Consumer>(command.Email);

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
