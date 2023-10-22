using BeatEcoprove.Application.Interfaces.Persistence;
using BeatEcoprove.Application.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;

namespace BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, AuthenticationResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SignInPersonalAccountCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResult> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var userName = UserName.Create(request.UserName);
        var gender = Gender.Female;
        
        // Check if user exists
        if (await _userRepository.ExistsUserByEmailAsync(email, cancellationToken))
        {
            throw new Exception("User already exists");
        }
        
        // Create User
        var personalAccount = Consumer.Create(
                email,
                request.Name,
                password,
                phone,
                request.AvatarUrl,
                userName,
                gender,
                request.BornDate,
                request.Xp,
                request.SustainabilityPoints,
                request.EcoScore
            );
        
        // Persist User
        await _userRepository.AddAsync(personalAccount, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
        
        // Generate Tokens

        // Return Tokens
        return new AuthenticationResult(
            "AccessToken",
            "RefreshToken");
    }
}