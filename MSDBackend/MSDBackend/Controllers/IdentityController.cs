using Microsoft.AspNetCore.Mvc;

namespace MSDBackend.Controllers
{
    [ApiController]
    [Route("identity")]
    public class IdentityController : Controller
    {
        [HttpPost("login")]
        public string GetToken()
        {
            return "asd";
        }
    }
}
