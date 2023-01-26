using Microsoft.AspNetCore.Mvc;
using MSDBackend.Application.Handler;
using MSDBackend.Application.Model;
using MSDBackend.Model;

namespace MSDBackend.Controllers
{
    [ApiController]
    [Route("smoking")]
    public class SmokingController : Controller
    {
        private readonly ISmokingHandler _smokinghandler;
        public SmokingController(ISmokingHandler smokingHandler) {
            _smokinghandler = smokingHandler;
        }

        [HttpGet("list")]
        public List<SmokeOccasionDto> GetSmokeOccasions()
        {
            return _smokinghandler.GetSmokeOccasions();
        }
    }
}
