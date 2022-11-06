using DeviceSecurity.Shared.Request;
using Microsoft.AspNetCore.Mvc;

namespace DeviceSecurity.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public AuthController()
        { 
            
        }

        [HttpPost]
        public IActionResult SignIn(Request<AccountData> request)
        {
            return Ok(); 
        }
    }
}
