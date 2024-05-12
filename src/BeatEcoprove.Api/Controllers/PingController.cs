
using Asp.Versioning;

using BeatEcoprove.Application.Shared.Multilanguage;

using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[ApiVersion(1)]
[Route("v{version:apiVersion}/ping")]
public class PingController : ApiController
{
    public PingController(ILanguageCulture localizer) : base(localizer)
    {
    }

    [HttpGet]
    public ActionResult<dynamic> PingServer()
    {
        return Ok(new { Message = "The server is online" });
    }
}