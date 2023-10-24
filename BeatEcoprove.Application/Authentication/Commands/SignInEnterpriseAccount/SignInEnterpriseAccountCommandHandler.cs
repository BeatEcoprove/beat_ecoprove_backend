using BeatEcoprove.Application.Shared;
using BeatEcoprove.Application.Shared.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Helpers;
using BeatEcoprove.Application.Shared.Interfaces.Persistence;
using BeatEcoprove.Application.Shared.Interfaces.Persistence.Repositories;
using BeatEcoprove.Application.Shared.Interfaces.Providers;
using BeatEcoprove.Contracts.Authentication.Common;
using BeatEcoprove.Domain.Shared.Errors;
using BeatEcoprove.Domain.Shared.Extensions;
using BeatEcoprove.Domain.UserAggregator.Entities;
using BeatEcoprove.Domain.UserAggregator.ValueObjects;
using ErrorOr;

namespace BeatEcoprove.Application.Authentication.Commands.SignInEnterpriseAccount;

public class SignInEnterpriseAccountCommandHandler : ICommandHandler<SignInEnterpriseAccountCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;

    public SignInEnterpriseAccountCommandHandler(
        IUserRepository userRepository, 
        IUnitOfWork unitOfWork, 
        IJwtProvider jwtProvider)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(SignInEnterpriseAccountCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        var userName = UserName.Create(request.UserName);
        var email = Email.Create(request.Email);
        var phone = Phone.Create(request.CountryCode, request.Phone);
        var password = Password.Create(request.Password);
        var postalCode = PostalCode.Create(request.PostalCode);

        var result = ValidateValues(email, phone, password, postalCode);
        
        if (result.IsError)
        {
            return result.Errors;
        }
        
        var address = Address.Create(request.Street, request.Port, request.Locality, postalCode.Value);
        
        if (address.IsError)
        {
            return address.Errors;
        }
        
        // Check if user exists
        if (await _userRepository.ExistsUserByEmailAsync(email.Value, cancellationToken))
        {
            return Errors.User.EmailAlreadyExists;
        }
        
        // Create User
        Organization enterpriseAccount = Organization.Create(
            userName,
            request.TypeOption,
            email.Value,
            request.Name,
            password.Value,
            phone.Value,
            request.AvatarUrl,
            address.Value);
        
        // Persist User
        await _userRepository.AddAsync(enterpriseAccount, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var payload = new TokenPayload(
            enterpriseAccount.Id,
            enterpriseAccount.Email, 
            enterpriseAccount.Name,
            enterpriseAccount.AvatarUrl,
            10,
            10,
            10);
        
        // Generate Tokens
        var accessToken = _jwtProvider.GenerateToken(payload, Tokens.Access);
        var refreshToken = _jwtProvider.GenerateToken(payload, Tokens.Refresh);

        
        return new AuthenticationResult(
            accessToken,
            refreshToken);
    }

    private static ErrorOr<Email> ValidateValues(ErrorOr<Email> email, ErrorOr<Phone> phone, ErrorOr<Password> password, ErrorOr<PostalCode> postalCode)
    {
        return email
            .AddValidate(phone)
            .AddValidate(password)
            .AddValidate(postalCode);
    }
}