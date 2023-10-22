using ErrorOr;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BeatEcoprove.Api.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    protected ActionResult<TResponse> Problem<TResponse>(List<Error> errors)
    {
        if (errors.All(error => error.Type == ErrorType.Validation))
        {
            var modelValidation = new ModelStateDictionary();

            foreach (var error in errors)
            {
                modelValidation.AddModelError(
                    error.Code,
                    error.Description);
            }
            
            return ValidationProblem(modelValidation);
        }
        
        var firstError = errors[0];

        var statusCode = firstError.Type switch
        {
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            _ => StatusCodes.Status500InternalServerError
        };
        
        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}