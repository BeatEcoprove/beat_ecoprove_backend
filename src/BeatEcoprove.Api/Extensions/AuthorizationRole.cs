using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BeatEcoprove.Api.Extensions;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public class AuthorizationRole : AuthorizeAttribute, IAuthorizationFilter
{
    private readonly string[] _roles;

    public AuthorizationRole(params string[] roles)
    {
        _roles = roles;
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var userType = context.HttpContext.User.GetUserType();

        if (HasRole(userType))
        {
            return;
        }

        context.Result = new UnauthorizedResult();
    }

    private bool HasRole(string userType)
    {
        return _roles.Any(role => role == userType);
    }
}