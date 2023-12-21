using Microsoft.AspNetCore.Mvc;
using WebApplication13.Services;

namespace WebApplication13.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaptchaController : ControllerBase
    {

        private readonly ICaptchaService _captchaService;
        public CaptchaController(ICaptchaService captchaService)
        {
            _captchaService = captchaService;
        }
        [HttpGet]
        public IActionResult GetCaptcha()
        {
            var captchaImage = _captchaService.GetCaptcha();    
            return File(captchaImage, "image/jpeg");
        }
    }
}