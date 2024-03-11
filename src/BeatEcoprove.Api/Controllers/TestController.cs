using BeatEcoprove.Application.Shared.Multilanguage;

using Microsoft.AspNetCore.Mvc;

namespace BeatEcoprove.Api.Controllers;

[Route("test")]
public class TestController : ApiController
{
    public TestController(ILanguageCulture localizer)
        : base(localizer)
    {
    }

    [HttpGet("hello")]
    public ActionResult<string> Get()
    {
        return Localizer.GetChunk("oi", "SLB!");
    }
}