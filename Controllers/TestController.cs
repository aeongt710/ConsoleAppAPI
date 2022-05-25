using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppAPI.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Hello from test/Get";
        }

        public string Get2()
        {
            return "Hello from test/Get2";
        }
    }
}
