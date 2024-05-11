
using BeatEcoprove.Application.Shared.Multilanguage;

using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Route("ping")]
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