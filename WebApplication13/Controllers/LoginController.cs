using Microsoft.AspNetCore.Mvc;
using WebApplication13.Models;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly LoginService _loginService;
        public LoginController(LoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            return _loginService.Login(login);
        }
    }
}