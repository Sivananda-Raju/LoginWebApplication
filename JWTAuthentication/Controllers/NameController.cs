using JWTAuthentication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JWTAuthentication.Controllers
{
    [Authorize]
    [Route("api")]
    public class NameController : Controller
    {
        private readonly IJwtAuthenticationManager _jwtAuthenticationManager;
        public NameController(IJwtAuthenticationManager jwtAuthenticationManager)
        {
            _jwtAuthenticationManager = jwtAuthenticationManager;
        }
        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Credentials credentials)
        {
            var token = _jwtAuthenticationManager.Authenticate(credentials.UserName, credentials.Password);
            if (token == null)
                return Unauthorized();
            return Ok(token);
        }
        [HttpGet("users")]
        public async Task<IActionResult> getUsers()
        {
            return Ok(new string[] { "user1","user2"} );
        }

    }
}
