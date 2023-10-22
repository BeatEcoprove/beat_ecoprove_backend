using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.Enumerators;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.RegisterPersonalAccount;

internal sealed class SignInPersonalAccountCommandHandler : ICommandHandler<SignInPersonalAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public SignInPersonalAccountCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInPersonalAccountCommand request, CancellationToken cancellationToken)
    {
        var email = Email.Create(request.Email);
        var password = Password.Create(request.Password);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var userName = UserName.Create(request.UserName);
        var gender = Gender.Female;

        var result = ValidateValues(email, password, phone);
        
        if (result.IsError)
        {
            return result.Errors;
        }
        
        // Check if user exists
        if (await _userRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailNotValid;
        }
        
        // Create User
        var personalAccount = Consumer.Create(
                email.Value,
                request.Name,
                password.Value,
                phone.Value,
                request.AvatarUrl,
                userName,
                gender,
                request.BornDate
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

    private static ErrorOr<Email> ValidateValues(
        ErrorOr<Email> email, 
        ErrorOr<Password> password, 
        ErrorOr<Phone> phone)
    {
        return email
            .AddValidate(password)
            .AddValidate(phone);
    }
}