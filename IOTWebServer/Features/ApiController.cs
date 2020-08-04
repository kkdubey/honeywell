using Microsoft.AspNetCore.Mvc;

namespace IOTWebServer.Features
{

    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiController : ControllerBase
    {
    }
}
